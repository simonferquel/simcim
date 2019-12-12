using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PublishComponentAction : CIMAction
    {
        public Win32PublishComponentAction()
        {
        }

        public Win32PublishComponentAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AppData
        {
            get
            {
                System.String result;
                this.GetProperty("AppData", out result);
                return result;
            }
        }

        public System.String ComponentID
        {
            get
            {
                System.String result;
                this.GetProperty("ComponentID", out result);
                return result;
            }
        }

        public System.String Qual
        {
            get
            {
                System.String result;
                this.GetProperty("Qual", out result);
                return result;
            }
        }
    }
}