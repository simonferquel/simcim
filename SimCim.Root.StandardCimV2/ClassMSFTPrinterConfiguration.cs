using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTPrinterConfiguration : GenericInfrastructureObject
    {
        public MSFTPrinterConfiguration()
        {
        }

        public MSFTPrinterConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Collate
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Collate", out result);
                return result;
            }

            set
            {
                this.SetProperty("Collate", value);
            }
        }

        public System.Boolean? Color
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Color", out result);
                return result;
            }

            set
            {
                this.SetProperty("Color", value);
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

        public System.UInt32? DuplexingMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DuplexingMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("DuplexingMode", value);
            }
        }

        public System.UInt32? PaperSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PaperSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("PaperSize", value);
            }
        }

        public System.String PrintCapabilitiesXML
        {
            get
            {
                System.String result;
                this.GetProperty("PrintCapabilitiesXML", out result);
                return result;
            }
        }

        public System.String PrinterName
        {
            get
            {
                System.String result;
                this.GetProperty("PrinterName", out result);
                return result;
            }
        }

        public System.String PrintTicketXML
        {
            get
            {
                System.String result;
                this.GetProperty("PrintTicketXML", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrintTicketXML", value);
            }
        }

        public (System.UInt32 retval, MSFTPrinterConfiguration outcmdletOutput) GetByPrinterName(System.String inComputerName, System.String inPrinterName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPrinterName != null)
                parameters.Add(CimMethodParameter.Create("PrinterName", inPrinterName, CimType.String, inPrinterName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetByPrinterName", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTPrinterConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTPrinterConfiguration outcmdletOutput) GetByPrinterObject(MSFTPrinter inPrinterObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPrinterObject != null)
                parameters.Add(CimMethodParameter.Create("PrinterObject", inPrinterObject.AsCimInstance(), CimType.Instance, inPrinterObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetByPrinterObject", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTPrinterConfiguration)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public System.UInt32 SetByPrinterName(System.Boolean? inCollate, System.Boolean? inColor, System.String inComputerName, System.UInt32? inDuplexingMode, System.UInt32? inPaperSize, System.String inPrinterName, System.String inPrintTicketXML)
        {
            var parameters = new CimMethodParametersCollection();
            if (inCollate.HasValue)
                parameters.Add(CimMethodParameter.Create("Collate", inCollate.Value, CimFlags.None));
            if (inColor.HasValue)
                parameters.Add(CimMethodParameter.Create("Color", inColor.Value, CimFlags.None));
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inDuplexingMode.HasValue)
                parameters.Add(CimMethodParameter.Create("DuplexingMode", inDuplexingMode.Value, CimFlags.None));
            if (inPaperSize.HasValue)
                parameters.Add(CimMethodParameter.Create("PaperSize", inPaperSize.Value, CimFlags.None));
            if (inPrinterName != null)
                parameters.Add(CimMethodParameter.Create("PrinterName", inPrinterName, CimType.String, inPrinterName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPrintTicketXML != null)
                parameters.Add(CimMethodParameter.Create("PrintTicketXML", inPrintTicketXML, CimType.String, inPrintTicketXML == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetByPrinterName", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetByPrinterObject(System.Boolean? inCollate, System.Boolean? inColor, System.UInt32? inDuplexingMode, System.UInt32? inPaperSize, MSFTPrinter inPrinterObject, System.String inPrintTicketXML)
        {
            var parameters = new CimMethodParametersCollection();
            if (inCollate.HasValue)
                parameters.Add(CimMethodParameter.Create("Collate", inCollate.Value, CimFlags.None));
            if (inColor.HasValue)
                parameters.Add(CimMethodParameter.Create("Color", inColor.Value, CimFlags.None));
            if (inDuplexingMode.HasValue)
                parameters.Add(CimMethodParameter.Create("DuplexingMode", inDuplexingMode.Value, CimFlags.None));
            if (inPaperSize.HasValue)
                parameters.Add(CimMethodParameter.Create("PaperSize", inPaperSize.Value, CimFlags.None));
            if (inPrinterObject != null)
                parameters.Add(CimMethodParameter.Create("PrinterObject", inPrinterObject.AsCimInstance(), CimType.Instance, inPrinterObject == null ? CimFlags.NullValue : CimFlags.None));
            if (inPrintTicketXML != null)
                parameters.Add(CimMethodParameter.Create("PrintTicketXML", inPrintTicketXML, CimType.String, inPrintTicketXML == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetByPrinterObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetByPrintConfigObject(MSFTPrinterConfiguration inInputObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInputObject != null)
                parameters.Add(CimMethodParameter.Create("InputObject", inInputObject.AsCimInstance(), CimType.Instance, inInputObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetByPrintConfigObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}