using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmDiskDrive : CIMDiskDrive
    {
        public MsvmDiskDrive()
        {
        }

        public MsvmDiskDrive(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? DriveNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DriveNumber", out result);
                return result;
            }
        }
    }
}