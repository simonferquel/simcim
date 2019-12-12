using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalDiskToPartition : CIMLogicalDiskBasedOnPartition
    {
        public Win32LogicalDiskToPartition()
        {
        }

        public Win32LogicalDiskToPartition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32DiskPartition Antecedent
        {
            get
            {
                Win32DiskPartition result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32LogicalDisk Dependent
        {
            get
            {
                Win32LogicalDisk result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}