using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMBIOSFeature : CIMSoftwareFeature
    {
        protected CIMBIOSFeature()
        {
        }

        protected CIMBIOSFeature(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] CharacteristicDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("CharacteristicDescriptions", out result);
                return result;
            }
        }

        public System.UInt16[] Characteristics
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("Characteristics", out result);
                return result;
            }
        }
    }
}