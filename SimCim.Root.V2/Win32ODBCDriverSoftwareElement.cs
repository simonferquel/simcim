using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ODBCDriverSoftwareElement : CIMSoftwareElementChecks
    {
        public Win32ODBCDriverSoftwareElement()
        {
        }

        public Win32ODBCDriverSoftwareElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new Win32SoftwareElement Element
        {
            get
            {
                Win32SoftwareElement result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }
    }
}