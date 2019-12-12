using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32VolumeQuotaSetting : CIMElementSetting
    {
        public Win32VolumeQuotaSetting()
        {
        }

        public Win32VolumeQuotaSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32LogicalDisk Element
        {
            get
            {
                Win32LogicalDisk result;
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