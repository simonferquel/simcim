using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MethodInvocationEvent : InstanceOperationEvent
    {
        public MethodInvocationEvent()
        {
        }

        public MethodInvocationEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Method
        {
            get
            {
                System.String result;
                this.GetProperty("Method", out result);
                return result;
            }

            set
            {
                this.SetProperty("Method", value);
            }
        }

        public CimInstance Parameters
        {
            get
            {
                CimInstance result;
                this.GetProperty("Parameters", out result);
                return result;
            }

            set
            {
                this.SetProperty("Parameters", value);
            }
        }

        public System.Boolean? PreCall
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PreCall", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreCall", value);
            }
        }
    }
}