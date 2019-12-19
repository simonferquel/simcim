using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTPrinter : CIMManagedSystemElement
    {
        public MSFTPrinter()
        {
        }

        public MSFTPrinter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BranchOfficeOfflineLogSizeMB
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BranchOfficeOfflineLogSizeMB", out result);
                return result;
            }

            set
            {
                this.SetProperty("BranchOfficeOfflineLogSizeMB", value);
            }
        }

        public System.String Comment
        {
            get
            {
                System.String result;
                this.GetProperty("Comment", out result);
                return result;
            }

            set
            {
                this.SetProperty("Comment", value);
            }
        }

        public System.String ComputerName
        {
            get
            {
                System.String result;
                this.GetProperty("ComputerName", out result);
                return result;
            }
        }

        public System.String Datatype
        {
            get
            {
                System.String result;
                this.GetProperty("Datatype", out result);
                return result;
            }

            set
            {
                this.SetProperty("Datatype", value);
            }
        }

        public System.UInt32? DefaultJobPriority
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefaultJobPriority", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultJobPriority", value);
            }
        }

        public System.UInt32 DeviceType
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("DeviceType", out result);
                return result;
            }
        }

        public System.Boolean? DisableBranchOfficeLogging
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DisableBranchOfficeLogging", out result);
                return result;
            }

            set
            {
                this.SetProperty("DisableBranchOfficeLogging", value);
            }
        }

        public System.String DriverName
        {
            get
            {
                System.String result;
                this.GetProperty("DriverName", out result);
                return result;
            }

            set
            {
                this.SetProperty("DriverName", value);
            }
        }

        public System.UInt32? JobCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("JobCount", out result);
                return result;
            }
        }

        public System.Boolean? KeepPrintedJobs
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("KeepPrintedJobs", out result);
                return result;
            }

            set
            {
                this.SetProperty("KeepPrintedJobs", value);
            }
        }

        public System.String Location
        {
            get
            {
                System.String result;
                this.GetProperty("Location", out result);
                return result;
            }

            set
            {
                this.SetProperty("Location", value);
            }
        }

        public System.String PermissionSDDL
        {
            get
            {
                System.String result;
                this.GetProperty("PermissionSDDL", out result);
                return result;
            }

            set
            {
                this.SetProperty("PermissionSDDL", value);
            }
        }

        public System.String PortName
        {
            get
            {
                System.String result;
                this.GetProperty("PortName", out result);
                return result;
            }

            set
            {
                this.SetProperty("PortName", value);
            }
        }

        public System.UInt32? PrinterStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PrinterStatus", out result);
                return result;
            }
        }

        public System.String PrintProcessor
        {
            get
            {
                System.String result;
                this.GetProperty("PrintProcessor", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrintProcessor", value);
            }
        }

        public System.UInt32? Priority
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Priority", out result);
                return result;
            }

            set
            {
                this.SetProperty("Priority", value);
            }
        }

        public System.Boolean? Published
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Published", out result);
                return result;
            }

            set
            {
                this.SetProperty("Published", value);
            }
        }

        public System.UInt32? RenderingMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RenderingMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("RenderingMode", value);
            }
        }

        public System.String SeparatorPageFile
        {
            get
            {
                System.String result;
                this.GetProperty("SeparatorPageFile", out result);
                return result;
            }

            set
            {
                this.SetProperty("SeparatorPageFile", value);
            }
        }

        public System.Boolean? Shared
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Shared", out result);
                return result;
            }

            set
            {
                this.SetProperty("Shared", value);
            }
        }

        public System.String ShareName
        {
            get
            {
                System.String result;
                this.GetProperty("ShareName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ShareName", value);
            }
        }

        public System.UInt32? StartTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StartTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartTime", value);
            }
        }

        public System.UInt32 Type
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("Type", out result);
                return result;
            }
        }

        public System.UInt32? UntilTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UntilTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("UntilTime", value);
            }
        }

        public System.UInt32? WorkflowPolicy
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WorkflowPolicy", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkflowPolicy", value);
            }
        }

        public System.UInt32 AddConnection(System.String inConnectionName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inConnectionName != null)
                parameters.Add(CimMethodParameter.Create("ConnectionName", inConnectionName, CimType.String, inConnectionName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddConnection", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 AddByExistingPort(System.UInt32? inBranchOfficeOfflineLogSizeMB, System.String inComment, System.String inComputerName, System.String inDatatype, System.Boolean? inDisableBranchOfficeLogging, System.String inDriverName, System.Boolean? inKeepPrintedJobs, System.String inLocation, System.String inName, System.String inPermissionSDDL, System.String inPortName, System.String inPrintProcessor, System.UInt32? inPriority, System.Boolean? inPublished, System.UInt32? inRenderingMode, System.String inSeparatorPageFile, System.Boolean? inShared, System.String inShareName, System.UInt32? inStartTime, System.UInt32? inUntilTime, System.UInt32? inWorkflowPolicy)
        {
            var parameters = new CimMethodParametersCollection();
            if (inBranchOfficeOfflineLogSizeMB.HasValue)
                parameters.Add(CimMethodParameter.Create("BranchOfficeOfflineLogSizeMB", inBranchOfficeOfflineLogSizeMB.Value, CimFlags.None));
            if (inComment != null)
                parameters.Add(CimMethodParameter.Create("Comment", inComment, CimType.String, inComment == null ? CimFlags.NullValue : CimFlags.None));
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inDatatype != null)
                parameters.Add(CimMethodParameter.Create("Datatype", inDatatype, CimType.String, inDatatype == null ? CimFlags.NullValue : CimFlags.None));
            if (inDisableBranchOfficeLogging.HasValue)
                parameters.Add(CimMethodParameter.Create("DisableBranchOfficeLogging", inDisableBranchOfficeLogging.Value, CimFlags.None));
            if (inDriverName != null)
                parameters.Add(CimMethodParameter.Create("DriverName", inDriverName, CimType.String, inDriverName == null ? CimFlags.NullValue : CimFlags.None));
            if (inKeepPrintedJobs.HasValue)
                parameters.Add(CimMethodParameter.Create("KeepPrintedJobs", inKeepPrintedJobs.Value, CimFlags.None));
            if (inLocation != null)
                parameters.Add(CimMethodParameter.Create("Location", inLocation, CimType.String, inLocation == null ? CimFlags.NullValue : CimFlags.None));
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPermissionSDDL != null)
                parameters.Add(CimMethodParameter.Create("PermissionSDDL", inPermissionSDDL, CimType.String, inPermissionSDDL == null ? CimFlags.NullValue : CimFlags.None));
            if (inPortName != null)
                parameters.Add(CimMethodParameter.Create("PortName", inPortName, CimType.String, inPortName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPrintProcessor != null)
                parameters.Add(CimMethodParameter.Create("PrintProcessor", inPrintProcessor, CimType.String, inPrintProcessor == null ? CimFlags.NullValue : CimFlags.None));
            if (inPriority.HasValue)
                parameters.Add(CimMethodParameter.Create("Priority", inPriority.Value, CimFlags.None));
            if (inPublished.HasValue)
                parameters.Add(CimMethodParameter.Create("Published", inPublished.Value, CimFlags.None));
            if (inRenderingMode.HasValue)
                parameters.Add(CimMethodParameter.Create("RenderingMode", inRenderingMode.Value, CimFlags.None));
            if (inSeparatorPageFile != null)
                parameters.Add(CimMethodParameter.Create("SeparatorPageFile", inSeparatorPageFile, CimType.String, inSeparatorPageFile == null ? CimFlags.NullValue : CimFlags.None));
            if (inShared.HasValue)
                parameters.Add(CimMethodParameter.Create("Shared", inShared.Value, CimFlags.None));
            if (inShareName != null)
                parameters.Add(CimMethodParameter.Create("ShareName", inShareName, CimType.String, inShareName == null ? CimFlags.NullValue : CimFlags.None));
            if (inStartTime.HasValue)
                parameters.Add(CimMethodParameter.Create("StartTime", inStartTime.Value, CimFlags.None));
            if (inUntilTime.HasValue)
                parameters.Add(CimMethodParameter.Create("UntilTime", inUntilTime.Value, CimFlags.None));
            if (inWorkflowPolicy.HasValue)
                parameters.Add(CimMethodParameter.Create("WorkflowPolicy", inWorkflowPolicy.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddByExistingPort", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 AddByWsdPort(System.UInt32? inBranchOfficeOfflineLogSizeMB, System.String inComment, System.String inComputerName, System.String inDatatype, System.String inDeviceURL, System.String inDeviceUUID, System.Boolean? inDisableBranchOfficeLogging, System.Boolean? inKeepPrintedJobs, System.String inLocation, System.String inName, System.String inPermissionSDDL, System.String inPrintProcessor, System.UInt32? inPriority, System.Boolean? inPublished, System.UInt32? inRenderingMode, System.String inSeparatorPageFile, System.Boolean? inShared, System.String inShareName, System.UInt32? inStartTime, System.UInt32? inUntilTime, System.UInt32? inWorkflowPolicy)
        {
            var parameters = new CimMethodParametersCollection();
            if (inBranchOfficeOfflineLogSizeMB.HasValue)
                parameters.Add(CimMethodParameter.Create("BranchOfficeOfflineLogSizeMB", inBranchOfficeOfflineLogSizeMB.Value, CimFlags.None));
            if (inComment != null)
                parameters.Add(CimMethodParameter.Create("Comment", inComment, CimType.String, inComment == null ? CimFlags.NullValue : CimFlags.None));
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inDatatype != null)
                parameters.Add(CimMethodParameter.Create("Datatype", inDatatype, CimType.String, inDatatype == null ? CimFlags.NullValue : CimFlags.None));
            if (inDeviceURL != null)
                parameters.Add(CimMethodParameter.Create("DeviceURL", inDeviceURL, CimType.String, inDeviceURL == null ? CimFlags.NullValue : CimFlags.None));
            if (inDeviceUUID != null)
                parameters.Add(CimMethodParameter.Create("DeviceUUID", inDeviceUUID, CimType.String, inDeviceUUID == null ? CimFlags.NullValue : CimFlags.None));
            if (inDisableBranchOfficeLogging.HasValue)
                parameters.Add(CimMethodParameter.Create("DisableBranchOfficeLogging", inDisableBranchOfficeLogging.Value, CimFlags.None));
            if (inKeepPrintedJobs.HasValue)
                parameters.Add(CimMethodParameter.Create("KeepPrintedJobs", inKeepPrintedJobs.Value, CimFlags.None));
            if (inLocation != null)
                parameters.Add(CimMethodParameter.Create("Location", inLocation, CimType.String, inLocation == null ? CimFlags.NullValue : CimFlags.None));
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPermissionSDDL != null)
                parameters.Add(CimMethodParameter.Create("PermissionSDDL", inPermissionSDDL, CimType.String, inPermissionSDDL == null ? CimFlags.NullValue : CimFlags.None));
            if (inPrintProcessor != null)
                parameters.Add(CimMethodParameter.Create("PrintProcessor", inPrintProcessor, CimType.String, inPrintProcessor == null ? CimFlags.NullValue : CimFlags.None));
            if (inPriority.HasValue)
                parameters.Add(CimMethodParameter.Create("Priority", inPriority.Value, CimFlags.None));
            if (inPublished.HasValue)
                parameters.Add(CimMethodParameter.Create("Published", inPublished.Value, CimFlags.None));
            if (inRenderingMode.HasValue)
                parameters.Add(CimMethodParameter.Create("RenderingMode", inRenderingMode.Value, CimFlags.None));
            if (inSeparatorPageFile != null)
                parameters.Add(CimMethodParameter.Create("SeparatorPageFile", inSeparatorPageFile, CimType.String, inSeparatorPageFile == null ? CimFlags.NullValue : CimFlags.None));
            if (inShared.HasValue)
                parameters.Add(CimMethodParameter.Create("Shared", inShared.Value, CimFlags.None));
            if (inShareName != null)
                parameters.Add(CimMethodParameter.Create("ShareName", inShareName, CimType.String, inShareName == null ? CimFlags.NullValue : CimFlags.None));
            if (inStartTime.HasValue)
                parameters.Add(CimMethodParameter.Create("StartTime", inStartTime.Value, CimFlags.None));
            if (inUntilTime.HasValue)
                parameters.Add(CimMethodParameter.Create("UntilTime", inUntilTime.Value, CimFlags.None));
            if (inWorkflowPolicy.HasValue)
                parameters.Add(CimMethodParameter.Create("WorkflowPolicy", inWorkflowPolicy.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddByWsdPort", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RenameByName(System.String inComputerName, System.String inName, System.String inNewName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RenameByName", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RenameByObject(MSFTPrinter inInputObject, System.String inNewName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInputObject != null)
                parameters.Add(CimMethodParameter.Create("InputObject", inInputObject.AsCimInstance(), CimType.Instance, inInputObject == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RenameByObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}