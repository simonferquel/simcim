using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSlot : CIMPhysicalConnector
    {
        protected CIMSlot()
        {
        }

        protected CIMSlot(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Single? HeightAllowed
        {
            get
            {
                System.Single? result;
                this.GetProperty("HeightAllowed", out result);
                return result;
            }
        }

        public System.Single? LengthAllowed
        {
            get
            {
                System.Single? result;
                this.GetProperty("LengthAllowed", out result);
                return result;
            }
        }

        public System.UInt16? MaxDataWidth
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MaxDataWidth", out result);
                return result;
            }
        }

        public System.UInt16? Number
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Number", out result);
                return result;
            }
        }

        public System.String PurposeDescription
        {
            get
            {
                System.String result;
                this.GetProperty("PurposeDescription", out result);
                return result;
            }
        }

        public System.Boolean? SpecialPurpose
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SpecialPurpose", out result);
                return result;
            }
        }

        public System.Boolean? SupportsHotPlug
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsHotPlug", out result);
                return result;
            }
        }

        public System.UInt32? ThermalRating
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThermalRating", out result);
                return result;
            }
        }

        public System.UInt16[] VccMixedVoltageSupport
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("VccMixedVoltageSupport", out result);
                return result;
            }
        }

        public System.UInt16[] VppMixedVoltageSupport
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("VppMixedVoltageSupport", out result);
                return result;
            }
        }
    }
}