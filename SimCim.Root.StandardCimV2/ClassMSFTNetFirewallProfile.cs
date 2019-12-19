using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetFirewallProfile : CIMManagedElement
    {
        public MSFTNetFirewallProfile()
        {
        }

        public MSFTNetFirewallProfile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AllowInboundRules
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AllowInboundRules", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowInboundRules", value);
            }
        }

        public System.UInt16? AllowLocalFirewallRules
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AllowLocalFirewallRules", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowLocalFirewallRules", value);
            }
        }

        public System.UInt16? AllowLocalIPsecRules
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AllowLocalIPsecRules", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowLocalIPsecRules", value);
            }
        }

        public System.UInt16? AllowUnicastResponseToMulticast
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AllowUnicastResponseToMulticast", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowUnicastResponseToMulticast", value);
            }
        }

        public System.UInt16? AllowUserApps
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AllowUserApps", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowUserApps", value);
            }
        }

        public System.UInt16? AllowUserPorts
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AllowUserPorts", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowUserPorts", value);
            }
        }

        public System.UInt16? DefaultInboundAction
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DefaultInboundAction", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultInboundAction", value);
            }
        }

        public System.UInt16? DefaultOutboundAction
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DefaultOutboundAction", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultOutboundAction", value);
            }
        }

        public System.String[] DisabledInterfaceAliases
        {
            get
            {
                System.String[] result;
                this.GetProperty("DisabledInterfaceAliases", out result);
                return result;
            }

            set
            {
                this.SetProperty("DisabledInterfaceAliases", value);
            }
        }

        public System.UInt16? Enabled
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("Enabled", value);
            }
        }

        public System.UInt16? EnableStealthModeForIPsec
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnableStealthModeForIPsec", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnableStealthModeForIPsec", value);
            }
        }

        public System.UInt16? LogAllowed
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LogAllowed", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogAllowed", value);
            }
        }

        public System.UInt16? LogBlocked
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LogBlocked", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogBlocked", value);
            }
        }

        public System.String LogFileName
        {
            get
            {
                System.String result;
                this.GetProperty("LogFileName", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogFileName", value);
            }
        }

        public System.UInt16? LogIgnored
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LogIgnored", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogIgnored", value);
            }
        }

        public System.UInt64? LogMaxSizeKilobytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LogMaxSizeKilobytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogMaxSizeKilobytes", value);
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.UInt16? NotifyOnListen
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NotifyOnListen", out result);
                return result;
            }

            set
            {
                this.SetProperty("NotifyOnListen", value);
            }
        }
    }
}