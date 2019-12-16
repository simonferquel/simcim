using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Process : CIMProcess
    {
        public Win32Process()
        {
        }

        public Win32Process(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CommandLine
        {
            get
            {
                System.String result;
                this.GetProperty("CommandLine", out result);
                return result;
            }
        }

        public System.String ExecutablePath
        {
            get
            {
                System.String result;
                this.GetProperty("ExecutablePath", out result);
                return result;
            }
        }

        public System.UInt32? HandleCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HandleCount", out result);
                return result;
            }
        }

        public System.UInt32? MaximumWorkingSetSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumWorkingSetSize", out result);
                return result;
            }
        }

        public System.UInt32? MinimumWorkingSetSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinimumWorkingSetSize", out result);
                return result;
            }
        }

        public System.UInt64? OtherOperationCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherOperationCount", out result);
                return result;
            }
        }

        public System.UInt64? OtherTransferCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherTransferCount", out result);
                return result;
            }
        }

        public System.UInt32? PageFaults
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PageFaults", out result);
                return result;
            }
        }

        public System.UInt32? PageFileUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PageFileUsage", out result);
                return result;
            }
        }

        public System.UInt32? ParentProcessId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ParentProcessId", out result);
                return result;
            }
        }

        public System.UInt32? PeakPageFileUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PeakPageFileUsage", out result);
                return result;
            }
        }

        public System.UInt64? PeakVirtualSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PeakVirtualSize", out result);
                return result;
            }
        }

        public System.UInt32? PeakWorkingSetSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PeakWorkingSetSize", out result);
                return result;
            }
        }

        public System.UInt64? PrivatePageCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PrivatePageCount", out result);
                return result;
            }
        }

        public System.UInt32? ProcessId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessId", out result);
                return result;
            }
        }

        public System.UInt32? QuotaNonPagedPoolUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QuotaNonPagedPoolUsage", out result);
                return result;
            }
        }

        public System.UInt32? QuotaPagedPoolUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QuotaPagedPoolUsage", out result);
                return result;
            }
        }

        public System.UInt32? QuotaPeakNonPagedPoolUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QuotaPeakNonPagedPoolUsage", out result);
                return result;
            }
        }

        public System.UInt32? QuotaPeakPagedPoolUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QuotaPeakPagedPoolUsage", out result);
                return result;
            }
        }

        public System.UInt64? ReadOperationCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadOperationCount", out result);
                return result;
            }
        }

        public System.UInt64? ReadTransferCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadTransferCount", out result);
                return result;
            }
        }

        public System.UInt32? SessionId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SessionId", out result);
                return result;
            }
        }

        public System.UInt32? ThreadCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadCount", out result);
                return result;
            }
        }

        public System.UInt64? VirtualSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualSize", out result);
                return result;
            }
        }

        public System.String WindowsVersion
        {
            get
            {
                System.String result;
                this.GetProperty("WindowsVersion", out result);
                return result;
            }
        }

        public System.UInt64? WriteOperationCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteOperationCount", out result);
                return result;
            }
        }

        public System.UInt64? WriteTransferCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteTransferCount", out result);
                return result;
            }
        }

        public (System.UInt32 retval, System.UInt32? outProcessId) Create(System.String inCommandLine, System.String inCurrentDirectory, Win32ProcessStartup inProcessStartupInformation)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("CommandLine", inCommandLine, CimType.String, inCommandLine == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("CurrentDirectory", inCurrentDirectory, CimType.String, inCurrentDirectory == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ProcessStartupInformation", inProcessStartupInformation.AsCimInstance(), CimType.Instance, inProcessStartupInformation == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt32? )result.OutParameters["ProcessId"].Value);
        }

        public System.UInt32 Terminate(System.UInt32? inReason)
        {
            var parameters = new CimMethodParametersCollection();
            if (inReason.HasValue)
                parameters.Add(CimMethodParameter.Create("Reason", inReason.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Reason", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Terminate", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.String outDomain, System.String outUser) GetOwner()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetOwner", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["Domain"].Value, (System.String)result.OutParameters["User"].Value);
        }

        public (System.UInt32 retval, System.String outSid) GetOwnerSid()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetOwnerSid", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["Sid"].Value);
        }

        public System.UInt32 SetPriority(System.Int32? inPriority)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPriority.HasValue)
                parameters.Add(CimMethodParameter.Create("Priority", inPriority.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Priority", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetPriority", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 AttachDebugger()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AttachDebugger", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.UInt64? outAvailableVirtualSize) GetAvailableVirtualSize()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetAvailableVirtualSize", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt64? )result.OutParameters["AvailableVirtualSize"].Value);
        }

        public Win32LogonSession ResolveWin32SessionProcessAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SessionProcess", "Win32_LogonSession", "Dependent", "Antecedent");
            return instances.Select(i => (Win32LogonSession)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32ComputerSystem> ResolveWin32SystemProcessesGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemProcesses", "Win32_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32NamedJobObject> ResolveWin32NamedJobObjectProcessCollection()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_NamedJobObjectProcess", "Win32_NamedJobObject", "Member", "Collection");
            return instances.Select(i => (Win32NamedJobObject)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}