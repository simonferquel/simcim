using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNCProvNewQuery : MSFTNCProvEvent
    {
        public MSFTNCProvNewQuery()
        {
        }

        public MSFTNCProvNewQuery(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ID", out result);
                return result;
            }

            set
            {
                this.SetProperty("ID", value);
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