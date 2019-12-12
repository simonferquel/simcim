using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSCSIController : CIMController
    {
        protected CIMSCSIController()
        {
        }

        protected CIMSCSIController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ControllerTimeouts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ControllerTimeouts", out result);
                return result;
            }
        }

        public System.UInt32? MaxDataWidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxDataWidth", out result);
                return result;
            }
        }

        public System.UInt64? MaxTransferRate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxTransferRate", out result);
                return result;
            }
        }

        public System.UInt16? ProtectionManagement
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProtectionManagement", out result);
                return result;
            }
        }
    }
}