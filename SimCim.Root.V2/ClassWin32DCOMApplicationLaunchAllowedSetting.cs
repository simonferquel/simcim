using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DCOMApplicationLaunchAllowedSetting : GenericInfrastructureObject
    {
        public Win32DCOMApplicationLaunchAllowedSetting()
        {
        }

        public Win32DCOMApplicationLaunchAllowedSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32DCOMApplication Element
        {
            get
            {
                Win32DCOMApplication result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public Win32SID Setting
        {
            get
            {
                Win32SID result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}