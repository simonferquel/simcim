using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class CIMIPsecSAEndpoint : CIMSecurityAssociationEndpoint
    {
        public CIMIPsecSAEndpoint()
        {
        }

        public CIMIPsecSAEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? DFHandling
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DFHandling", out result);
                return result;
            }

            set
            {
                this.SetProperty("DFHandling", value);
            }
        }

        public System.UInt16? EncapsulationMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EncapsulationMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("EncapsulationMode", value);
            }
        }

        public System.Boolean? InboundDirection
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("InboundDirection", out result);
                return result;
            }

            set
            {
                this.SetProperty("InboundDirection", value);
            }
        }

        public System.Boolean? PFSInUse
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PFSInUse", out result);
                return result;
            }

            set
            {
                this.SetProperty("PFSInUse", value);
            }
        }

        public System.UInt32? SPI
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SPI", out result);
                return result;
            }

            set
            {
                this.SetProperty("SPI", value);
            }
        }
    }
}