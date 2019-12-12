using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SelfRegModuleAction : CIMAction
    {
        public Win32SelfRegModuleAction()
        {
        }

        public Win32SelfRegModuleAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Cost
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Cost", out result);
                return result;
            }
        }

        public System.String File
        {
            get
            {
                System.String result;
                this.GetProperty("File", out result);
                return result;
            }
        }
    }
}