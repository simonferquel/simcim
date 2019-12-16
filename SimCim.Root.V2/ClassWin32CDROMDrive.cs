using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32CDROMDrive : CIMCDROMDrive
    {
        public Win32CDROMDrive()
        {
        }

        public Win32CDROMDrive(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Drive
        {
            get
            {
                System.String result;
                this.GetProperty("Drive", out result);
                return result;
            }
        }

        public System.Boolean? DriveIntegrity
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DriveIntegrity", out result);
                return result;
            }
        }

        public System.UInt16? FileSystemFlags
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("FileSystemFlags", out result);
                return result;
            }
        }

        public System.UInt32? FileSystemFlagsEx
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileSystemFlagsEx", out result);
                return result;
            }
        }

        public System.String Id
        {
            get
            {
                System.String result;
                this.GetProperty("Id", out result);
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

        public System.UInt32? MaximumComponentLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumComponentLength", out result);
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

        public System.String MfrAssignedRevisionLevel
        {
            get
            {
                System.String result;
                this.GetProperty("MfrAssignedRevisionLevel", out result);
                return result;
            }
        }

        public System.String RevisionLevel
        {
            get
            {
                System.String result;
                this.GetProperty("RevisionLevel", out result);
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

        public System.String SerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("SerialNumber", out result);
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

        public System.Double? TransferRate
        {
            get
            {
                System.Double? result;
                this.GetProperty("TransferRate", out result);
                return result;
            }
        }

        public System.String VolumeName
        {
            get
            {
                System.String result;
                this.GetProperty("VolumeName", out result);
                return result;
            }
        }

        public System.String VolumeSerialNumber
        {
            get
            {
                System.String result;
                this.GetProperty("VolumeSerialNumber", out result);
                return result;
            }
        }
    }
}