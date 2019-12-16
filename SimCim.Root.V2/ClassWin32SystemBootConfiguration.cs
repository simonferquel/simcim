using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemBootConfiguration : Win32SystemSetting
    {
        public Win32SystemBootConfiguration()
        {
        }

        public Win32SystemBootConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32BootConfiguration Setting
        {
            get
            {
                Win32BootConfiguration result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}