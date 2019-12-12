using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32FontInfoAction : CIMAction
    {
        public Win32FontInfoAction()
        {
        }

        public Win32FontInfoAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.String FontTitle
        {
            get
            {
                System.String result;
                this.GetProperty("FontTitle", out result);
                return result;
            }
        }
    }
}