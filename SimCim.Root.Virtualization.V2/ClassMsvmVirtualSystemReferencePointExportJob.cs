using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualSystemReferencePointExportJob : CIMConcreteJob
    {
        public MsvmVirtualSystemReferencePointExportJob()
        {
        }

        public MsvmVirtualSystemReferencePointExportJob(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BaseReferencePointId
        {
            get
            {
                System.String result;
                this.GetProperty("BaseReferencePointId", out result);
                return result;
            }
        }

        public System.Boolean? Cancellable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Cancellable", out result);
                return result;
            }
        }

        public System.String ErrorSummaryDescription
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorSummaryDescription", out result);
                return result;
            }
        }

        public System.String ExportDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("ExportDirectory", out result);
                return result;
            }
        }

        public System.String ExportedConfigFilePath
        {
            get
            {
                System.String result;
                this.GetProperty("ExportedConfigFilePath", out result);
                return result;
            }
        }

        public System.String[] ExportedDisks
        {
            get
            {
                System.String[] result;
                this.GetProperty("ExportedDisks", out result);
                return result;
            }
        }

        public System.String ExportedGuestStateFilePath
        {
            get
            {
                System.String result;
                this.GetProperty("ExportedGuestStateFilePath", out result);
                return result;
            }
        }

        public System.String[] ExportedLogFilePaths
        {
            get
            {
                System.String[] result;
                this.GetProperty("ExportedLogFilePaths", out result);
                return result;
            }
        }

        public System.String ExportedRuntimeFilePath
        {
            get
            {
                System.String result;
                this.GetProperty("ExportedRuntimeFilePath", out result);
                return result;
            }
        }

        public System.String ReferencePointId
        {
            get
            {
                System.String result;
                this.GetProperty("ReferencePointId", out result);
                return result;
            }
        }

        public System.String VirtualMachineId
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualMachineId", out result);
                return result;
            }
        }

        public (System.UInt32 retval, System.String[] outErrors) GetErrorEx()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetErrorEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String[])result.OutParameters["Errors"].Value);
        }
    }
}