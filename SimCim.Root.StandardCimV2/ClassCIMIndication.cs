using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class CIMIndication : GenericInfrastructureObject
    {
        protected CIMIndication()
        {
        }

        protected CIMIndication(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] CorrelatedIndications
        {
            get
            {
                System.String[] result;
                this.GetProperty("CorrelatedIndications", out result);
                return result;
            }

            set
            {
                this.SetProperty("CorrelatedIndications", value);
            }
        }

        public System.String IndicationFilterName
        {
            get
            {
                System.String result;
                this.GetProperty("IndicationFilterName", out result);
                return result;
            }

            set
            {
                this.SetProperty("IndicationFilterName", value);
            }
        }

        public System.String IndicationIdentifier
        {
            get
            {
                System.String result;
                this.GetProperty("IndicationIdentifier", out result);
                return result;
            }

            set
            {
                this.SetProperty("IndicationIdentifier", value);
            }
        }

        public System.DateTime? IndicationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("IndicationTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("IndicationTime", value);
            }
        }

        public System.String OtherSeverity
        {
            get
            {
                System.String result;
                this.GetProperty("OtherSeverity", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherSeverity", value);
            }
        }

        public System.UInt16? PerceivedSeverity
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PerceivedSeverity", out result);
                return result;
            }

            set
            {
                this.SetProperty("PerceivedSeverity", value);
            }
        }

        public System.String SequenceContext
        {
            get
            {
                System.String result;
                this.GetProperty("SequenceContext", out result);
                return result;
            }

            set
            {
                this.SetProperty("SequenceContext", value);
            }
        }

        public System.Int64? SequenceNumber
        {
            get
            {
                System.Int64? result;
                this.GetProperty("SequenceNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("SequenceNumber", value);
            }
        }
    }
}