using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemLoadOrderGroups : CIMSystemComponent
    {
        public Win32SystemLoadOrderGroups()
        {
        }

        public Win32SystemLoadOrderGroups(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32ComputerSystem GroupComponent
        {
            get
            {
                Win32ComputerSystem result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32LoadOrderGroup PartComponent
        {
            get
            {
                Win32LoadOrderGroup result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}