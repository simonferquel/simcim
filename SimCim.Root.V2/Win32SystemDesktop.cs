using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemDesktop : Win32SystemSetting
    {
        public Win32SystemDesktop()
        {
        }

        public Win32SystemDesktop(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Desktop Setting
        {
            get
            {
                Win32Desktop result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}