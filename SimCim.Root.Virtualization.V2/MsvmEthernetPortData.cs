using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class MsvmEthernetPortData : CIMManagedElement
    {
        protected MsvmEthernetPortData()
        {
        }

        protected MsvmEthernetPortData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String DeviceCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceCreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeviceCreationClassName", value);
            }
        }

        public System.String DeviceID
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceID", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeviceID", value);
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }

            set
            {
                this.SetProperty("Name", value);
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

        public MsvmEthernetSwitchPort ResolveMsvmEthernetPortInfoAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_EthernetPortInfo", "Msvm_EthernetSwitchPort", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmEthernetSwitchPort)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}