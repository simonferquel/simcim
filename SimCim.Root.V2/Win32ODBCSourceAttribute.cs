using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ODBCSourceAttribute : CIMSetting
    {
        public Win32ODBCSourceAttribute()
        {
        }

        public Win32ODBCSourceAttribute(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String DataSource
        {
            get
            {
                System.String result;
                this.GetProperty("DataSource", out result);
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

        public Win32ODBCDataSourceSpecification ResolveWin32ODBCDataSourceAttributeCheck()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ODBCDataSourceAttribute", "Win32_ODBCDataSourceSpecification", "Setting", "Check");
            return instances.Select(i => (Win32ODBCDataSourceSpecification)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}