using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetIKEAuthSet : CIMIKEAction
    {
        public MSFTNetIKEAuthSet()
        {
        }

        public MSFTNetIKEAuthSet(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public IEnumerable<MSFTNetIKEAuthProposal> Proposals
        {
            get
            {
                IEnumerable<MSFTNetIKEAuthProposal> result;
                this.GetInfrastructureObjectProperty("Proposals", out result);
                return result;
            }

            set
            {
                this.SetProperty("Proposals", value);
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