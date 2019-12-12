using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSoftwareFeature : CIMLogicalElement
    {
        protected CIMSoftwareFeature()
        {
        }

        protected CIMSoftwareFeature(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String IdentifyingNumber
        {
            get
            {
                System.String result;
                this.GetProperty("IdentifyingNumber", out result);
                return result;
            }
        }

        public System.String ProductName
        {
            get
            {
                System.String result;
                this.GetProperty("ProductName", out result);
                return result;
            }
        }

        public System.String Vendor
        {
            get
            {
                System.String result;
                this.GetProperty("Vendor", out result);
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