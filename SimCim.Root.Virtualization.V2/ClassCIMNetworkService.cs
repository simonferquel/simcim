using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMNetworkService : CIMService
    {
        protected CIMNetworkService()
        {
        }

        protected CIMNetworkService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] Keywords
        {
            get
            {
                System.String[] result;
                this.GetProperty("Keywords", out result);
                return result;
            }

            set
            {
                this.SetProperty("Keywords", value);
            }
        }

        public System.String ServiceURL
        {
            get
            {
                System.String result;
                this.GetProperty("ServiceURL", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServiceURL", value);
            }
        }

        public System.String[] StartupConditions
        {
            get
            {
                System.String[] result;
                this.GetProperty("StartupConditions", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartupConditions", value);
            }
        }

        public System.String[] StartupParameters
        {
            get
            {
                System.String[] result;
                this.GetProperty("StartupParameters", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartupParameters", value);
            }
        }
    }
}