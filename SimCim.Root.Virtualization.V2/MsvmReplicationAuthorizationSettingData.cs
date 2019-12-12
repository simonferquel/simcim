using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmReplicationAuthorizationSettingData : CIMSettingData
    {
        public MsvmReplicationAuthorizationSettingData()
        {
        }

        public MsvmReplicationAuthorizationSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AllowedPrimaryHostSystem
        {
            get
            {
                System.String result;
                this.GetProperty("AllowedPrimaryHostSystem", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowedPrimaryHostSystem", value);
            }
        }

        public System.String ReplicaStorageLocation
        {
            get
            {
                System.String result;
                this.GetProperty("ReplicaStorageLocation", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReplicaStorageLocation", value);
            }
        }

        public System.String TrustGroup
        {
            get
            {
                System.String result;
                this.GetProperty("TrustGroup", out result);
                return result;
            }

            set
            {
                this.SetProperty("TrustGroup", value);
            }
        }
    }
}