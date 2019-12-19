using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class CIMPolicyAction : CIMPolicy
    {
        protected CIMPolicyAction()
        {
        }

        protected CIMPolicyAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("CreationClassName", value);
            }
        }

        public System.Boolean? DoActionLogging
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DoActionLogging", out result);
                return result;
            }

            set
            {
                this.SetProperty("DoActionLogging", value);
            }
        }

        public System.String PolicyActionName
        {
            get
            {
                System.String result;
                this.GetProperty("PolicyActionName", out result);
                return result;
            }

            set
            {
                this.SetProperty("PolicyActionName", value);
            }
        }

        public System.String PolicyRuleCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("PolicyRuleCreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("PolicyRuleCreationClassName", value);
            }
        }

        public System.String PolicyRuleName
        {
            get
            {
                System.String result;
                this.GetProperty("PolicyRuleName", out result);
                return result;
            }

            set
            {
                this.SetProperty("PolicyRuleName", value);
            }
        }

        public System.String SystemCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemCreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemCreationClassName", value);
            }
        }

        public System.String SystemName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemName", value);
            }
        }
    }
}