using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public abstract class CIMInstIndication : CIMIndication
    {
        protected CIMInstIndication()
        {
        }

        protected CIMInstIndication(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance SourceInstance
        {
            get
            {
                CimInstance result;
                this.GetProperty("SourceInstance", out result);
                return result;
            }

            set
            {
                this.SetProperty("SourceInstance", value);
            }
        }

        public System.String SourceInstanceHost
        {
            get
            {
                System.String result;
                this.GetProperty("SourceInstanceHost", out result);
                return result;
            }

            set
            {
                this.SetProperty("SourceInstanceHost", value);
            }
        }

        public System.String SourceInstanceModelPath
        {
            get
            {
                System.String result;
                this.GetProperty("SourceInstanceModelPath", out result);
                return result;
            }

            set
            {
                this.SetProperty("SourceInstanceModelPath", value);
            }
        }
    }
}