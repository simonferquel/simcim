using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32AutochkSetting : CIMSetting
    {
        public Win32AutochkSetting()
        {
        }

        public Win32AutochkSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? UserInputDelay
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UserInputDelay", out result);
                return result;
            }

            set
            {
                this.SetProperty("UserInputDelay", value);
            }
        }
    }
}