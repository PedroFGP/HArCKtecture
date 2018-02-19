using SharpDisasm;
using System;
using System.Collections.Generic;
using System.Linq;
using Binarysharp.Assemblers.Fasm;
using System.Diagnostics;

namespace WindowsAPI
{
    public static class Disasm
    {
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
        /// <returns>List of strings with assembly instructions representing the bytes</returns>
        public static List<string> DisassembleBytes(string bytes)
        {
            return DisassembleBytes(HexStringToByteArray(bytes.Trim()));
        }

        /// <summary>
        /// Translates bytes to assembly instructions.
        /// </summary>
        /// <param name="bytes">Byte array to disassemble</param>
        /// <returns>List of strings with assembly instructions representing the bytes</returns>
        public static List<string> DisassembleBytes(byte[] bytes)
        {
            var disasm = new Disassembler(bytes, ArchitectureMode.x86_32, 0, true);

            List<string> output = new List<string>();

            foreach (var line in disasm.Disassemble())
            {
                output.Add(line.ToString());
            }

            return output;
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
                codeBytes = FasmNet.Assemble(code);
            }
            catch (FasmAssemblerException ex)
            {
                Debug.WriteLine("Error definition: {0}; Error code: {1}; Error line: {2}; Error offset: {3}; Mnemonics: {4}",
                    ex.ErrorCode, (int)ex.ErrorCode, ex.ErrorLine, ex.ErrorOffset, ex.Mnemonics);
            }

            return codeBytes;
        }
    }
}
