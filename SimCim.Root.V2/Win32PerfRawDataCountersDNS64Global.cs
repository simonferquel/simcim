using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersDNS64Global : Win32PerfRawData
    {
        public Win32PerfRawDataCountersDNS64Global()
        {
        }

        public Win32PerfRawDataCountersDNS64Global(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AAAAqueriesFailed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AAAAqueriesFailed", out result);
                return result;
            }

            set
            {
                this.SetProperty("AAAAqueriesFailed", value);
            }
        }

        public System.UInt64? AAAAqueriesSuccessful
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AAAAqueriesSuccessful", out result);
                return result;
            }

            set
            {
                this.SetProperty("AAAAqueriesSuccessful", value);
            }
        }

        public System.UInt64? AAAASynthesizedrecords
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AAAASynthesizedrecords", out result);
                return result;
            }

            set
            {
                this.SetProperty("AAAASynthesizedrecords", value);
            }
        }

        public System.UInt64? IP6ARPAqueriesMatched
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IP6ARPAqueriesMatched", out result);
                return result;
            }

            set
            {
                this.SetProperty("IP6ARPAqueriesMatched", value);
            }
        }

        public System.UInt64? OtherqueriesFailed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherqueriesFailed", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherqueriesFailed", value);
            }
        }

        public System.UInt64? OtherqueriesSuccessful
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherqueriesSuccessful", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherqueriesSuccessful", value);
            }
        }
    }
}