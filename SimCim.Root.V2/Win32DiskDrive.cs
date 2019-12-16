using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DiskDrive : CIMDiskDrive
    {
        public Win32DiskDrive()
        {
        }

        public Win32DiskDrive(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BytesPerSector
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BytesPerSector", out result);
                return result;
            }
        }

        public System.String FirmwareRevision
        {
            get
            {
                System.String result;
                this.GetProperty("FirmwareRevision", out result);
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

        public System.String InterfaceType
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceType", out result);
                return result;
            }
        }

        public System.String Manufacturer
        {
            get
            {
                System.String result;
                this.GetProperty("Manufacturer", out result);
                return result;
            }
        }

        public System.Boolean? MediaLoaded
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MediaLoaded", out result);
                return result;
            }
        }

        public System.String MediaType
        {
            get
            {
                System.String result;
                this.GetProperty("MediaType", out result);
                return result;
            }
        }

        public System.String Model
        {
            get
            {
                System.String result;
                this.GetProperty("Model", out result);
                return result;
            }
        }

        public System.UInt32? Partitions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Partitions", out result);
                return result;
            }
        }

        public System.UInt32? SCSIBus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SCSIBus", out result);
                return result;
            }
        }

        public System.UInt16? SCSILogicalUnit
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SCSILogicalUnit", out result);
                return result;
            }
        }

        public System.UInt16? SCSIPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SCSIPort", out result);
                return result;
            }
        }

        public System.UInt16? SCSITargetId
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SCSITargetId", out result);
                return result;
            }
        }

        public System.UInt32? SectorsPerTrack
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SectorsPerTrack", out result);
                return result;
            }
        }

        public System.String SerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("SerialNumber", out result);
                return result;
            }
        }

        public System.UInt32? Signature
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Signature", out result);
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

        public System.UInt64? TotalCylinders
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalCylinders", out result);
                return result;
            }
        }

        public System.UInt32? TotalHeads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalHeads", out result);
                return result;
            }
        }

        public System.UInt64? TotalSectors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalSectors", out result);
                return result;
            }
        }

        public System.UInt64? TotalTracks
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalTracks", out result);
                return result;
            }
        }

        public System.UInt32? TracksPerCylinder
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TracksPerCylinder", out result);
                return result;
            }
        }

        public Win32DiskPartition ResolveWin32DiskDriveToDiskPartitionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DiskDriveToDiskPartition", "Win32_DiskPartition", "Antecedent", "Dependent");
            return instances.Select(i => (Win32DiskPartition)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32PhysicalMedia ResolveWin32DiskDrivePhysicalMediaAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_DiskDrivePhysicalMedia", "Win32_PhysicalMedia", "Dependent", "Antecedent");
            return instances.Select(i => (Win32PhysicalMedia)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}