using System;
using System.Diagnostics;
using System.Globalization;

namespace WindowsAPI
{
    public class WindowsProcess
    {
        public Process ProcessInstance { get; }
        public IntPtr Handle { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsProcess"/> class.
        /// </summary>
        /// <param name="name">The process name without '.exe'.</param>
        public WindowsProcess(string name)
        {
            Process[] processesByName = Process.GetProcessesByName(name);

            if (processesByName.Length > 0)
            {
                ProcessInstance = processesByName[0];

                Handle = WindowsAPI.OpenProcess(ProcessAccessFlags.All, false, ProcessInstance.Id);
            }
            else
            {
                ProcessInstance = null;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsProcess"/> class.
        /// </summary>
        /// <param name="id">The process id.</param>
        public WindowsProcess(int id)
        {
            ProcessInstance = Process.GetProcessById(id);

            if (ProcessInstance != null)
            {
                Handle = WindowsAPI.OpenProcess(ProcessAccessFlags.All, false, ProcessInstance.Id);
            }
            else
            {
                //Error
            }
        }

        /// <summary>
        /// Suspends all threads from current process.
        /// </summary>
        public void SuspendAllThreads()
        {
            if (ProcessInstance == null)
            {
                //Error
            }

            foreach (ProcessThread thread in ProcessInstance.Threads)
            {
                IntPtr openThread = WindowsAPI.OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)thread.Id);

                if (openThread == IntPtr.Zero)
                {
                    break;
                }

                WindowsAPI.SuspendThread(openThread);
            }
        }

        /// <summary>
        /// Resumes all threads from current process.
        /// </summary>
        public void ResumeAllThreads()
        {
            if (ProcessInstance == null)
            {
                //Error
            }

            foreach (ProcessThread thread in ProcessInstance.Threads)
            {
                IntPtr openThread = WindowsAPI.OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)thread.Id);

                if (openThread == IntPtr.Zero)
                {
                    break;
                }

                WindowsAPI.ResumeThread(openThread);
            }
        }
    }

    public static class ProcessExtensions
    {
        public static IntPtr StringToAddress(string address)
        {
            IntPtr value = IntPtr.Zero;

            var hexResult = int.TryParse(address, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int outputHex);

            if (hexResult)
            {
                value = (IntPtr)outputHex;
            }
            else
            {
                var decResult = int.TryParse(address, out int outputDecimal);

                if (hexResult)
                {
                    value = (IntPtr)outputDecimal;
                }
            }

            return value;
        }
    }
}
