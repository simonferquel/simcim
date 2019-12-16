using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ODBCDriverAttribute : Win32SettingCheck
    {
        public Win32ODBCDriverAttribute()
        {
        }

        public Win32ODBCDriverAttribute(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32ODBCDriverSpecification Check
        {
            get
            {
                Win32ODBCDriverSpecification result;
                this.GetInfrastructureObjectProperty("Check", out result);
                return result;
            }
        }

        public new Win32ODBCAttribute Setting
        {
            get
            {
                Win32ODBCAttribute result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}