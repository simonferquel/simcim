using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public abstract class CIMPolicy : CIMManagedElement
    {
        protected CIMPolicy()
        {
        }

        protected CIMPolicy(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CommonName
        {
            get
            {
                System.String result;
                this.GetProperty("CommonName", out result);
                return result;
            }

            set
            {
                this.SetProperty("CommonName", value);
            }
        }

        public System.String[] PolicyKeywords
        {
            get
            {
                System.String[] result;
                this.GetProperty("PolicyKeywords", out result);
                return result;
            }

            set
            {
                this.SetProperty("PolicyKeywords", value);
            }
        }
    }
}