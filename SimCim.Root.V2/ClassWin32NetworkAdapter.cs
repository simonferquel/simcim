using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NetworkAdapter : CIMNetworkAdapter
    {
        public Win32NetworkAdapter()
        {
        }

        public Win32NetworkAdapter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AdapterType
        {
            get
            {
                System.String result;
                this.GetProperty("AdapterType", out result);
                return result;
            }
        }

        public System.UInt16? AdapterTypeId
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AdapterTypeId", out result);
                return result;
            }
        }

        public System.String GUID
        {
            get
            {
                System.String result;
                this.GetProperty("GUID", out result);
                return result;
            }
        }

        public System.UInt32? Index
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Index", out result);
                return result;
            }
        }

        public System.Boolean? Installed
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Installed", out result);
                return result;
            }
        }

        public System.UInt32? InterfaceIndex
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterfaceIndex", out result);
                return result;
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
        }

        public System.String Manufacturer
        {
            get
            {
                System.String result;
                this.GetProperty("Manufacturer", out result);
                return result;
            }
        }

        public System.UInt32? MaxNumberControlled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumberControlled", out result);
                return result;
            }
        }

        public System.String NetConnectionID
        {
            get
            {
                System.String result;
                this.GetProperty("NetConnectionID", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetConnectionID", value);
            }
        }

        public System.UInt16? NetConnectionStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NetConnectionStatus", out result);
                return result;
            }
        }

        public System.Boolean? NetEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NetEnabled", out result);
                return result;
            }
        }

        public System.Boolean? PhysicalAdapter
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PhysicalAdapter", out result);
                return result;
            }
        }

        public System.String ProductName
        {
            get
            {
                System.String result;
                this.GetProperty("ProductName", out result);
                return result;
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
        }

        public System.DateTime? TimeOfLastReset
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeOfLastReset", out result);
                return result;
            }
        }

        public System.UInt32 Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}