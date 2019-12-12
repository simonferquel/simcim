using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DiskDriveToDiskPartition : CIMMediaPresent
    {
        public Win32DiskDriveToDiskPartition()
        {
        }

        public Win32DiskDriveToDiskPartition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32DiskDrive Antecedent
        {
            get
            {
                Win32DiskDrive result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32DiskPartition Dependent
        {
            get
            {
                Win32DiskPartition result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}