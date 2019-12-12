using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SerialPortSetting : Win32DeviceSettings
    {
        public Win32SerialPortSetting()
        {
        }

        public Win32SerialPortSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32SerialPort Element
        {
            get
            {
                Win32SerialPort result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32SerialPortConfiguration Setting
        {
            get
            {
                Win32SerialPortConfiguration result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}