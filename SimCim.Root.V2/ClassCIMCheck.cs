using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCheck : GenericInfrastructureObject
    {
        protected CIMCheck()
        {
        }

        protected CIMCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Caption
        {
            get
            {
                System.String result;
                this.GetProperty("Caption", out result);
                return result;
            }
        }

        public System.String CheckID
        {
            get
            {
                System.String result;
                this.GetProperty("CheckID", out result);
                return result;
            }
        }

        public System.Boolean? CheckMode
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CheckMode", out result);
                return result;
            }
        }

        public System.String Description
        {
            get
            {
                System.String result;
                this.GetProperty("Description", out result);
                return result;
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

        public System.UInt32 Invoke()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Invoke", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}