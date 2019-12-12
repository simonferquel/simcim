using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTWmiFilterEvent : MSFTWmiEssEvent
    {
        public MSFTWmiFilterEvent()
        {
        }

        public MSFTWmiFilterEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.String Namespace
        {
            get
            {
                System.String result;
                this.GetProperty("Namespace", out result);
                return result;
            }

            set
            {
                this.SetProperty("Namespace", value);
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