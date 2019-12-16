using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMActiveConnection : CIMSAPSAPDependency
    {
        protected CIMActiveConnection()
        {
        }

        protected CIMActiveConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? IsUnidirectional
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsUnidirectional", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsUnidirectional", value);
            }
        }

        public System.String OtherTrafficDescription
        {
            get
            {
                System.String result;
                this.GetProperty("OtherTrafficDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherTrafficDescription", value);
            }
        }

        public System.UInt16? TrafficType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TrafficType", out result);
                return result;
            }

            set
            {
                this.SetProperty("TrafficType", value);
            }
        }
    }
}