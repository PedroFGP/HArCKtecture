using SharpDisasm;
using System;
using System.Collections.Generic;
using System.Linq;
using Binarysharp.Assemblers.Fasm;
using System.Diagnostics;
using System.Text;

namespace WindowsAPI
{
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
        /// <param name="bytes">Byte array to disassemble</param>
        /// <returns>Dictionary of strings with assembly instructions representing the bytes</returns>
        public static List<InstructionRepresentation> DisassembleBytes(ulong address, byte[] bytes)
        {
            Disassembler.Translator.IncludeAddress = true;

            var disasm = new Disassembler(bytes, ArchitectureMode.x86_32, address, true);

            var instructions = new List<InstructionRepresentation>();

            while(instructions.Count < 128)
            {
                var instruction = disasm.NextInstruction();

                var parts = instruction.ToString().Split(new[] { ' ' }, 2);

                instructions.Add(new InstructionRepresentation() {
                    Address = parts[0],
                    Bytes = instruction.Bytes,
                    Opcodes = parts.Last()
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
