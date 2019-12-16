using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMNetworkAdapter : CIMLogicalDevice
    {
        protected CIMNetworkAdapter()
        {
        }

        protected CIMNetworkAdapter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AutoSense
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AutoSense", out result);
                return result;
            }
        }

        public System.UInt64? MaxSpeed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxSpeed", out result);
                return result;
            }
        }

        public System.String[] NetworkAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("NetworkAddresses", out result);
                return result;
            }
        }

        public System.String PermanentAddress
        {
            get
            {
                System.String result;
                this.GetProperty("PermanentAddress", out result);
                return result;
            }
        }

        public System.UInt64? Speed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Speed", out result);
                return result;
            }
        }
    }
}