using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PrinterSetting : Win32DeviceSettings
    {
        public Win32PrinterSetting()
        {
        }

        public Win32PrinterSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Printer Element
        {
            get
            {
                Win32Printer result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32PrinterConfiguration Setting
        {
            get
            {
                Win32PrinterConfiguration result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}