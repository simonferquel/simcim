using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfOSObjects : Win32PerfRawData
    {
        public Win32PerfRawDataPerfOSObjects()
        {
        }

        public Win32PerfRawDataPerfOSObjects(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Events
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Events", out result);
                return result;
            }

            set
            {
                this.SetProperty("Events", value);
            }
        }

        public System.UInt32? Mutexes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Mutexes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Mutexes", value);
            }
        }

        public System.UInt32? Processes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Processes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Processes", value);
            }
        }

        public System.UInt32? Sections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Sections", out result);
                return result;
            }

            set
            {
                this.SetProperty("Sections", value);
            }
        }

        public System.UInt32? Semaphores
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Semaphores", out result);
                return result;
            }

            set
            {
                this.SetProperty("Semaphores", value);
            }
        }

        public System.UInt32? Threads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Threads", out result);
                return result;
            }

            set
            {
                this.SetProperty("Threads", value);
            }
        }
    }
}