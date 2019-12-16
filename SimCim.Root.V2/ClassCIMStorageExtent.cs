using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMStorageExtent : CIMLogicalDevice
    {
        protected CIMStorageExtent()
        {
        }

        protected CIMStorageExtent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Access
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Access", out result);
                return result;
            }
        }

        public System.UInt64? BlockSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BlockSize", out result);
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

        public System.UInt64? NumberOfBlocks
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberOfBlocks", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfBlocks", value);
            }
        }

        public System.String Purpose
        {
            get
            {
                System.String result;
                this.GetProperty("Purpose", out result);
                return result;
            }
        }
    }
}