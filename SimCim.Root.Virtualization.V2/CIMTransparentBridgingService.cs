using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMTransparentBridgingService : CIMForwardingService
    {
        protected CIMTransparentBridgingService()
        {
        }

        protected CIMTransparentBridgingService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AgingTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AgingTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("AgingTime", value);
            }
        }

        public System.UInt32? FID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FID", out result);
                return result;
            }

            set
            {
                this.SetProperty("FID", value);
            }
        }

        public CIMSwitchService ResolveCIMSwitchServiceTransparentBridgingGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SwitchServiceTransparentBridging", "CIM_SwitchService", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMSwitchService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMDynamicForwardingEntry ResolveCIMTransparentBridgingDynamicForwardingDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_TransparentBridgingDynamicForwarding", "CIM_DynamicForwardingEntry", "Antecedent", "Dependent");
            return instances.Select(i => (CIMDynamicForwardingEntry)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}