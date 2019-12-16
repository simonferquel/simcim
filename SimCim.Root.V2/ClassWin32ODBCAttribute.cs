using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ODBCAttribute : CIMSetting
    {
        public Win32ODBCAttribute()
        {
        }

        public Win32ODBCAttribute(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Attribute
        {
            get
            {
                System.String result;
                this.GetProperty("Attribute", out result);
                return result;
            }
        }

        public System.String Driver
        {
            get
            {
                System.String result;
                this.GetProperty("Driver", out result);
                return result;
            }
        }

        public System.String Value
        {
            get
            {
                System.String result;
                this.GetProperty("Value", out result);
                return result;
            }
        }
    }
}