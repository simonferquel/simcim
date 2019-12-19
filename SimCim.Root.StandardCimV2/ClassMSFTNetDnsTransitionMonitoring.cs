using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetDnsTransitionMonitoring : MSFTNetSettingData
    {
        public MSFTNetDnsTransitionMonitoring()
        {
        }

        public MSFTNetDnsTransitionMonitoring(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? NumAAAAQueriesFailed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumAAAAQueriesFailed", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumAAAAQueriesFailed", value);
            }
        }

        public System.UInt32? NumAAAAQueriesIn6ArpaPtr
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumAAAAQueriesIn6ArpaPtr", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumAAAAQueriesIn6ArpaPtr", value);
            }
        }

        public System.UInt32? NumAAAAQueriesSucceeded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumAAAAQueriesSucceeded", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumAAAAQueriesSucceeded", value);
            }
        }

        public System.UInt32? NumAAAAQueriesSynthesized
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumAAAAQueriesSynthesized", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumAAAAQueriesSynthesized", value);
            }
        }

        public System.UInt32? NumOtherQueriesFailed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumOtherQueriesFailed", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumOtherQueriesFailed", value);
            }
        }

        public System.UInt32? NumOtherQueriesSucceeded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumOtherQueriesSucceeded", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumOtherQueriesSucceeded", value);
            }
        }
    }
}