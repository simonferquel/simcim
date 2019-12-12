using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderExecQueryAsyncEventPost : MsftWmiProviderOperationEventPost
    {
        public MsftWmiProviderExecQueryAsyncEventPost()
        {
        }

        public MsftWmiProviderExecQueryAsyncEventPost(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Flags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Flags", out result);
                return result;
            }

            set
            {
                this.SetProperty("Flags", value);
            }
        }

        public CimInstance ObjectParameter
        {
            get
            {
                CimInstance result;
                this.GetProperty("ObjectParameter", out result);
                return result;
            }

            set
            {
                this.SetProperty("ObjectParameter", value);
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

        public System.UInt32? ResultCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ResultCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResultCode", value);
            }
        }

        public System.String StringParameter
        {
            get
            {
                System.String result;
                this.GetProperty("StringParameter", out result);
                return result;
            }

            set
            {
                this.SetProperty("StringParameter", value);
            }
        }
    }
}