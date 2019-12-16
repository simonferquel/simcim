using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPhysicalElement : CIMManagedSystemElement
    {
        protected CIMPhysicalElement()
        {
        }

        protected CIMPhysicalElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String Model
        {
            get
            {
                System.String result;
                this.GetProperty("Model", out result);
                return result;
            }
        }

        public System.String OtherIdentifyingInfo
        {
            get
            {
                System.String result;
                this.GetProperty("OtherIdentifyingInfo", out result);
                return result;
            }
        }

        public System.String PartNumber
        {
            get
            {
                System.String result;
                this.GetProperty("PartNumber", out result);
                return result;
            }
        }

        public System.Boolean? PoweredOn
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PoweredOn", out result);
                return result;
            }
        }

        public System.String SerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("SerialNumber", out result);
                return result;
            }
        }

        public System.String SKU
        {
            get
            {
                System.String result;
                this.GetProperty("SKU", out result);
                return result;
            }
        }

        public System.String Tag
        {
            get
            {
                System.String result;
                this.GetProperty("Tag", out result);
                return result;
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }
    }
}