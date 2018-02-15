using SharpDisasm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsAPI
{
    [Flags]
    public enum ProcessAccessFlags : uint
    {
        All = 0x001F0FFF,
        Terminate = 0x00000001,
        CreateThread = 0x00000002,
        VirtualMemoryOperation = 0x00000008,
        VirtualMemoryRead = 0x00000010,
        VirtualMemoryWrite = 0x00000020,
        DuplicateHandle = 0x00000040,
        CreateProcess = 0x000000080,
        SetQuota = 0x00000100,
        SetInformation = 0x00000200,
        QueryInformation = 0x00000400,
        QueryLimitedInformation = 0x00001000,
        Synchronize = 0x00100000
    }

    [Flags]
    public enum ThreadAccess : int
    {
        TERMINATE = 0x0001,
        SUSPEND_RESUME = 0x0002,
        GET_CONTEXT = 0x0008,
        SET_CONTEXT = 0x0010,
        SET_INFORMATION = 0x0020,
        QUERY_INFORMATION = 0x0040,
        SET_THREAD_TOKEN = 0x0080,
        IMPERSONATE = 0x0100,
        DIRECT_IMPERSONATION = 0x0200
    }

    public static class SizeOfCache<T>
    {
        public static readonly int SizeOf;

        static SizeOfCache()
        {
            var dynamicMethod = new DynamicMethod("func", typeof(int), Type.EmptyTypes, typeof(WindowsAPI));

            ILGenerator intermediateLanguage = dynamicMethod.GetILGenerator();
            intermediateLanguage.Emit(OpCodes.Sizeof, typeof(T));
            intermediateLanguage.Emit(OpCodes.Ret);

            var func = (Func<int>)dynamicMethod.CreateDelegate(typeof(Func<int>));
            SizeOf = func();
        }
    }

    public static class WindowsAPI
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, out byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int SuspendThread(IntPtr hThread);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint ResumeThread(IntPtr hThread);

        /// <summary>
        /// Reads the value of an address from a process.
        /// </summary>
        /// <typeparam name="T">Type to convert the read bytes.</typeparam>
        /// <param name="process">The process handle.</param>
        /// <param name="address">The address pointer to be read.</param>
        /// <param name="size">The quantity of bytes to read.</param>
        /// <returns>The typed array of bytes read.</returns>
        public static T ReadMemory<T>(IntPtr process, IntPtr address, int size)
        {
            if (process == IntPtr.Zero || address == IntPtr.Zero)
            {
                //Error
            }

            byte[] buffer = new byte[size];

            ReadProcessMemory(process, address, out buffer, size, out IntPtr bytesRead);

            if (size != bytesRead.ToInt32())
            {
                //Error
            }

            BinaryFormatter bf = new BinaryFormatter();

            using (MemoryStream ms = new MemoryStream(buffer))
            {
                object obj = bf.Deserialize(ms);
                return (T)obj;
            }
        }

        public static T ReadMemory<T>(IntPtr process, IntPtr address)
        {
            return ReadMemory<T>(process, address, SizeOf<T>());
        }

        /// <summary>
        /// Reads the value of a pointer from a process.
        /// </summary>
        /// <typeparam name="T">Type to convert the read bytes.</typeparam>
        /// <param name="process">The process handle.</param>
        /// <param name="address">The address pointer to be read.</param>
        /// <param name="size">The quantity of bytes to read.</param>
        /// <returns>The typed array of bytes read.</returns>
        public static T ReadMemoryPointer<T>(IntPtr process, IntPtr address, int size)
        {
            IntPtr ptrAddress = ReadMemory<IntPtr>(process, address, Marshal.SizeOf(address));

            if (ptrAddress == IntPtr.Zero)
            {
                //Error
            }

            return ReadMemory<T>(process, ptrAddress, size);
        }

        public static T ReadMemoryPointer<T>(IntPtr process, IntPtr address)
        {
            return ReadMemoryPointer<T>(process, address, SizeOf<T>());
        }

        /// <summary>
        /// Writes a value to an address from a process.
        /// </summary>
        /// <typeparam name="T">Value type.</typeparam>
        /// <param name="process">The process handle.</param>
        /// <param name="address">The address to be writen to.</param>
        /// <param name="value">The value to write to the address.</param>
        /// <returns>Returns true on success, false on error.</returns>
        public static bool WriteMemory<T>(IntPtr process, IntPtr address, T value)
        {
            if (process == IntPtr.Zero || address == IntPtr.Zero)
            {
                //Error
            }

            byte[] valueByte;

            BinaryFormatter bf = new BinaryFormatter();

            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, value);
                valueByte = ms.ToArray();
            }

            WriteProcessMemory(process, address, valueByte, (uint)valueByte.Length, out UIntPtr bytesWritten);

            if (valueByte.Length != bytesWritten.ToUInt32())
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Writes a value to a pointer from a process.
        /// </summary>
        /// <typeparam name="T">Value Type.</typeparam>
        /// <param name="process">The process handle.</param>
        /// <param name="address">The address pointer to be writen to.</param>
        /// <param name="value">The value to write to the address.</param>
        /// <returns>Returns true on success, false on error.</returns>
        public static bool WriteMemoryPointer<T>(IntPtr process, IntPtr address, T value)
        {
            IntPtr ptrAddress = ReadMemory<IntPtr>(process, address, Marshal.SizeOf(address));

            return WriteMemory(process, ptrAddress, value);
        }

        public static int SizeOf<T>()
        {
            return SizeOfCache<T>.SizeOf;
        }
    }

    public static class Disasm
    {
        static byte[] HexStringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public static List<string> DisassembleBytes(string bytes)
        {
            return DisassembleBytes(HexStringToByteArray(bytes.Trim()));
        }

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
}
