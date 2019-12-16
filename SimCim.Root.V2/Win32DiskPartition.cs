using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DiskPartition : CIMDiskPartition
    {
        public Win32DiskPartition()
        {
        }

        public Win32DiskPartition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? BootPartition
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BootPartition", out result);
                return result;
            }
        }

        public System.UInt32? DiskIndex
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DiskIndex", out result);
                return result;
            }
        }

        public System.UInt32? HiddenSectors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HiddenSectors", out result);
                return result;
            }
        }

        public System.UInt32? Index
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Index", out result);
                return result;
            }
        }

        public System.Boolean? RewritePartition
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RewritePartition", out result);
                return result;
            }
        }

        public System.UInt64? Size
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Size", out result);
                return result;
            }
        }

        public System.UInt64? StartingOffset
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("StartingOffset", out result);
                return result;
            }
        }

        public System.String Type
        {
            get
            {
                System.String result;
                this.GetProperty("Type", out result);
                return result;
            }
        }

        public Win32LogicalDisk ResolveWin32LogicalDiskToPartitionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalDiskToPartition", "Win32_LogicalDisk", "Antecedent", "Dependent");
            return instances.Select(i => (Win32LogicalDisk)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32DiskDrive ResolveWin32DiskDriveToDiskPartitionAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DiskDriveToDiskPartition", "Win32_DiskDrive", "Dependent", "Antecedent");
            return instances.Select(i => (Win32DiskDrive)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32ComputerSystem> ResolveWin32SystemPartitionsGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemPartitions", "Win32_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}