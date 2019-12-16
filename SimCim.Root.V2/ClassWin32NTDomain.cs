using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NTDomain : CIMSystem
    {
        public Win32NTDomain()
        {
        }

        public Win32NTDomain(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ClientSiteName
        {
            get
            {
                System.String result;
                this.GetProperty("ClientSiteName", out result);
                return result;
            }
        }

        public System.String DcSiteName
        {
            get
            {
                System.String result;
                this.GetProperty("DcSiteName", out result);
                return result;
            }
        }

        public System.String DnsForestName
        {
            get
            {
                System.String result;
                this.GetProperty("DnsForestName", out result);
                return result;
            }
        }

        public System.String DomainControllerAddress
        {
            get
            {
                System.String result;
                this.GetProperty("DomainControllerAddress", out result);
                return result;
            }
        }

        public System.Int32? DomainControllerAddressType
        {
            get
            {
                System.Int32? result;
                this.GetProperty("DomainControllerAddressType", out result);
                return result;
            }
        }

        public System.String DomainControllerName
        {
            get
            {
                System.String result;
                this.GetProperty("DomainControllerName", out result);
                return result;
            }
        }

        public System.String DomainGuid
        {
            get
            {
                System.String result;
                this.GetProperty("DomainGuid", out result);
                return result;
            }
        }

        public System.String DomainName
        {
            get
            {
                System.String result;
                this.GetProperty("DomainName", out result);
                return result;
            }
        }

        public System.Boolean? DSDirectoryServiceFlag
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DSDirectoryServiceFlag", out result);
                return result;
            }
        }

        public System.Boolean? DSDnsControllerFlag
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DSDnsControllerFlag", out result);
                return result;
            }
        }

        public System.Boolean? DSDnsDomainFlag
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DSDnsDomainFlag", out result);
                return result;
            }
        }

        public System.Boolean? DSDnsForestFlag
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DSDnsForestFlag", out result);
                return result;
            }
        }

        public System.Boolean? DSGlobalCatalogFlag
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DSGlobalCatalogFlag", out result);
                return result;
            }
        }

        public System.Boolean? DSKerberosDistributionCenterFlag
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DSKerberosDistributionCenterFlag", out result);
                return result;
            }
        }

        public System.Boolean? DSPrimaryDomainControllerFlag
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DSPrimaryDomainControllerFlag", out result);
                return result;
            }
        }

        public System.Boolean? DSTimeServiceFlag
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DSTimeServiceFlag", out result);
                return result;
            }
        }

        public System.Boolean? DSWritableFlag
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DSWritableFlag", out result);
                return result;
            }
        }
    }
}