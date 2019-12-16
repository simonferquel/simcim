using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32VideoSettings : CIMVideoSetting
    {
        public Win32VideoSettings()
        {
        }

        public Win32VideoSettings(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32VideoController Element
        {
            get
            {
                Win32VideoController result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }
    }
}