using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterUsoEncapsulationTypes : GenericInfrastructureObject
    {
        public MSFTNetAdapterUsoEncapsulationTypes()
        {
        }

        public MSFTNetAdapterUsoEncapsulationTypes(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? NdisEncapsulationIeee8023
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NdisEncapsulationIeee802_3", out result);
                return result;
            }
        }

        public System.Boolean? NdisEncapsulationIeee8023pAndq
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NdisEncapsulationIeee802_3pAndq", out result);
                return result;
            }
        }

        public System.Boolean? NdisEncapsulationIeee8023PAndQInOob
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NdisEncapsulationIeee802_3PAndQInOob", out result);
                return result;
            }
        }

        public System.Boolean? NdisEncapsulationIeeLlcSnapRouted
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NdisEncapsulationIeeLlcSnapRouted", out result);
                return result;
            }
        }

        public System.Boolean? NdisEncapsulationNotNull
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NdisEncapsulationNotNull", out result);
                return result;
            }
        }

        public System.Boolean? NdisEncapsulationNotSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NdisEncapsulationNotSupported", out result);
                return result;
            }
        }
    }
}