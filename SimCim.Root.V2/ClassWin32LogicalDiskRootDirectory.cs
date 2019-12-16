using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalDiskRootDirectory : CIMComponent
    {
        public Win32LogicalDiskRootDirectory()
        {
        }

        public Win32LogicalDiskRootDirectory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32LogicalDisk GroupComponent
        {
            get
            {
                Win32LogicalDisk result;
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