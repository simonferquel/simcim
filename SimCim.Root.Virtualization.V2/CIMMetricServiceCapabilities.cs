using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMMetricServiceCapabilities : CIMEnabledLogicalElementCapabilities
    {
        protected CIMMetricServiceCapabilities()
        {
        }

        protected CIMMetricServiceCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] ControllableManagedElements
        {
            get
            {
                System.String[] result;
                this.GetProperty("ControllableManagedElements", out result);
                return result;
            }

            set
            {
                this.SetProperty("ControllableManagedElements", value);
            }
        }

        public System.String[] ControllableMetrics
        {
            get
            {
                System.String[] result;
                this.GetProperty("ControllableMetrics", out result);
                return result;
            }

            set
            {
                this.SetProperty("ControllableMetrics", value);
            }
        }

        public System.UInt16[] ManagedElementControlTypes
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ManagedElementControlTypes", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManagedElementControlTypes", value);
            }
        }

        public System.UInt16[] MetricsControlTypes
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("MetricsControlTypes", out result);
                return result;
            }

            set
            {
                this.SetProperty("MetricsControlTypes", value);
            }
        }

        public System.UInt16[] SupportedMethods
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("SupportedMethods", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportedMethods", value);
            }
        }
    }
}