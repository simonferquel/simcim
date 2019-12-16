using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmBIOSElement : CIMBIOSElement
    {
        public MsvmBIOSElement()
        {
        }

        public MsvmBIOSElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BaseBoardSerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("BaseBoardSerialNumber", out result);
                return result;
            }
        }

        public System.String BIOSGUID
        {
            get
            {
                System.String result;
                this.GetProperty("BIOSGUID", out result);
                return result;
            }
        }

        public System.Boolean? BIOSNumLock
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BIOSNumLock", out result);
                return result;
            }
        }

        public System.String BIOSSerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("BIOSSerialNumber", out result);
                return result;
            }
        }

        public System.UInt16[] BootOrder
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("BootOrder", out result);
                return result;
            }
        }

        public System.Boolean? BootPciExpress
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BootPciExpress", out result);
                return result;
            }
        }

        public System.String BootPciExpressInstanceFilter
        {
            get
            {
                System.String result;
                this.GetProperty("BootPciExpressInstanceFilter", out result);
                return result;
            }
        }

        public System.String ChassisAssetTag
        {
            get
            {
                System.String result;
                this.GetProperty("ChassisAssetTag", out result);
                return result;
            }
        }

        public System.String ChassisSerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("ChassisSerialNumber", out result);
                return result;
            }
        }

        public System.Boolean? EnableHibernation
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableHibernation", out result);
                return result;
            }
        }

        public IEnumerable<CIMComputerSystem> ResolveMsvmSystemBIOSGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SystemBIOS", "CIM_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}