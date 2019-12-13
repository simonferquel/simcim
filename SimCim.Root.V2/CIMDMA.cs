using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDMA : CIMSystemResource
    {
        protected CIMDMA()
        {
        }

        protected CIMDMA(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AddressSize
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AddressSize", out result);
                return result;
            }
        }

        public System.UInt16? Availability
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Availability", out result);
                return result;
            }
        }

        public System.Boolean? BurstMode
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BurstMode", out result);
                return result;
            }
        }

        public System.UInt16? ByteMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ByteMode", out result);
                return result;
            }
        }

        public System.UInt16? ChannelTiming
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ChannelTiming", out result);
                return result;
            }
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }
        }

        public System.String CSCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CSCreationClassName", out result);
                return result;
            }
        }

        public System.String CSName
        {
            get
            {
                System.String result;
                this.GetProperty("CSName", out result);
                return result;
            }
        }

        public System.UInt32 DMAChannel
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("DMAChannel", out result);
                return result;
            }
        }

        public System.UInt32? MaxTransferSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxTransferSize", out result);
                return result;
            }
        }

        public System.UInt16[] TransferWidths
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("TransferWidths", out result);
                return result;
            }
        }

        public System.UInt16? TypeCTiming
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TypeCTiming", out result);
                return result;
            }
        }

        public System.UInt16? WordMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("WordMode", out result);
                return result;
            }
        }
    }
}