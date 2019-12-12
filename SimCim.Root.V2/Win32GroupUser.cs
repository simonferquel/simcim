using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32GroupUser : CIMComponent
    {
        public Win32GroupUser()
        {
        }

        public Win32GroupUser(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Group GroupComponent
        {
            get
            {
                Win32Group result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32Account PartComponent
        {
            get
            {
                Win32Account result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}