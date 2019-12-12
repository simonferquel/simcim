using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataLsaSecuritySystemWideStatistics : Win32PerfRawData
    {
        public Win32PerfRawDataLsaSecuritySystemWideStatistics()
        {
        }

        public Win32PerfRawDataLsaSecuritySystemWideStatistics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveSchannelSessionCacheEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveSchannelSessionCacheEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveSchannelSessionCacheEntries", value);
            }
        }

        public System.UInt32? DigestAuthentications
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DigestAuthentications", out result);
                return result;
            }

            set
            {
                this.SetProperty("DigestAuthentications", value);
            }
        }

        public System.UInt32? ForwardedKerberosRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ForwardedKerberosRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("ForwardedKerberosRequests", value);
            }
        }

        public System.UInt32? KDCarmoredASRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KDCarmoredASRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("KDCarmoredASRequests", value);
            }
        }

        public System.UInt32? KDCarmoredTGSRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KDCarmoredTGSRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("KDCarmoredTGSRequests", value);
            }
        }

        public System.UInt32? KDCASRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KDCASRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("KDCASRequests", value);
            }
        }

        public System.UInt32? KDCclaimsawareASRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KDCclaimsawareASRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("KDCclaimsawareASRequests", value);
            }
        }

        public System.UInt32? KDCclaimsawareserviceassertedidentityTGSrequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KDCclaimsawareserviceassertedidentityTGSrequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("KDCclaimsawareserviceassertedidentityTGSrequests", value);
            }
        }

        public System.UInt32? KDCclaimsawareTGSRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KDCclaimsawareTGSRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("KDCclaimsawareTGSRequests", value);
            }
        }

        public System.UInt32? KDCclassictypeconstraineddelegationTGSRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KDCclassictypeconstraineddelegationTGSRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("KDCclassictypeconstraineddelegationTGSRequests", value);
            }
        }

        public System.UInt32? KDCkeytrustASRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KDCkeytrustASRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("KDCkeytrustASRequests", value);
            }
        }

        public System.UInt32? KDCresourcetypeconstraineddelegationTGSRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KDCresourcetypeconstraineddelegationTGSRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("KDCresourcetypeconstraineddelegationTGSRequests", value);
            }
        }

        public System.UInt32? KDCTGSRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KDCTGSRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("KDCTGSRequests", value);
            }
        }

        public System.UInt32? KerberosAuthentications
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("KerberosAuthentications", out result);
                return result;
            }

            set
            {
                this.SetProperty("KerberosAuthentications", value);
            }
        }

        public System.UInt32? NTLMAuthentications
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NTLMAuthentications", out result);
                return result;
            }

            set
            {
                this.SetProperty("NTLMAuthentications", value);
            }
        }

        public System.UInt32? SchannelSessionCacheEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SchannelSessionCacheEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("SchannelSessionCacheEntries", value);
            }
        }

        public System.UInt32? SSLClientSideFullHandshakes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SSLClientSideFullHandshakes", out result);
                return result;
            }

            set
            {
                this.SetProperty("SSLClientSideFullHandshakes", value);
            }
        }

        public System.UInt32? SSLClientSideReconnectHandshakes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SSLClientSideReconnectHandshakes", out result);
                return result;
            }

            set
            {
                this.SetProperty("SSLClientSideReconnectHandshakes", value);
            }
        }

        public System.UInt32? SSLServerSideFullHandshakes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SSLServerSideFullHandshakes", out result);
                return result;
            }

            set
            {
                this.SetProperty("SSLServerSideFullHandshakes", value);
            }
        }

        public System.UInt32? SSLServerSideReconnectHandshakes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SSLServerSideReconnectHandshakes", out result);
                return result;
            }

            set
            {
                this.SetProperty("SSLServerSideReconnectHandshakes", value);
            }
        }
    }
}