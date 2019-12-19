using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetSARule : CIMSARule
    {
        public MSFTNetSARule()
        {
        }

        public MSFTNetSARule(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DisplayGroup
        {
            get
            {
                System.String result;
                this.GetProperty("DisplayGroup", out result);
                return result;
            }
        }

        public System.String DisplayName
        {
            get
            {
                System.String result;
                this.GetProperty("DisplayName", out result);
                return result;
            }
        }

        public System.UInt16[] EnforcementStatus
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("EnforcementStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnforcementStatus", value);
            }
        }

        public System.String MainModeCryptoSet
        {
            get
            {
                System.String result;
                this.GetProperty("MainModeCryptoSet", out result);
                return result;
            }

            set
            {
                this.SetProperty("MainModeCryptoSet", value);
            }
        }

        public System.String Phase1AuthSet
        {
            get
            {
                System.String result;
                this.GetProperty("Phase1AuthSet", out result);
                return result;
            }

            set
            {
                this.SetProperty("Phase1AuthSet", value);
            }
        }

        public System.String Phase2AuthSet
        {
            get
            {
                System.String result;
                this.GetProperty("Phase2AuthSet", out result);
                return result;
            }

            set
            {
                this.SetProperty("Phase2AuthSet", value);
            }
        }

        public System.String[] Platforms
        {
            get
            {
                System.String[] result;
                this.GetProperty("Platforms", out result);
                return result;
            }

            set
            {
                this.SetProperty("Platforms", value);
            }
        }

        public System.String PolicyStoreSource
        {
            get
            {
                System.String result;
                this.GetProperty("PolicyStoreSource", out result);
                return result;
            }

            set
            {
                this.SetProperty("PolicyStoreSource", value);
            }
        }

        public System.UInt16? PolicyStoreSourceType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PolicyStoreSourceType", out result);
                return result;
            }

            set
            {
                this.SetProperty("PolicyStoreSourceType", value);
            }
        }

        public System.UInt16? PrimaryStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PrimaryStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrimaryStatus", value);
            }
        }

        public System.UInt16? Profiles
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Profiles", out result);
                return result;
            }

            set
            {
                this.SetProperty("Profiles", value);
            }
        }

        public System.String QuickModeCryptoSet
        {
            get
            {
                System.String result;
                this.GetProperty("QuickModeCryptoSet", out result);
                return result;
            }

            set
            {
                this.SetProperty("QuickModeCryptoSet", value);
            }
        }

        public System.String RuleGroup
        {
            get
            {
                System.String result;
                this.GetProperty("RuleGroup", out result);
                return result;
            }

            set
            {
                this.SetProperty("RuleGroup", value);
            }
        }

        public System.String Status
        {
            get
            {
                System.String result;
                this.GetProperty("Status", out result);
                return result;
            }

            set
            {
                this.SetProperty("Status", value);
            }
        }

        public System.UInt32? StatusCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StatusCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("StatusCode", value);
            }
        }
    }
}