﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSwitchService : CIMForwardingService
    {
        protected CIMSwitchService()
        {
        }

        protected CIMSwitchService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BridgeAddress
        {
            get
            {
                System.String result;
                this.GetProperty("BridgeAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("BridgeAddress", value);
            }
        }

        public System.UInt16? BridgeAddressType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("BridgeAddressType", out result);
                return result;
            }

            set
            {
                this.SetProperty("BridgeAddressType", value);
            }
        }

        public System.Byte? BridgeType
        {
            get
            {
                System.Byte? result;
                this.GetProperty("BridgeType", out result);
                return result;
            }

            set
            {
                this.SetProperty("BridgeType", value);
            }
        }

        public System.UInt16? NumPorts
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NumPorts", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumPorts", value);
            }
        }

        public IEnumerable<CIMTransparentBridgingService> ResolveCIMSwitchServiceTransparentBridgingPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SwitchServiceTransparentBridging", "CIM_TransparentBridgingService", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMTransparentBridgingService)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMSwitchPort ResolveCIMSwitchesAmongAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SwitchesAmong", "CIM_SwitchPort", "Dependent", "Antecedent");
            return instances.Select(i => (CIMSwitchPort)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}