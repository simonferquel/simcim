using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32UserInDomain : CIMComponent
    {
        public Win32UserInDomain()
        {
        }

        public Win32UserInDomain(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32NTDomain GroupComponent
        {
            get
            {
                Win32NTDomain result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32UserAccount PartComponent
        {
            get
            {
                Win32UserAccount result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}