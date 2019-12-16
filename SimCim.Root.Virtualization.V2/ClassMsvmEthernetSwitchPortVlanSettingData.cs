using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchPortVlanSettingData : MsvmEthernetSwitchPortFeatureSettingData
    {
        public MsvmEthernetSwitchPortVlanSettingData()
        {
        }

        public MsvmEthernetSwitchPortVlanSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AccessVlanId
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AccessVlanId", out result);
                return result;
            }

            set
            {
                this.SetProperty("AccessVlanId", value);
            }
        }

        public System.UInt16? NativeVlanId
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NativeVlanId", out result);
                return result;
            }

            set
            {
                this.SetProperty("NativeVlanId", value);
            }
        }

        public System.UInt32? OperationMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OperationMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("OperationMode", value);
            }
        }

        public System.UInt16? PrimaryVlanId
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PrimaryVlanId", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrimaryVlanId", value);
            }
        }

        public System.UInt16[] PruneVlanIdArray
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("PruneVlanIdArray", out result);
                return result;
            }

            set
            {
                this.SetProperty("PruneVlanIdArray", value);
            }
        }

        public System.UInt32? PvlanMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PvlanMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("PvlanMode", value);
            }
        }

        public System.UInt16? SecondaryVlanId
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SecondaryVlanId", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecondaryVlanId", value);
            }
        }

        public System.UInt16[] SecondaryVlanIdArray
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("SecondaryVlanIdArray", out result);
                return result;
            }

            set
            {
                this.SetProperty("SecondaryVlanIdArray", value);
            }
        }

        public System.UInt16[] TrunkVlanIdArray
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("TrunkVlanIdArray", out result);
                return result;
            }

            set
            {
                this.SetProperty("TrunkVlanIdArray", value);
            }
        }
    }
}