using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCollectionReferencePointExportJob : CIMConcreteJob
    {
        public MsvmCollectionReferencePointExportJob()
        {
        }

        public MsvmCollectionReferencePointExportJob(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BaseReferencePointGroupId
        {
            get
            {
                System.String result;
                this.GetProperty("BaseReferencePointGroupId", out result);
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

        public System.String CollectionId
        {
            get
            {
                System.String result;
                this.GetProperty("CollectionId", out result);
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

        public System.String[] ExportedConfigFilePaths
        {
            get
            {
                System.String[] result;
                this.GetProperty("ExportedConfigFilePaths", out result);
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

        public System.String[] ExportedGuestStateFilePaths
        {
            get
            {
                System.String[] result;
                this.GetProperty("ExportedGuestStateFilePaths", out result);
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

        public System.String[] ExportedRuntimeFilePaths
        {
            get
            {
                System.String[] result;
                this.GetProperty("ExportedRuntimeFilePaths", out result);
                return result;
            }
        }

        public System.String ReferencePointGroupId
        {
            get
            {
                System.String result;
                this.GetProperty("ReferencePointGroupId", out result);
                return result;
            }
        }

        public System.String[] VirtualMachineId
        {
            get
            {
                System.String[] result;
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