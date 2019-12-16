using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmConcreteJob : CIMConcreteJob
    {
        public MsvmConcreteJob()
        {
        }

        public MsvmConcreteJob(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Cancellable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Cancellable", out result);
                return result;
            }
        }

        public System.String ErrorSummaryDescription
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorSummaryDescription", out result);
                return result;
            }
        }

        public System.UInt16? JobType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("JobType", out result);
                return result;
            }
        }

        public (System.UInt32 retval, System.String[] outErrors) GetErrorEx()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetErrorEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String[])result.OutParameters["Errors"].Value);
        }
    }
}