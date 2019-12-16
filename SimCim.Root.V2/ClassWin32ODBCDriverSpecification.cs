using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ODBCDriverSpecification : CIMCheck
    {
        public Win32ODBCDriverSpecification()
        {
        }

        public Win32ODBCDriverSpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.String File
        {
            get
            {
                System.String result;
                this.GetProperty("File", out result);
                return result;
            }
        }

        public System.String SetupFile
        {
            get
            {
                System.String result;
                this.GetProperty("SetupFile", out result);
                return result;
            }
        }
    }
}