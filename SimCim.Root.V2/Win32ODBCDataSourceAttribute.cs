using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ODBCDataSourceAttribute : Win32SettingCheck
    {
        public Win32ODBCDataSourceAttribute()
        {
        }

        public Win32ODBCDataSourceAttribute(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32ODBCDataSourceSpecification Check
        {
            get
            {
                Win32ODBCDataSourceSpecification result;
                this.GetInfrastructureObjectProperty("Check", out result);
                return result;
            }
        }

        public new Win32ODBCSourceAttribute Setting
        {
            get
            {
                Win32ODBCSourceAttribute result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}