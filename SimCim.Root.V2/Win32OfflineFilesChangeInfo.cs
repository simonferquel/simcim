using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesChangeInfo : GenericInfrastructureObject
    {
        public Win32OfflineFilesChangeInfo()
        {
        }

        public Win32OfflineFilesChangeInfo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? CreatedOffline
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CreatedOffline", out result);
                return result;
            }
        }

        public System.Boolean? DeletedOffline
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DeletedOffline", out result);
                return result;
            }
        }

        public System.Boolean? Dirty
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Dirty", out result);
                return result;
            }
        }

        public System.Boolean? ModifiedAttributes
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ModifiedAttributes", out result);
                return result;
            }
        }

        public System.Boolean? ModifiedData
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ModifiedData", out result);
                return result;
            }
        }

        public System.Boolean? ModifiedTime
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ModifiedTime", out result);
                return result;
            }
        }
    }
}