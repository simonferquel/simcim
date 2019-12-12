using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVLANEndpoint : CIMProtocolEndpoint
    {
        protected CIMVLANEndpoint()
        {
        }

        protected CIMVLANEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? DesiredEndpointMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DesiredEndpointMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("DesiredEndpointMode", value);
            }
        }

        public System.UInt16? DesiredVLANTrunkEncapsulation
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DesiredVLANTrunkEncapsulation", out result);
                return result;
            }

            set
            {
                this.SetProperty("DesiredVLANTrunkEncapsulation", value);
            }
        }

        public System.UInt16? GVRPStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("GVRPStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("GVRPStatus", value);
            }
        }

        public System.UInt16? OperationalEndpointMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("OperationalEndpointMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("OperationalEndpointMode", value);
            }
        }

        public System.UInt16? OperationalVLANTrunkEncapsulation
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("OperationalVLANTrunkEncapsulation", out result);
                return result;
            }

            set
            {
                this.SetProperty("OperationalVLANTrunkEncapsulation", value);
            }
        }

        public System.String OtherEndpointMode
        {
            get
            {
                System.String result;
                this.GetProperty("OtherEndpointMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherEndpointMode", value);
            }
        }

        public System.String OtherTrunkEncapsulation
        {
            get
            {
                System.String result;
                this.GetProperty("OtherTrunkEncapsulation", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherTrunkEncapsulation", value);
            }
        }
    }
}