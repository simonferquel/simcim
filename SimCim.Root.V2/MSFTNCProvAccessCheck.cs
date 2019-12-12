using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNCProvAccessCheck : MSFTNCProvEvent
    {
        public MSFTNCProvAccessCheck()
        {
        }

        public MSFTNCProvAccessCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.Byte[] Sid
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("Sid", out result);
                return result;
            }

            set
            {
                this.SetProperty("Sid", value);
            }
        }
    }
}