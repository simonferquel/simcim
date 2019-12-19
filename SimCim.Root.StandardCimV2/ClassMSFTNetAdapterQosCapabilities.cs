using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterQosCapabilities : GenericInfrastructureObject
    {
        public MSFTNetAdapterQosCapabilities()
        {
        }

        public MSFTNetAdapterQosCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? CeeDcbxSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CeeDcbxSupported", out result);
                return result;
            }
        }

        public System.Boolean? IeeeDcbxSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IeeeDcbxSupported", out result);
                return result;
            }
        }

        public System.Boolean? MacSecBypassSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MacSecBypassSupported", out result);
                return result;
            }
        }

        public System.Byte? NumberOfEtsCapableTrafficClasses
        {
            get
            {
                System.Byte? result;
                this.GetProperty("NumberOfEtsCapableTrafficClasses", out result);
                return result;
            }
        }

        public System.Byte? NumberOfPfcEnabledTrafficClasses
        {
            get
            {
                System.Byte? result;
                this.GetProperty("NumberOfPfcEnabledTrafficClasses", out result);
                return result;
            }
        }

        public System.Byte? NumberOfTrafficClasses
        {
            get
            {
                System.Byte? result;
                this.GetProperty("NumberOfTrafficClasses", out result);
                return result;
            }
        }
    }
}