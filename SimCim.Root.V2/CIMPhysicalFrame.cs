using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPhysicalFrame : CIMPhysicalPackage
    {
        protected CIMPhysicalFrame()
        {
        }

        protected CIMPhysicalFrame(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AudibleAlarm
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AudibleAlarm", out result);
                return result;
            }
        }

        public System.String BreachDescription
        {
            get
            {
                System.String result;
                this.GetProperty("BreachDescription", out result);
                return result;
            }
        }

        public System.String CableManagementStrategy
        {
            get
            {
                System.String result;
                this.GetProperty("CableManagementStrategy", out result);
                return result;
            }
        }

        public System.Boolean? LockPresent
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LockPresent", out result);
                return result;
            }
        }

        public System.UInt16? SecurityBreach
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SecurityBreach", out result);
                return result;
            }
        }

        public System.String[] ServiceDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("ServiceDescriptions", out result);
                return result;
            }
        }

        public System.UInt16[] ServicePhilosophy
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ServicePhilosophy", out result);
                return result;
            }
        }

        public System.Boolean? VisibleAlarm
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VisibleAlarm", out result);
                return result;
            }
        }
    }
}