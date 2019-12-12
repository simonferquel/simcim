using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSystemBIOS : CIMSystemBIOS
    {
        public MsvmSystemBIOS()
        {
        }

        public MsvmSystemBIOS(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmBIOSElement PartComponent
        {
            get
            {
                MsvmBIOSElement result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}