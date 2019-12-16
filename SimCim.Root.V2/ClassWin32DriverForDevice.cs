using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DriverForDevice : CIMDependency
    {
        public Win32DriverForDevice()
        {
        }

        public Win32DriverForDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Printer Antecedent
        {
            get
            {
                Win32Printer result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32PrinterDriver Dependent
        {
            get
            {
                Win32PrinterDriver result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}