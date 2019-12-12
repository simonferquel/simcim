using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataAFDCountersMicrosoftWinsockBSP : Win32PerfRawData
    {
        public Win32PerfRawDataAFDCountersMicrosoftWinsockBSP()
        {
        }

        public Win32PerfRawDataAFDCountersMicrosoftWinsockBSP(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? DroppedDatagrams
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DroppedDatagrams", out result);
                return result;
            }

            set
            {
                this.SetProperty("DroppedDatagrams", value);
            }
        }

        public System.UInt32? DroppedDatagramsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DroppedDatagramsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DroppedDatagramsPersec", value);
            }
        }

        public System.UInt32? RejectedConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RejectedConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("RejectedConnections", value);
            }
        }

        public System.UInt32? RejectedConnectionsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RejectedConnectionsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RejectedConnectionsPersec", value);
            }
        }
    }
}