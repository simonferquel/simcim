using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetCallToFunctionFailed : MSFTSCMEventLogEvent
    {
        public MSFTNetCallToFunctionFailed()
        {
        }

        public MSFTNetCallToFunctionFailed(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Error
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Error", out result);
                return result;
            }

            set
            {
                this.SetProperty("Error", value);
            }
        }

        public System.String FunctionName
        {
            get
            {
                System.String result;
                this.GetProperty("FunctionName", out result);
                return result;
            }

            set
            {
                this.SetProperty("FunctionName", value);
            }
        }
    }
}