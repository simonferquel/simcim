using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32GroupInDomain : CIMComponent
    {
        public Win32GroupInDomain()
        {
        }

        public Win32GroupInDomain(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new Win32Group PartComponent
        {
            get
            {
                Win32Group result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}