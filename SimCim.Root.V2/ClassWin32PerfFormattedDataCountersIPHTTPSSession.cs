using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersIPHTTPSSession : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersIPHTTPSSession()
        {
        }

        public Win32PerfFormattedDataCountersIPHTTPSSession(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? Bytesreceivedonthissession
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Bytesreceivedonthissession", out result);
                return result;
            }

            set
            {
                this.SetProperty("Bytesreceivedonthissession", value);
            }
        }

        public System.UInt64? Bytessentonthissession
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Bytessentonthissession", out result);
                return result;
            }

            set
            {
                this.SetProperty("Bytessentonthissession", value);
            }
        }

        public System.UInt64? DurationDurationofthesessionSeconds
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DurationDurationofthesessionSeconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("DurationDurationofthesessionSeconds", value);
            }
        }

        public System.UInt64? ErrorsReceiveerrorsonthissession
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ErrorsReceiveerrorsonthissession", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsReceiveerrorsonthissession", value);
            }
        }

        public System.UInt64? ErrorsTransmiterrorsonthissession
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ErrorsTransmiterrorsonthissession", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorsTransmiterrorsonthissession", value);
            }
        }

        public System.UInt64? Packetsreceivedonthissession
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Packetsreceivedonthissession", out result);
                return result;
            }

            set
            {
                this.SetProperty("Packetsreceivedonthissession", value);
            }
        }

        public System.UInt64? Packetssentonthissession
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Packetssentonthissession", out result);
                return result;
            }

            set
            {
                this.SetProperty("Packetssentonthissession", value);
            }
        }
    }
}