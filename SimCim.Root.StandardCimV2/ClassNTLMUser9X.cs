using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class NTLMUser9X : SecurityRelatedClass
    {
        public NTLMUser9X()
        {
        }

        public NTLMUser9X(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Authority
        {
            get
            {
                System.String result;
                this.GetProperty("Authority", out result);
                return result;
            }

            set
            {
                this.SetProperty("Authority", value);
            }
        }

        public System.Int32? Flags
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Flags", out result);
                return result;
            }

            set
            {
                this.SetProperty("Flags", value);
            }
        }

        public System.Int32? Mask
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Mask", out result);
                return result;
            }

            set
            {
                this.SetProperty("Mask", value);
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

            set
            {
                this.SetProperty("Name", value);
            }
        }

        public System.Int32? Type
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Type", out result);
                return result;
            }

            set
            {
                this.SetProperty("Type", value);
            }
        }
    }
}