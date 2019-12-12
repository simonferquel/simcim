using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LoadOrderGroupServiceMembers : CIMComponent
    {
        public Win32LoadOrderGroupServiceMembers()
        {
        }

        public Win32LoadOrderGroupServiceMembers(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32LoadOrderGroup GroupComponent
        {
            get
            {
                Win32LoadOrderGroup result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32BaseService PartComponent
        {
            get
            {
                Win32BaseService result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}