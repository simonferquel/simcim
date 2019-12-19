using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetIPsecDoSPSetting : MSFTNetSettingData
    {
        public MSFTNetIPsecDoSPSetting()
        {
        }

        public MSFTNetIPsecDoSPSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? DefBlockExemptDscp
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DefBlockExemptDscp", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefBlockExemptDscp", value);
            }
        }

        public System.UInt32? DefBlockExemptRateLimitBytesPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefBlockExemptRateLimitBytesPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefBlockExemptRateLimitBytesPerSec", value);
            }
        }

        public System.UInt16? EffectiveAddressFamily
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EffectiveAddressFamily", out result);
                return result;
            }
        }

        public System.UInt32? EnabledKeyingModules
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EnabledKeyingModules", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnabledKeyingModules", value);
            }
        }

        public System.UInt32? FilteringFlags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FilteringFlags", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilteringFlags", value);
            }
        }

        public System.UInt16? IcmpV6Dscp
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IcmpV6Dscp", out result);
                return result;
            }

            set
            {
                this.SetProperty("IcmpV6Dscp", value);
            }
        }

        public System.UInt32? IcmpV6RateLimitBytesPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IcmpV6RateLimitBytesPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IcmpV6RateLimitBytesPerSec", value);
            }
        }

        public System.UInt32? IpV6FilterExemptDscp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IpV6FilterExemptDscp", out result);
                return result;
            }

            set
            {
                this.SetProperty("IpV6FilterExemptDscp", value);
            }
        }

        public System.UInt32? IpV6FilterExemptRateLimitBytesPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IpV6FilterExemptRateLimitBytesPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IpV6FilterExemptRateLimitBytesPerSec", value);
            }
        }

        public System.UInt16? IpV6IPsecAuthDscp
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IpV6IPsecAuthDscp", out result);
                return result;
            }

            set
            {
                this.SetProperty("IpV6IPsecAuthDscp", value);
            }
        }

        public System.UInt32? IpV6IPsecAuthRateLimitBytesPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IpV6IPsecAuthRateLimitBytesPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IpV6IPsecAuthRateLimitBytesPerSec", value);
            }
        }

        public System.UInt32? IpV6IPsecUnauthDscp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IpV6IPsecUnauthDscp", out result);
                return result;
            }

            set
            {
                this.SetProperty("IpV6IPsecUnauthDscp", value);
            }
        }

        public System.UInt32? IpV6IPsecUnauthPerIPRateLimitBytesPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IpV6IPsecUnauthPerIPRateLimitBytesPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IpV6IPsecUnauthPerIPRateLimitBytesPerSec", value);
            }
        }

        public System.UInt32? IpV6IPsecUnauthRateLimitBytesPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IpV6IPsecUnauthRateLimitBytesPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IpV6IPsecUnauthRateLimitBytesPerSec", value);
            }
        }

        public System.UInt32? MaxPerIPRateLimitQueues
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxPerIPRateLimitQueues", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxPerIPRateLimitQueues", value);
            }
        }

        public System.UInt32? MaxStateEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxStateEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxStateEntries", value);
            }
        }

        public System.UInt32? PerIPRateLimitQueueIdleTimeoutSeconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PerIPRateLimitQueueIdleTimeoutSeconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("PerIPRateLimitQueueIdleTimeoutSeconds", value);
            }
        }

        public System.String[] PrivateInterfaceAliases
        {
            get
            {
                System.String[] result;
                this.GetProperty("PrivateInterfaceAliases", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrivateInterfaceAliases", value);
            }
        }

        public System.String PrivateV6Address
        {
            get
            {
                System.String result;
                this.GetProperty("PrivateV6Address", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrivateV6Address", value);
            }
        }

        public System.String[] PublicInterfaceAliases
        {
            get
            {
                System.String[] result;
                this.GetProperty("PublicInterfaceAliases", out result);
                return result;
            }

            set
            {
                this.SetProperty("PublicInterfaceAliases", value);
            }
        }

        public System.String PublicV6Address
        {
            get
            {
                System.String result;
                this.GetProperty("PublicV6Address", out result);
                return result;
            }

            set
            {
                this.SetProperty("PublicV6Address", value);
            }
        }

        public System.UInt32? StateIdleTimeoutSeconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StateIdleTimeoutSeconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("StateIdleTimeoutSeconds", value);
            }
        }
    }
}