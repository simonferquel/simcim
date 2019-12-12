using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OperatingSystemAutochkSetting : CIMElementSetting
    {
        public Win32OperatingSystemAutochkSetting()
        {
        }

        public Win32OperatingSystemAutochkSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32OperatingSystem Element
        {
            get
            {
                Win32OperatingSystem result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32AutochkSetting Setting
        {
            get
            {
                Win32AutochkSetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}