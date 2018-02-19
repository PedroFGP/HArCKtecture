using Binarysharp.MemoryManagement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAPI
{
    public class WindowsProcess
    {
        public MemorySharp Memory { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsProcess"/> class.
        /// </summary>
        /// <param name="processName">Name of the target process.</param>
        /// <param name="startProcess">if set to <c>true</c> [start process] then starts the process by it's path.</param>
        public WindowsProcess(string processName, bool startProcess)
        {
            if(startProcess && File.Exists(processName))
            {
                Memory = new MemorySharp(Process.Start(processName));
            }
            else
            {
                processName = processName.Replace(".exe", "");

                var procHandle = Process.GetProcessesByName(processName).FirstOrDefault();

                if (procHandle != null)
                {
                    Memory = new MemorySharp(procHandle);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsProcess"/> class using the target process identifier.
        /// </summary>
        /// <param name="processId">The target process identifier.</param>
        public WindowsProcess(int processId)
        {
            Memory = new MemorySharp(processId);
        }
    }
}
