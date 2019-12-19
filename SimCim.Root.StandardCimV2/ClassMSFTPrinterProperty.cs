using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTPrinterProperty : CIMManagedElement
    {
        public MSFTPrinterProperty()
        {
        }

        public MSFTPrinterProperty(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.String PrinterName
        {
            get
            {
                System.String result;
                this.GetProperty("PrinterName", out result);
                return result;
            }
        }

        public System.String PropertyName
        {
            get
            {
                System.String result;
                this.GetProperty("PropertyName", out result);
                return result;
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

        public System.String Value
        {
            get
            {
                System.String result;
                this.GetProperty("Value", out result);
                return result;
            }

            set
            {
                this.SetProperty("Value", value);
            }
        }

        public System.UInt32 SetByPrinterName(System.String inComputerName, System.String inPrinterName, System.String inPropertyName, System.String inValue)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPrinterName != null)
                parameters.Add(CimMethodParameter.Create("PrinterName", inPrinterName, CimType.String, inPrinterName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPropertyName != null)
                parameters.Add(CimMethodParameter.Create("PropertyName", inPropertyName, CimType.String, inPropertyName == null ? CimFlags.NullValue : CimFlags.None));
            if (inValue != null)
                parameters.Add(CimMethodParameter.Create("Value", inValue, CimType.String, inValue == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetByPrinterName", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetByPrinterPropertyObject(MSFTPrinterProperty inInputObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInputObject != null)
                parameters.Add(CimMethodParameter.Create("InputObject", inInputObject.AsCimInstance(), CimType.Instance, inInputObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetByPrinterPropertyObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SetByPrinterObject(MSFTPrinter inPrinterObject, System.String inPropertyName, System.String inValue)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPrinterObject != null)
                parameters.Add(CimMethodParameter.Create("PrinterObject", inPrinterObject.AsCimInstance(), CimType.Instance, inPrinterObject == null ? CimFlags.NullValue : CimFlags.None));
            if (inPropertyName != null)
                parameters.Add(CimMethodParameter.Create("PropertyName", inPropertyName, CimType.String, inPropertyName == null ? CimFlags.NullValue : CimFlags.None));
            if (inValue != null)
                parameters.Add(CimMethodParameter.Create("Value", inValue, CimType.String, inValue == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetByPrinterObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}