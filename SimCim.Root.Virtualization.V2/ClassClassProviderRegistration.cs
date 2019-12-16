using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class ClassProviderRegistration : ObjectProviderRegistration
    {
        public ClassProviderRegistration()
        {
        }

        public ClassProviderRegistration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CimInstance Provider
        {
            get
            {
                CimInstance result;
                this.GetProperty("provider", out result);
                return result;
            }

            set
            {
                this.SetProperty("provider", value);
            }
        }

        public System.DateTime? CacheRefreshInterval
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("CacheRefreshInterval", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheRefreshInterval", value);
            }
        }

        public System.Boolean? PerUserSchema
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PerUserSchema", out result);
                return result;
            }

            set
            {
                this.SetProperty("PerUserSchema", value);
            }
        }

        public System.String[] ReferencedSetQueries
        {
            get
            {
                System.String[] result;
                this.GetProperty("ReferencedSetQueries", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReferencedSetQueries", value);
            }
        }

        public System.String[] ResultSetQueries
        {
            get
            {
                System.String[] result;
                this.GetProperty("ResultSetQueries", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResultSetQueries", value);
            }
        }

        public System.Boolean? ReSynchroniseOnNamespaceOpen
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ReSynchroniseOnNamespaceOpen", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReSynchroniseOnNamespaceOpen", value);
            }
        }

        public System.String[] UnsupportedQueries
        {
            get
            {
                System.String[] result;
                this.GetProperty("UnsupportedQueries", out result);
                return result;
            }

            set
            {
                this.SetProperty("UnsupportedQueries", value);
            }
        }

        public System.UInt32? Version
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Version", out result);
                return result;
            }

            set
            {
                this.SetProperty("Version", value);
            }
        }
    }
}