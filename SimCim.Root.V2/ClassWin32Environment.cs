using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Environment : CIMSystemResource
    {
        public Win32Environment()
        {
        }

        public Win32Environment(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? SystemVariable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SystemVariable", out result);
                return result;
            }
        }

        public System.String UserName
        {
            get
            {
                System.String result;
                this.GetProperty("UserName", out result);
                return result;
            }
        }

        public System.String VariableValue
        {
            get
            {
                System.String result;
                this.GetProperty("VariableValue", out result);
                return result;
            }

            set
            {
                this.SetProperty("VariableValue", value);
            }
        }
    }
}