using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Printer : CIMPrinter
    {
        public Win32Printer()
        {
        }

        public Win32Printer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Attributes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Attributes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Attributes", value);
            }
        }

        public System.UInt32? AveragePagesPerMinute
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AveragePagesPerMinute", out result);
                return result;
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

        public System.Boolean? Default
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Default", out result);
                return result;
            }
        }

        public System.UInt32? DefaultPriority
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefaultPriority", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultPriority", value);
            }
        }

        public System.Boolean? Direct
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Direct", out result);
                return result;
            }

            set
            {
                this.SetProperty("Direct", value);
            }
        }

        public System.Boolean? DoCompleteFirst
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DoCompleteFirst", out result);
                return result;
            }

            set
            {
                this.SetProperty("DoCompleteFirst", value);
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

        public System.Boolean? EnableBIDI
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableBIDI", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableBIDI", value);
            }
        }

        public System.Boolean? EnableDevQueryPrint
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableDevQueryPrint", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableDevQueryPrint", value);
            }
        }

        public System.UInt16? ExtendedDetectedErrorState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ExtendedDetectedErrorState", out result);
                return result;
            }
        }

        public System.UInt16? ExtendedPrinterStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ExtendedPrinterStatus", out result);
                return result;
            }
        }

        public System.Boolean? Hidden
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Hidden", out result);
                return result;
            }

            set
            {
                this.SetProperty("Hidden", value);
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

        public System.Boolean? Local
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Local", out result);
                return result;
            }

            set
            {
                this.SetProperty("Local", value);
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

        public System.Boolean? Network
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Network", out result);
                return result;
            }

            set
            {
                this.SetProperty("Network", value);
            }
        }

        public System.String Parameters
        {
            get
            {
                System.String result;
                this.GetProperty("Parameters", out result);
                return result;
            }

            set
            {
                this.SetProperty("Parameters", value);
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

        public System.String[] PrinterPaperNames
        {
            get
            {
                System.String[] result;
                this.GetProperty("PrinterPaperNames", out result);
                return result;
            }
        }

        public System.UInt32? PrinterState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PrinterState", out result);
                return result;
            }
        }

        public System.String PrintJobDataType
        {
            get
            {
                System.String result;
                this.GetProperty("PrintJobDataType", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrintJobDataType", value);
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

        public System.Boolean? Queued
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Queued", out result);
                return result;
            }

            set
            {
                this.SetProperty("Queued", value);
            }
        }

        public System.Boolean? RawOnly
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RawOnly", out result);
                return result;
            }

            set
            {
                this.SetProperty("RawOnly", value);
            }
        }

        public System.String SeparatorFile
        {
            get
            {
                System.String result;
                this.GetProperty("SeparatorFile", out result);
                return result;
            }

            set
            {
                this.SetProperty("SeparatorFile", value);
            }
        }

        public System.String ServerName
        {
            get
            {
                System.String result;
                this.GetProperty("ServerName", out result);
                return result;
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

        public System.Boolean? SpoolEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SpoolEnabled", out result);
                return result;
            }
        }

        public System.DateTime? StartTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("StartTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartTime", value);
            }
        }

        public System.DateTime? UntilTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("UntilTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("UntilTime", value);
            }
        }

        public System.Boolean? WorkOffline
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("WorkOffline", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkOffline", value);
            }
        }

        public System.UInt32 Pause()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Pause", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Resume()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Resume", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 CancelAllJobs()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CancelAllJobs", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 AddPrinterConnection(System.String inName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddPrinterConnection", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RenamePrinter(System.String inNewPrinterName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewPrinterName != null)
                parameters.Add(CimMethodParameter.Create("NewPrinterName", inNewPrinterName, CimType.String, inNewPrinterName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RenamePrinter", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 PrintTestPage()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "PrintTestPage", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetDefaultPrinter()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetDefaultPrinter", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, Win32SecurityDescriptor outDescriptor) GetSecurityDescriptor()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetSecurityDescriptor", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (Win32SecurityDescriptor)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Descriptor"].Value));
        }

        public System.UInt32 SetSecurityDescriptor(Win32SecurityDescriptor inDescriptor)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDescriptor != null)
                parameters.Add(CimMethodParameter.Create("Descriptor", inDescriptor.AsCimInstance(), CimType.Instance, inDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetSecurityDescriptor", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}