using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMDynamicForwardingEntry : CIMLogicalElement
    {
        protected CIMDynamicForwardingEntry()
        {
        }

        protected CIMDynamicForwardingEntry(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("CreationClassName", value);
            }
        }

        public System.UInt16? DynamicStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DynamicStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("DynamicStatus", value);
            }
        }

        public System.String MACAddress
        {
            get
            {
                System.String result;
                this.GetProperty("MACAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("MACAddress", value);
            }
        }

        public System.String ServiceCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("ServiceCreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServiceCreationClassName", value);
            }
        }

        public System.String ServiceName
        {
            get
            {
                System.String result;
                this.GetProperty("ServiceName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServiceName", value);
            }
        }

        public System.String SystemCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemCreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemCreationClassName", value);
            }
        }

        public System.String SystemName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemName", value);
            }
        }
    }
}