using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmMountedStorageImage : CIMLogicalElement
    {
        public MsvmMountedStorageImage()
        {
        }

        public MsvmMountedStorageImage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.Byte? Lun
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Lun", out result);
                return result;
            }
        }

        public System.Byte? PathId
        {
            get
            {
                System.Byte? result;
                this.GetProperty("PathId", out result);
                return result;
            }
        }

        public System.String PnpDevicePath
        {
            get
            {
                System.String result;
                this.GetProperty("PnpDevicePath", out result);
                return result;
            }
        }

        public System.Byte? PortNumber
        {
            get
            {
                System.Byte? result;
                this.GetProperty("PortNumber", out result);
                return result;
            }
        }

        public System.Byte? TargetId
        {
            get
            {
                System.Byte? result;
                this.GetProperty("TargetId", out result);
                return result;
            }
        }

        public System.UInt16? Type
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Type", out result);
                return result;
            }
        }

        public System.UInt32 DetachVirtualHardDisk()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DetachVirtualHardDisk", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}