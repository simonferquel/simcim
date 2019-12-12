using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32MappedLogicalDisk : CIMLogicalDisk
    {
        public Win32MappedLogicalDisk()
        {
        }

        public Win32MappedLogicalDisk(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Compressed
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Compressed", out result);
                return result;
            }
        }

        public System.String FileSystem
        {
            get
            {
                System.String result;
                this.GetProperty("FileSystem", out result);
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

        public System.String ProviderName
        {
            get
            {
                System.String result;
                this.GetProperty("ProviderName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderName", value);
            }
        }

        public System.Boolean? QuotasDisabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("QuotasDisabled", out result);
                return result;
            }
        }

        public System.Boolean? QuotasIncomplete
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("QuotasIncomplete", out result);
                return result;
            }
        }

        public System.Boolean? QuotasRebuilding
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("QuotasRebuilding", out result);
                return result;
            }
        }

        public System.String SessionID
        {
            get
            {
                System.String result;
                this.GetProperty("SessionID", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionID", value);
            }
        }

        public System.Boolean? SupportsDiskQuotas
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsDiskQuotas", out result);
                return result;
            }
        }

        public System.Boolean? SupportsFileBasedCompression
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsFileBasedCompression", out result);
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

            set
            {
                this.SetProperty("VolumeName", value);
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

        public Win32LogonSession ResolveWin32LogonSessionMappedDiskAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogonSessionMappedDisk", "Win32_LogonSession", "Dependent", "Antecedent");
            return instances.Select(i => (Win32LogonSession)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}