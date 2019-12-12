using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32UserDesktop : CIMElementSetting
    {
        public Win32UserDesktop()
        {
        }

        public Win32UserDesktop(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32UserAccount Element
        {
            get
            {
                Win32UserAccount result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
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