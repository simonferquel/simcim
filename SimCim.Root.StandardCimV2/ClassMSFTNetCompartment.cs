using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetCompartment : MSFTNetSettingData
    {
        public MSFTNetCompartment()
        {
        }

        public MSFTNetCompartment(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CompartmentDescription
        {
            get
            {
                System.String result;
                this.GetProperty("CompartmentDescription", out result);
                return result;
            }
        }

        public System.String CompartmentGuid
        {
            get
            {
                System.String result;
                this.GetProperty("CompartmentGuid", out result);
                return result;
            }
        }

        public System.UInt32? CompartmentId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompartmentId", out result);
                return result;
            }
        }

        public System.UInt32? CompartmentType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CompartmentType", out result);
                return result;
            }
        }
    }
}