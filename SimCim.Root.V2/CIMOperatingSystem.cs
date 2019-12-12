using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMOperatingSystem : CIMLogicalElement
    {
        protected CIMOperatingSystem()
        {
        }

        protected CIMOperatingSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }
        }

        public System.String CSCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CSCreationClassName", out result);
                return result;
            }
        }

        public System.String CSName
        {
            get
            {
                System.String result;
                this.GetProperty("CSName", out result);
                return result;
            }
        }

        public System.Int16? CurrentTimeZone
        {
            get
            {
                System.Int16? result;
                this.GetProperty("CurrentTimeZone", out result);
                return result;
            }
        }

        public System.Boolean? Distributed
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Distributed", out result);
                return result;
            }
        }

        public System.UInt64? FreePhysicalMemory
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FreePhysicalMemory", out result);
                return result;
            }
        }

        public System.UInt64? FreeSpaceInPagingFiles
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FreeSpaceInPagingFiles", out result);
                return result;
            }
        }

        public System.UInt64? FreeVirtualMemory
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FreeVirtualMemory", out result);
                return result;
            }
        }

        public System.DateTime? LastBootUpTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastBootUpTime", out result);
                return result;
            }
        }

        public System.DateTime? LocalDateTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LocalDateTime", out result);
                return result;
            }
        }

        public System.UInt32? MaxNumberOfProcesses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumberOfProcesses", out result);
                return result;
            }
        }

        public System.UInt64? MaxProcessMemorySize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxProcessMemorySize", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfLicensedUsers
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfLicensedUsers", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfProcesses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfProcesses", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfUsers
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfUsers", out result);
                return result;
            }
        }

        public System.UInt16? OSType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("OSType", out result);
                return result;
            }
        }

        public System.String OtherTypeDescription
        {
            get
            {
                System.String result;
                this.GetProperty("OtherTypeDescription", out result);
                return result;
            }
        }

        public System.UInt64? SizeStoredInPagingFiles
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SizeStoredInPagingFiles", out result);
                return result;
            }
        }

        public System.UInt64? TotalSwapSpaceSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalSwapSpaceSize", out result);
                return result;
            }
        }

        public System.UInt64? TotalVirtualMemorySize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalVirtualMemorySize", out result);
                return result;
            }
        }

        public System.UInt64? TotalVisibleMemorySize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalVisibleMemorySize", out result);
                return result;
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }

        public System.UInt32 Reboot()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reboot", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Shutdown()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Shutdown", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}