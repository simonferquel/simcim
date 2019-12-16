using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterRdmaMissingCounterInfo : GenericInfrastructureObject
    {
        public MSFTNetAdapterRdmaMissingCounterInfo()
        {
        }

        public MSFTNetAdapterRdmaMissingCounterInfo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AcceptPerformanceCounterMissing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AcceptPerformanceCounterMissing", out result);
                return result;
            }
        }

        public System.Boolean? ActiveConnectionPerformanceCounterMissing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ActiveConnectionPerformanceCounterMissing", out result);
                return result;
            }
        }

        public System.Boolean? CompletionQueueErrorPerformanceCounterMissing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CompletionQueueErrorPerformanceCounterMissing", out result);
                return result;
            }
        }

        public System.Boolean? ConnectFailurePerformanceCounterMissing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ConnectFailurePerformanceCounterMissing", out result);
                return result;
            }
        }

        public System.Boolean? ConnectionErrorPerformanceCounterMissing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ConnectionErrorPerformanceCounterMissing", out result);
                return result;
            }
        }

        public System.Boolean? ConnectPerformanceCounterMissing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ConnectPerformanceCounterMissing", out result);
                return result;
            }
        }

        public System.Boolean? RDMAInFramesPerformanceCounterMissing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RDMAInFramesPerformanceCounterMissing", out result);
                return result;
            }
        }

        public System.Boolean? RDMAInOctetsPerformanceCounterMissing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RDMAInOctetsPerformanceCounterMissing", out result);
                return result;
            }
        }

        public System.Boolean? RDMAOutFramesPerformanceCounterMissing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RDMAOutFramesPerformanceCounterMissing", out result);
                return result;
            }
        }

        public System.Boolean? RDMAOutOctetsPerformanceCounterMissing
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RDMAOutOctetsPerformanceCounterMissing", out result);
                return result;
            }
        }
    }
}