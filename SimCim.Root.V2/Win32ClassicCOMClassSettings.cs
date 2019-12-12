using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ClassicCOMClassSettings : CIMElementSetting
    {
        public Win32ClassicCOMClassSettings()
        {
        }

        public Win32ClassicCOMClassSettings(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32ClassicCOMClass Element
        {
            get
            {
                Win32ClassicCOMClass result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32ClassicCOMClassSetting Setting
        {
            get
            {
                Win32ClassicCOMClassSetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}