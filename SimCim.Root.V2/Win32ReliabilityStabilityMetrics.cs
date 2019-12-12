using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ReliabilityStabilityMetrics : Win32Reliability
    {
        public Win32ReliabilityStabilityMetrics()
        {
        }

        public Win32ReliabilityStabilityMetrics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? EndMeasurementDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("EndMeasurementDate", out result);
                return result;
            }
        }

        public System.String RelID
        {
            get
            {
                System.String result;
                this.GetProperty("RelID", out result);
                return result;
            }
        }

        public System.DateTime? StartMeasurementDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("StartMeasurementDate", out result);
                return result;
            }
        }

        public System.Double? SystemStabilityIndex
        {
            get
            {
                System.Double? result;
                this.GetProperty("SystemStabilityIndex", out result);
                return result;
            }
        }

        public System.DateTime? TimeGenerated
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeGenerated", out result);
                return result;
            }
        }

        public (System.UInt32 retval, System.UInt32? outRecordCount) GetRecordCount()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetRecordCount", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt32? )result.OutParameters["RecordCount"].Value);
        }
    }
}