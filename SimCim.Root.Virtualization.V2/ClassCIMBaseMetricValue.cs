using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMBaseMetricValue : CIMManagedElement
    {
        protected CIMBaseMetricValue()
        {
        }

        protected CIMBaseMetricValue(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BreakdownDimension
        {
            get
            {
                System.String result;
                this.GetProperty("BreakdownDimension", out result);
                return result;
            }

            set
            {
                this.SetProperty("BreakdownDimension", value);
            }
        }

        public System.String BreakdownValue
        {
            get
            {
                System.String result;
                this.GetProperty("BreakdownValue", out result);
                return result;
            }

            set
            {
                this.SetProperty("BreakdownValue", value);
            }
        }

        public System.DateTime? Duration
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("Duration", out result);
                return result;
            }

            set
            {
                this.SetProperty("Duration", value);
            }
        }

        public System.String MeasuredElementName
        {
            get
            {
                System.String result;
                this.GetProperty("MeasuredElementName", out result);
                return result;
            }

            set
            {
                this.SetProperty("MeasuredElementName", value);
            }
        }

        public System.String MetricDefinitionId
        {
            get
            {
                System.String result;
                this.GetProperty("MetricDefinitionId", out result);
                return result;
            }

            set
            {
                this.SetProperty("MetricDefinitionId", value);
            }
        }

        public System.String MetricValue
        {
            get
            {
                System.String result;
                this.GetProperty("MetricValue", out result);
                return result;
            }

            set
            {
                this.SetProperty("MetricValue", value);
            }
        }

        public System.DateTime? TimeStamp
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeStamp", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeStamp", value);
            }
        }

        public System.Boolean? Volatile
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("volatile", out result);
                return result;
            }

            set
            {
                this.SetProperty("volatile", value);
            }
        }
    }
}