using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SystemSetting : CIMElementSetting
    {
        protected Win32SystemSetting()
        {
        }

        protected Win32SystemSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32ComputerSystem Element
        {
            get
            {
                Win32ComputerSystem result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }
    }
}