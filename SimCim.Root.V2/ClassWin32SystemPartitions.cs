using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemPartitions : Win32SystemDevices
    {
        public Win32SystemPartitions()
        {
        }

        public Win32SystemPartitions(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32DiskPartition PartComponent
        {
            get
            {
                Win32DiskPartition result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}