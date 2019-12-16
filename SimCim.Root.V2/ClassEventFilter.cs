using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class EventFilter : IndicationRelated
    {
        public EventFilter()
        {
        }

        public EventFilter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte[] CreatorSID
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("CreatorSID", out result);
                return result;
            }
        }

        public System.String EventAccess
        {
            get
            {
                System.String result;
                this.GetProperty("EventAccess", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventAccess", value);
            }
        }

        public System.String EventNamespace
        {
            get
            {
                System.String result;
                this.GetProperty("EventNamespace", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventNamespace", value);
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

        public System.String Query
        {
            get
            {
                System.String result;
                this.GetProperty("Query", out result);
                return result;
            }

            set
            {
                this.SetProperty("Query", value);
            }
        }

        public System.String QueryLanguage
        {
            get
            {
                System.String result;
                this.GetProperty("QueryLanguage", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueryLanguage", value);
            }
        }
    }
}