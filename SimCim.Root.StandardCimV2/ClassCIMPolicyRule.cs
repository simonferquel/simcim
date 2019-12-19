using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMPolicyRule : CIMPolicySet
    {
        public CIMPolicyRule()
        {
        }

        public CIMPolicyRule(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? ConditionListType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ConditionListType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConditionListType", value);
            }
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

        public System.UInt16? ExecutionStrategy
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ExecutionStrategy", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExecutionStrategy", value);
            }
        }

        public System.Boolean? Mandatory
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Mandatory", out result);
                return result;
            }

            set
            {
                this.SetProperty("Mandatory", value);
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

        public System.UInt16? Priority
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Priority", out result);
                return result;
            }

            set
            {
                this.SetProperty("Priority", value);
            }
        }

        public System.String RuleUsage
        {
            get
            {
                System.String result;
                this.GetProperty("RuleUsage", out result);
                return result;
            }

            set
            {
                this.SetProperty("RuleUsage", value);
            }
        }

        public System.UInt16? SequencedActions
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SequencedActions", out result);
                return result;
            }

            set
            {
                this.SetProperty("SequencedActions", value);
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