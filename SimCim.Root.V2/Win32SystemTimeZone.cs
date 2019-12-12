using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemTimeZone : Win32SystemSetting
    {
        public Win32SystemTimeZone()
        {
        }

        public Win32SystemTimeZone(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32TimeZone Setting
        {
            get
            {
                Win32TimeZone result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}