using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemSystemDriver : CIMSystemComponent
    {
        public Win32SystemSystemDriver()
        {
        }

        public Win32SystemSystemDriver(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new Win32SystemDriver PartComponent
        {
            get
            {
                Win32SystemDriver result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}