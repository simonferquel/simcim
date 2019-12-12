using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NetworkAdapterSetting : Win32DeviceSettings
    {
        public Win32NetworkAdapterSetting()
        {
        }

        public Win32NetworkAdapterSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32NetworkAdapter Element
        {
            get
            {
                Win32NetworkAdapter result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32NetworkAdapterConfiguration Setting
        {
            get
            {
                Win32NetworkAdapterConfiguration result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}