using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ODBCDataSourceSpecification : CIMCheck
    {
        public Win32ODBCDataSourceSpecification()
        {
        }

        public Win32ODBCDataSourceSpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.String DriverDescription
        {
            get
            {
                System.String result;
                this.GetProperty("DriverDescription", out result);
                return result;
            }
        }

        public System.String Registration
        {
            get
            {
                System.String result;
                this.GetProperty("Registration", out result);
                return result;
            }
        }
    }
}