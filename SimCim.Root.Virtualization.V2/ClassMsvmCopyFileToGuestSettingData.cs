using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCopyFileToGuestSettingData : CIMSettingData
    {
        public MsvmCopyFileToGuestSettingData()
        {
        }

        public MsvmCopyFileToGuestSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? CreateFullPath
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CreateFullPath", out result);
                return result;
            }
        }

        public System.String DestinationPath
        {
            get
            {
                System.String result;
                this.GetProperty("DestinationPath", out result);
                return result;
            }
        }

        public System.Boolean? OverwriteExisting
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OverwriteExisting", out result);
                return result;
            }
        }

        public System.String SourcePath
        {
            get
            {
                System.String result;
                this.GetProperty("SourcePath", out result);
                return result;
            }
        }
    }
}