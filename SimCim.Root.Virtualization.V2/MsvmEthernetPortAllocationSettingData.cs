using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetPortAllocationSettingData : CIMEthernetPortAllocationSettingData
    {
        public MsvmEthernetPortAllocationSettingData()
        {
        }

        public MsvmEthernetPortAllocationSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CompartmentGuid
        {
            get
            {
                System.String result;
                this.GetProperty("CompartmentGuid", out result);
                return result;
            }

            set
            {
                this.SetProperty("CompartmentGuid", value);
            }
        }

        public System.UInt16? EnabledState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnabledState", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnabledState", value);
            }
        }

        public System.String LastKnownSwitchName
        {
            get
            {
                System.String result;
                this.GetProperty("LastKnownSwitchName", out result);
                return result;
            }
        }

        public System.String[] RequiredFeatureHints
        {
            get
            {
                System.String[] result;
                this.GetProperty("RequiredFeatureHints", out result);
                return result;
            }
        }

        public System.String[] RequiredFeatures
        {
            get
            {
                System.String[] result;
                this.GetProperty("RequiredFeatures", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequiredFeatures", value);
            }
        }

        public System.String TestReplicaPoolID
        {
            get
            {
                System.String result;
                this.GetProperty("TestReplicaPoolID", out result);
                return result;
            }

            set
            {
                this.SetProperty("TestReplicaPoolID", value);
            }
        }

        public System.String TestReplicaSwitchName
        {
            get
            {
                System.String result;
                this.GetProperty("TestReplicaSwitchName", out result);
                return result;
            }

            set
            {
                this.SetProperty("TestReplicaSwitchName", value);
            }
        }

        public IEnumerable<MsvmEthernetSwitchPortFeatureSettingData> ResolveMsvmEthernetPortSettingDataComponentPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_EthernetPortSettingDataComponent", "Msvm_EthernetSwitchPortFeatureSettingData", "GroupComponent", "PartComponent");
            return instances.Select(i => (MsvmEthernetSwitchPortFeatureSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}