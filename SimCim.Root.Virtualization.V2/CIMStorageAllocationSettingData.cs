using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMStorageAllocationSettingData : CIMResourceAllocationSettingData
    {
        protected CIMStorageAllocationSettingData()
        {
        }

        protected CIMStorageAllocationSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

            set
            {
                this.SetProperty("Access", value);
            }
        }

        public System.String HostExtentName
        {
            get
            {
                System.String result;
                this.GetProperty("HostExtentName", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostExtentName", value);
            }
        }

        public System.UInt16? HostExtentNameFormat
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HostExtentNameFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostExtentNameFormat", value);
            }
        }

        public System.UInt16? HostExtentNameNamespace
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HostExtentNameNamespace", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostExtentNameNamespace", value);
            }
        }

        public System.UInt64? HostExtentStartingAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HostExtentStartingAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostExtentStartingAddress", value);
            }
        }

        public System.UInt64? HostResourceBlockSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HostResourceBlockSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostResourceBlockSize", value);
            }
        }

        public System.String OtherHostExtentNameFormat
        {
            get
            {
                System.String result;
                this.GetProperty("OtherHostExtentNameFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherHostExtentNameFormat", value);
            }
        }

        public System.String OtherHostExtentNameNamespace
        {
            get
            {
                System.String result;
                this.GetProperty("OtherHostExtentNameNamespace", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherHostExtentNameNamespace", value);
            }
        }

        public System.UInt64? VirtualResourceBlockSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualResourceBlockSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualResourceBlockSize", value);
            }
        }
    }
}