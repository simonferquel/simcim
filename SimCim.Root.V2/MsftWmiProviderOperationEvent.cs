using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderOperationEvent : MSFTWmiSelfEvent
    {
        public MsftWmiProviderOperationEvent()
        {
        }

        public MsftWmiProviderOperationEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String HostingGroup
        {
            get
            {
                System.String result;
                this.GetProperty("HostingGroup", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostingGroup", value);
            }
        }

        public System.UInt32? HostingSpecification
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HostingSpecification", out result);
                return result;
            }

            set
            {
                this.SetProperty("HostingSpecification", value);
            }
        }

        public System.String Locale
        {
            get
            {
                System.String result;
                this.GetProperty("Locale", out result);
                return result;
            }

            set
            {
                this.SetProperty("Locale", value);
            }
        }

        public System.String Namespace
        {
            get
            {
                System.String result;
                this.GetProperty("Namespace", out result);
                return result;
            }

            set
            {
                this.SetProperty("Namespace", value);
            }
        }

        public System.String Provider
        {
            get
            {
                System.String result;
                this.GetProperty("provider", out result);
                return result;
            }

            set
            {
                this.SetProperty("provider", value);
            }
        }

        public System.String TransactionIdentifer
        {
            get
            {
                System.String result;
                this.GetProperty("TransactionIdentifer", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransactionIdentifer", value);
            }
        }

        public System.String User
        {
            get
            {
                System.String result;
                this.GetProperty("User", out result);
                return result;
            }

            set
            {
                this.SetProperty("User", value);
            }
        }
    }
}