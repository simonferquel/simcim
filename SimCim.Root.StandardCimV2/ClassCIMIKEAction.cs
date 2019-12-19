using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMIKEAction : CIMSANegotiationAction
    {
        public CIMIKEAction()
        {
        }

        public CIMIKEAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AggressiveModeGroupID
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AggressiveModeGroupID", out result);
                return result;
            }

            set
            {
                this.SetProperty("AggressiveModeGroupID", value);
            }
        }

        public System.UInt16? ExchangeMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ExchangeMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExchangeMode", value);
            }
        }

        public System.UInt16? UseIKEIdentityType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("UseIKEIdentityType", out result);
                return result;
            }

            set
            {
                this.SetProperty("UseIKEIdentityType", value);
            }
        }

        public System.String VendorID
        {
            get
            {
                System.String result;
                this.GetProperty("VendorID", out result);
                return result;
            }

            set
            {
                this.SetProperty("VendorID", value);
            }
        }
    }
}