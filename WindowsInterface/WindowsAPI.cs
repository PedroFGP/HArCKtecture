﻿using SharpDisasm;
using System;
using System.Collections.Generic;
using System.Linq;
using Binarysharp.Assemblers.Fasm;
using System.Text;
using SharpDisasm.Udis86;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsAPI
{
    public static class FileExtensions
    {
        const int ERROR_SHARING_VIOLATION = 32;
        const int ERROR_LOCK_VIOLATION = 33;

        public static bool IsFileLocked(string file)
        {
            //check that problem is not in destination file
            if (File.Exists(file) == true)
            {
                FileStream stream = null;
                try
                {
                    stream = File.Open(file, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                }
                catch (Exception ex2)
                {
                    //_log.WriteLog(ex2, "Error in checking whether file is locked " + file);
                    int errorCode = Marshal.GetHRForException(ex2) & ((1 << 16) - 1);
                    if ((ex2 is IOException) && (errorCode == ERROR_SHARING_VIOLATION || errorCode == ERROR_LOCK_VIOLATION))
                    {
                        return true;
                    }
                }
                finally
                {
                    if (stream != null)
                        stream.Close();
                }
            }
            return false;
        }
    }

    public static class Disasm
    {
        /// <summary>
        /// Transforms the hexadecimal string into a byte array.
        /// </summary>
        /// <param name="hex">The hexadecimal string.</param>
        /// <returns>Byte array that represents the hexadecimal string.</returns>
        private static byte[] HexStringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        /// <summary>
        /// Translates bytes to assembly instructions.
        /// </summary>
        /// <param name="bytes">Byte array in string format</param>
        /// <returns>Dictionary of strings with assembly instructions representing the bytes</returns>
        public static List<InstructionRepresentation> DisassembleBytes(string bytes)
        {
            return DisassembleBytes(0, HexStringToByteArray(bytes.Trim()));
        }

        /// <summary>
        /// Translates bytes to assembly instructions.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="bytes">Byte array to disassemble</param>
        /// <param name="relativeAddresses"></param>
        /// <returns>Dictionary of strings with assembly instructions representing the bytes</returns>
        public static List<InstructionRepresentation> DisassembleBytes(ulong address, byte[] bytes, bool relativeAddresses = true)
        {
            Disassembler.Translator.IncludeAddress = true;

            var disasm = new Disassembler(bytes, ArchitectureMode.x86_32, address, true);

            var instructions = new List<InstructionRepresentation>();

            while(instructions.Count < 128)
            {
                var instruction = disasm.NextInstruction();

                var parts = instruction.ToString().Split(new[] { ' ' }, 2);

                string opcode = parts.Last();

                if(relativeAddresses)
                {
                    if (instruction.Bytes.Length == 2 && instruction.Mnemonic >= ud_mnemonic_code.UD_Ija && instruction.Mnemonic <= ud_mnemonic_code.UD_Ijz)
                    {
                        opcode = opcode.Split(' ')[0] + " 0x" + (instruction.Operands[0].LvalSByte + instruction.Bytes.Length).ToString("X").PadLeft(2, '0');
                    }

                    if (instruction.Bytes.Length == 5 && instruction.Mnemonic == ud_mnemonic_code.UD_Icall)
                    {
                        opcode = opcode.Split(' ')[0] + " 0x" + (instruction.Operands[0].Value + instruction.Bytes.Length).ToString("X").ToUpper();
                    }
                }

                instructions.Add(new InstructionRepresentation() {
                    Address = parts[0],
                    Bytes = instruction.Bytes,
                    Opcodes = opcode
                });
            }

            return instructions;
        }
    }

    public static class Asm
    {
        /// <summary>
        /// Assembles the assembly code in ready to inject/use byte array.
        /// </summary>
        /// <param name="code">Assembly code, can be multi-line.</param>
        /// <returns>Byte array of the translated assembly code in x86.</returns>
        public static byte[] AssembleInstructions(string code)
        {
            byte[] codeBytes = null;

            try
            {
                codeBytes = FasmNet.Assemble("use32" + Environment.NewLine + code);
            }
            catch (FasmAssemblerException ex)
            {
                return codeBytes;
            }

            return codeBytes;
        }
    }

    public static class ByteExtension
    {
        public static string ByteToHexBitFiddle(byte[] bytes)
        {
            char[] c = new char[bytes.Length * 2];
            int b;

            for (int i = 0; i < bytes.Length; i++)
            {
                b = bytes[i] >> 4;
                c[i * 2] = (char)(55 + b + (((b - 10) >> 31) & -7));
                b = bytes[i] & 0xF;
                c[i * 2 + 1] = (char)(55 + b + (((b - 10) >> 31) & -7));
            }

            return new string(c);
        }

        public static string ByteToHexSplit(byte[] bytes, int chunkSize)
        {
            var finalString = new StringBuilder();

            foreach(var chunk in Split(ByteToHexBitFiddle(bytes), chunkSize))
            {
                finalString.Append(chunk + " ");
            }

            return finalString.ToString();
        }

        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}
