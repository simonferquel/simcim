using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32VolumeQuota : CIMElementSetting
    {
        public Win32VolumeQuota()
        {
        }

        public Win32VolumeQuota(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Volume Element
        {
            get
            {
                Win32Volume result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32QuotaSetting Setting
        {
            get
            {
                Win32QuotaSetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}