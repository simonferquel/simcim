using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetFirewallRule : CIMPolicyRule
    {
        public MSFTNetFirewallRule()
        {
        }

        public MSFTNetFirewallRule(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Action
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Action", out result);
                return result;
            }

            set
            {
                this.SetProperty("Action", value);
            }
        }

        public System.UInt16? Direction
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Direction", out result);
                return result;
            }

            set
            {
                this.SetProperty("Direction", value);
            }
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

        public System.UInt16? EdgeTraversalPolicy
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EdgeTraversalPolicy", out result);
                return result;
            }

            set
            {
                this.SetProperty("EdgeTraversalPolicy", value);
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

        public System.Boolean? LocalOnlyMapping
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LocalOnlyMapping", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalOnlyMapping", value);
            }
        }

        public System.Boolean? LooseSourceMapping
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LooseSourceMapping", out result);
                return result;
            }

            set
            {
                this.SetProperty("LooseSourceMapping", value);
            }
        }

        public System.String Owner
        {
            get
            {
                System.String result;
                this.GetProperty("Owner", out result);
                return result;
            }

            set
            {
                this.SetProperty("Owner", value);
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

        public System.UInt32 Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Rename(System.String inNewName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 CloneObject(System.String inNewGPOSession, System.String inNewName, System.String inNewPolicyStore)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewGPOSession != null)
                parameters.Add(CimMethodParameter.Create("NewGPOSession", inNewGPOSession, CimType.String, inNewGPOSession == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewPolicyStore != null)
                parameters.Add(CimMethodParameter.Create("NewPolicyStore", inNewPolicyStore, CimType.String, inNewPolicyStore == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CloneObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, IEnumerable<CIMManagedSystemElement> outDependents) EnumerateFull()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnumerateFull", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<CIMManagedSystemElement>)InfrastuctureObjectScope.Mapper.CreateMany<CIMManagedSystemElement>(InfrastuctureObjectScope, (IEnumerable<CimInstance>)result.OutParameters["Dependents"].Value));
        }
    }
}