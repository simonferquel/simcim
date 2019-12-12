using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMMediaAccessDevice : CIMLogicalDevice
    {
        protected CIMMediaAccessDevice()
        {
        }

        protected CIMMediaAccessDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] Capabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("Capabilities", out result);
                return result;
            }
        }

        public System.String[] CapabilityDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("CapabilityDescriptions", out result);
                return result;
            }
        }

        public System.String CompressionMethod
        {
            get
            {
                System.String result;
                this.GetProperty("CompressionMethod", out result);
                return result;
            }
        }

        public System.UInt64? DefaultBlockSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DefaultBlockSize", out result);
                return result;
            }
        }

        public System.String ErrorMethodology
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorMethodology", out result);
                return result;
            }
        }

        public System.UInt64? MaxBlockSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxBlockSize", out result);
                return result;
            }
        }

        public System.UInt64? MaxMediaSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxMediaSize", out result);
                return result;
            }
        }

        public System.UInt64? MinBlockSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinBlockSize", out result);
                return result;
            }
        }

        public System.Boolean? NeedsCleaning
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NeedsCleaning", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfMediaSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfMediaSupported", out result);
                return result;
            }
        }
    }
}