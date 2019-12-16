using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SubDirectory : CIMComponent
    {
        public Win32SubDirectory()
        {
        }

        public Win32SubDirectory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Directory GroupComponent
        {
            get
            {
                Win32Directory result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32Directory PartComponent
        {
            get
            {
                Win32Directory result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}