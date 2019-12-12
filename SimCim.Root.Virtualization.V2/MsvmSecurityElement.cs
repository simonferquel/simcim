using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSecurityElement : CIMEnabledLogicalElement
    {
        public MsvmSecurityElement()
        {
        }

        public MsvmSecurityElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("CreationClassName", value);
            }
        }

        public System.Boolean? EncryptStateAndVmMigrationTrafficEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EncryptStateAndVmMigrationTrafficEnabled", out result);
                return result;
            }
        }

        public System.Boolean? Shielded
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Shielded", out result);
                return result;
            }
        }

        public System.String SystemCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemCreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemCreationClassName", value);
            }
        }

        public System.String SystemName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemName", value);
            }
        }
    }
}