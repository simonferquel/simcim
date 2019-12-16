using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemProgramGroups : Win32SystemSetting
    {
        public Win32SystemProgramGroups()
        {
        }

        public Win32SystemProgramGroups(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32LogicalProgramGroup Setting
        {
            get
            {
                Win32LogicalProgramGroup result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}