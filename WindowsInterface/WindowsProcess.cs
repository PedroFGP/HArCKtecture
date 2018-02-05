using System;
using System.Diagnostics;

namespace WindowsAPI
{
    public class WindowsProcess
    {
        public Process ProcessInstance { get; }
        public IntPtr Handle { get; }

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

        public WindowsProcess(int id)
        {
            ProcessInstance = Process.GetProcessById(id);

            if(ProcessInstance != null)
            {
                Handle = WindowsAPI.OpenProcess(ProcessAccessFlags.All, false, ProcessInstance.Id);
            }
            else
            {
                //Error
            }
        }

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
}
