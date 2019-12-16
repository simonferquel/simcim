using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPhysicalPackage : CIMPhysicalElement
    {
        protected CIMPhysicalPackage()
        {
        }

        protected CIMPhysicalPackage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Single? Depth
        {
            get
            {
                System.Single? result;
                this.GetProperty("Depth", out result);
                return result;
            }
        }

        public System.Single? Height
        {
            get
            {
                System.Single? result;
                this.GetProperty("Height", out result);
                return result;
            }
        }

        public System.Boolean? HotSwappable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HotSwappable", out result);
                return result;
            }
        }

        public System.Boolean? Removable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Removable", out result);
                return result;
            }
        }

        public System.Boolean? Replaceable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Replaceable", out result);
                return result;
            }
        }

        public System.Single? Weight
        {
            get
            {
                System.Single? result;
                this.GetProperty("Weight", out result);
                return result;
            }
        }

        public System.Single? Width
        {
            get
            {
                System.Single? result;
                this.GetProperty("Width", out result);
                return result;
            }
        }

        public System.UInt32 IsCompatible(CIMPhysicalElement inElementToCheck)
        {
            var parameters = new CimMethodParametersCollection();
            if (inElementToCheck != null)
                parameters.Add(CimMethodParameter.Create("ElementToCheck", inElementToCheck.AsCimInstance(), CimType.Reference, inElementToCheck == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "IsCompatible", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}