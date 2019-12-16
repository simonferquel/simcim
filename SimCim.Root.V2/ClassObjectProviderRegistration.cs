using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class ObjectProviderRegistration : ProviderRegistration
    {
        protected ObjectProviderRegistration()
        {
        }

        protected ObjectProviderRegistration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Int32? InteractionType
        {
            get
            {
                System.Int32? result;
                this.GetProperty("InteractionType", out result);
                return result;
            }

            set
            {
                this.SetProperty("InteractionType", value);
            }
        }

        public System.String[] QuerySupportLevels
        {
            get
            {
                System.String[] result;
                this.GetProperty("QuerySupportLevels", out result);
                return result;
            }

            set
            {
                this.SetProperty("QuerySupportLevels", value);
            }
        }

        public System.Boolean? SupportsBatching
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsBatching", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsBatching", value);
            }
        }

        public System.Boolean? SupportsDelete
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsDelete", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsDelete", value);
            }
        }

        public System.Boolean? SupportsEnumeration
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsEnumeration", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsEnumeration", value);
            }
        }

        public System.Boolean? SupportsGet
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsGet", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsGet", value);
            }
        }

        public System.Boolean? SupportsPut
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsPut", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsPut", value);
            }
        }

        public System.Boolean? SupportsTransactions
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsTransactions", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportsTransactions", value);
            }
        }
    }
}