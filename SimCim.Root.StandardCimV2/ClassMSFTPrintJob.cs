using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTPrintJob : CIMManagedSystemElement
    {
        public MSFTPrintJob()
        {
        }

        public MSFTPrintJob(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String Datatype
        {
            get
            {
                System.String result;
                this.GetProperty("Datatype", out result);
                return result;
            }
        }

        public System.String DocumentName
        {
            get
            {
                System.String result;
                this.GetProperty("DocumentName", out result);
                return result;
            }
        }

        public System.UInt32 Id
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("Id", out result);
                return result;
            }
        }

        public System.UInt32? JobStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("JobStatus", out result);
                return result;
            }
        }

        public System.UInt32? JobTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("JobTime", out result);
                return result;
            }
        }

        public System.UInt32? PagesPrinted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PagesPrinted", out result);
                return result;
            }
        }

        public System.UInt32? Position
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Position", out result);
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

        public System.UInt32? Priority
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Priority", out result);
                return result;
            }
        }

        public System.UInt32? Size
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Size", out result);
                return result;
            }
        }

        public System.DateTime? SubmittedTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("SubmittedTime", out result);
                return result;
            }
        }

        public System.UInt32? TotalPages
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalPages", out result);
                return result;
            }
        }

        public System.String UserName
        {
            get
            {
                System.String result;
                this.GetProperty("UserName", out result);
                return result;
            }
        }

        public (System.UInt32 retval, IEnumerable<MSFTPrintJob> outcmdletOutput) GetByName(System.String inComputerName, System.UInt32? inID, System.String inPrinterName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inID.HasValue)
                parameters.Add(CimMethodParameter.Create("ID", inID.Value, CimFlags.None));
            if (inPrinterName != null)
                parameters.Add(CimMethodParameter.Create("PrinterName", inPrinterName, CimType.String, inPrinterName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetByName", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MSFTPrintJob>)InfrastuctureObjectScope.Mapper.CreateMany<MSFTPrintJob>(InfrastuctureObjectScope, (IEnumerable<CimInstance>)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, IEnumerable<MSFTPrintJob> outcmdletOutput) GetByObject(System.UInt32? inID, MSFTPrinter inPrinterObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inID.HasValue)
                parameters.Add(CimMethodParameter.Create("ID", inID.Value, CimFlags.None));
            if (inPrinterObject != null)
                parameters.Add(CimMethodParameter.Create("PrinterObject", inPrinterObject.AsCimInstance(), CimType.Instance, inPrinterObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetByObject", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MSFTPrintJob>)InfrastuctureObjectScope.Mapper.CreateMany<MSFTPrintJob>(InfrastuctureObjectScope, (IEnumerable<CimInstance>)result.OutParameters["cmdletOutput"].Value));
        }

        public System.UInt32 DeleteJobByObject(MSFTPrintJob inInputObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInputObject != null)
                parameters.Add(CimMethodParameter.Create("InputObject", inInputObject.AsCimInstance(), CimType.Instance, inInputObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DeleteJobByObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 DeleteJobById(System.String inComputerName, System.UInt32? inID, System.String inPrinterName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inID.HasValue)
                parameters.Add(CimMethodParameter.Create("ID", inID.Value, CimFlags.None));
            if (inPrinterName != null)
                parameters.Add(CimMethodParameter.Create("PrinterName", inPrinterName, CimType.String, inPrinterName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DeleteJobById", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 DeleteJobByPrinterObject(System.UInt32? inID, MSFTPrinter inPrinterObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inID.HasValue)
                parameters.Add(CimMethodParameter.Create("ID", inID.Value, CimFlags.None));
            if (inPrinterObject != null)
                parameters.Add(CimMethodParameter.Create("PrinterObject", inPrinterObject.AsCimInstance(), CimType.Instance, inPrinterObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DeleteJobByPrinterObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RestartJobByObject(MSFTPrintJob inInputObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInputObject != null)
                parameters.Add(CimMethodParameter.Create("InputObject", inInputObject.AsCimInstance(), CimType.Instance, inInputObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RestartJobByObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RestartJobById(System.String inComputerName, System.UInt32? inID, System.String inPrinterName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inID.HasValue)
                parameters.Add(CimMethodParameter.Create("ID", inID.Value, CimFlags.None));
            if (inPrinterName != null)
                parameters.Add(CimMethodParameter.Create("PrinterName", inPrinterName, CimType.String, inPrinterName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RestartJobById", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RestartJobByPrinterObject(System.UInt32? inID, MSFTPrinter inPrinterObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inID.HasValue)
                parameters.Add(CimMethodParameter.Create("ID", inID.Value, CimFlags.None));
            if (inPrinterObject != null)
                parameters.Add(CimMethodParameter.Create("PrinterObject", inPrinterObject.AsCimInstance(), CimType.Instance, inPrinterObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RestartJobByPrinterObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ResumeJobByObject(MSFTPrintJob inInputObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInputObject != null)
                parameters.Add(CimMethodParameter.Create("InputObject", inInputObject.AsCimInstance(), CimType.Instance, inInputObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ResumeJobByObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ResumeJobById(System.String inComputerName, System.UInt32? inID, System.String inPrinterName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inID.HasValue)
                parameters.Add(CimMethodParameter.Create("ID", inID.Value, CimFlags.None));
            if (inPrinterName != null)
                parameters.Add(CimMethodParameter.Create("PrinterName", inPrinterName, CimType.String, inPrinterName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ResumeJobById", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ResumeJobByPrinterObject(System.UInt32? inID, MSFTPrinter inPrinterObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inID.HasValue)
                parameters.Add(CimMethodParameter.Create("ID", inID.Value, CimFlags.None));
            if (inPrinterObject != null)
                parameters.Add(CimMethodParameter.Create("PrinterObject", inPrinterObject.AsCimInstance(), CimType.Instance, inPrinterObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ResumeJobByPrinterObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SuspendJobByObject(MSFTPrintJob inInputObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInputObject != null)
                parameters.Add(CimMethodParameter.Create("InputObject", inInputObject.AsCimInstance(), CimType.Instance, inInputObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SuspendJobByObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SuspendJobById(System.String inComputerName, System.UInt32? inID, System.String inPrinterName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inID.HasValue)
                parameters.Add(CimMethodParameter.Create("ID", inID.Value, CimFlags.None));
            if (inPrinterName != null)
                parameters.Add(CimMethodParameter.Create("PrinterName", inPrinterName, CimType.String, inPrinterName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SuspendJobById", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SuspendJobByPrinterObject(System.UInt32? inID, MSFTPrinter inPrinterObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inID.HasValue)
                parameters.Add(CimMethodParameter.Create("ID", inID.Value, CimFlags.None));
            if (inPrinterObject != null)
                parameters.Add(CimMethodParameter.Create("PrinterObject", inPrinterObject.AsCimInstance(), CimType.Instance, inPrinterObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SuspendJobByPrinterObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}