using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSoftwareElement : CIMLogicalElement
    {
        protected CIMSoftwareElement()
        {
        }

        protected CIMSoftwareElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BuildNumber
        {
            get
            {
                System.String result;
                this.GetProperty("BuildNumber", out result);
                return result;
            }
        }

        public System.String CodeSet
        {
            get
            {
                System.String result;
                this.GetProperty("CodeSet", out result);
                return result;
            }
        }

        public System.String IdentificationCode
        {
            get
            {
                System.String result;
                this.GetProperty("IdentificationCode", out result);
                return result;
            }
        }

        public System.String LanguageEdition
        {
            get
            {
                System.String result;
                this.GetProperty("LanguageEdition", out result);
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

        public System.String OtherTargetOS
        {
            get
            {
                System.String result;
                this.GetProperty("OtherTargetOS", out result);
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

        public System.String SoftwareElementID
        {
            get
            {
                System.String result;
                this.GetProperty("SoftwareElementID", out result);
                return result;
            }
        }

        public System.UInt16? SoftwareElementState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SoftwareElementState", out result);
                return result;
            }
        }

        public System.UInt16? TargetOperatingSystem
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TargetOperatingSystem", out result);
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