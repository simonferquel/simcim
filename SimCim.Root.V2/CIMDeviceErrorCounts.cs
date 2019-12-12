using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDeviceErrorCounts : CIMStatisticalInformation
    {
        protected CIMDeviceErrorCounts()
        {
        }

        protected CIMDeviceErrorCounts(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? CriticalErrorCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CriticalErrorCount", out result);
                return result;
            }
        }

        public System.String DeviceCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceCreationClassName", out result);
                return result;
            }
        }

        public System.String DeviceID
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceID", out result);
                return result;
            }
        }

        public System.UInt64? IndeterminateErrorCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IndeterminateErrorCount", out result);
                return result;
            }
        }

        public System.UInt64? MajorErrorCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MajorErrorCount", out result);
                return result;
            }
        }

        public System.UInt64? MinorErrorCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinorErrorCount", out result);
                return result;
            }
        }

        public System.String SystemCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemCreationClassName", out result);
                return result;
            }
        }

        public System.String SystemName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemName", out result);
                return result;
            }
        }

        public System.UInt64? WarningCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WarningCount", out result);
                return result;
            }
        }

        public System.UInt32 ResetCounter(System.UInt16? inSelectedCounter)
        {
            var parameters = new CimMethodParametersCollection();
            if (inSelectedCounter.HasValue)
                parameters.Add(CimMethodParameter.Create("SelectedCounter", inSelectedCounter.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("SelectedCounter", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ResetCounter", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}