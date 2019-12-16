using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LoadOrderGroup : CIMLogicalElement
    {
        public Win32LoadOrderGroup()
        {
        }

        public Win32LoadOrderGroup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? DriverEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DriverEnabled", out result);
                return result;
            }
        }

        public System.UInt32? GroupOrder
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GroupOrder", out result);
                return result;
            }
        }
    }
}