using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderNewQueryPost : MsftWmiProviderOperationEventPost
    {
        public MsftWmiProviderNewQueryPost()
        {
        }

        public MsftWmiProviderNewQueryPost(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt32? QueryId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueryId", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueryId", value);
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

        public System.UInt32? Result
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Result", out result);
                return result;
            }

            set
            {
                this.SetProperty("Result", value);
            }
        }
    }
}