using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NTEventlogFile : CIMDataFile
    {
        public Win32NTEventlogFile()
        {
        }

        public Win32NTEventlogFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String LogfileName
        {
            get
            {
                System.String result;
                this.GetProperty("LogfileName", out result);
                return result;
            }
        }

        public System.UInt32? MaxFileSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxFileSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxFileSize", value);
            }
        }

        public System.UInt32? NumberOfRecords
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfRecords", out result);
                return result;
            }
        }

        public System.UInt32? OverwriteOutDated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OverwriteOutDated", out result);
                return result;
            }

            set
            {
                this.SetProperty("OverwriteOutDated", value);
            }
        }

        public System.String OverWritePolicy
        {
            get
            {
                System.String result;
                this.GetProperty("OverWritePolicy", out result);
                return result;
            }
        }

        public System.String[] Sources
        {
            get
            {
                System.String[] result;
                this.GetProperty("Sources", out result);
                return result;
            }
        }

        public System.UInt32 ClearEventlog(System.String inArchiveFileName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inArchiveFileName != null)
                parameters.Add(CimMethodParameter.Create("ArchiveFileName", inArchiveFileName, CimType.String, inArchiveFileName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ClearEventlog", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 BackupEventlog(System.String inArchiveFileName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inArchiveFileName != null)
                parameters.Add(CimMethodParameter.Create("ArchiveFileName", inArchiveFileName, CimType.String, inArchiveFileName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "BackupEventlog", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public Win32NTLogEvent ResolveWin32NTLogEventLogRecord()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_NTLogEventLog", "Win32_NTLogEvent", "Log", "Record");
            return instances.Select(i => (Win32NTLogEvent)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}