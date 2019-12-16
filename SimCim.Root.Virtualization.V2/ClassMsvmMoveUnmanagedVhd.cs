using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmMoveUnmanagedVhd : CIMManagedElement
    {
        public MsvmMoveUnmanagedVhd()
        {
        }

        public MsvmMoveUnmanagedVhd(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String VhdDestinationPath
        {
            get
            {
                System.String result;
                this.GetProperty("VhdDestinationPath", out result);
                return result;
            }
        }

        public System.String VhdSourcePath
        {
            get
            {
                System.String result;
                this.GetProperty("VhdSourcePath", out result);
                return result;
            }
        }
    }
}