using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class SoftwareLicensingTokenActivationLicense : GenericInfrastructureObject
    {
        public SoftwareLicensingTokenActivationLicense()
        {
        }

        public SoftwareLicensingTokenActivationLicense(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AdditionalInfo
        {
            get
            {
                System.String result;
                this.GetProperty("AdditionalInfo", out result);
                return result;
            }
        }

        public System.UInt32? AuthorizationStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthorizationStatus", out result);
                return result;
            }
        }

        public System.String Description
        {
            get
            {
                System.String result;
                this.GetProperty("Description", out result);
                return result;
            }
        }

        public System.DateTime? ExpirationDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("ExpirationDate", out result);
                return result;
            }
        }

        public System.String ID
        {
            get
            {
                System.String result;
                this.GetProperty("ID", out result);
                return result;
            }
        }

        public System.String ILID
        {
            get
            {
                System.String result;
                this.GetProperty("ILID", out result);
                return result;
            }
        }

        public System.UInt32? ILVID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ILVID", out result);
                return result;
            }
        }

        public System.UInt32 Uninstall()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Uninstall", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}