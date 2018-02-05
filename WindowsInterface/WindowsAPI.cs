using System;
using System.IO;
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

        public static T ReadMemory<T>(IntPtr process, IntPtr address, int size)
        {
            if (process == IntPtr.Zero || address == IntPtr.Zero || size == 0)
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

        public static T ReadMemoryPointer<T>(IntPtr process, IntPtr address, int size)
        {
            IntPtr ptrAddress = ReadMemory<IntPtr>(process, address, Marshal.SizeOf(address));

            if (ptrAddress == IntPtr.Zero)
            {
                //Error
            }

            return ReadMemory<T>(process, ptrAddress, size);
        }

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

        public static bool WriteMemoryPointer<T>(IntPtr process, IntPtr address, T value)
        {
            IntPtr ptrAddress = ReadMemory<IntPtr>(process, address, Marshal.SizeOf(address));

            return WriteMemory(process, ptrAddress, value);
        }
    }

    public static class Disasm
    {

    }
}
