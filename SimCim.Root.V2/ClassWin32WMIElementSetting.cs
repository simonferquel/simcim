using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32WMIElementSetting : CIMElementSetting
    {
        public Win32WMIElementSetting()
        {
        }

        public Win32WMIElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Service Element
        {
            get
            {
                Win32Service result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32WMISetting Setting
        {
            get
            {
                Win32WMISetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}