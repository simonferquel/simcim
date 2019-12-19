using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetQosPolicySettingData : MSFTNetSettingData
    {
        public MSFTNetQosPolicySettingData()
        {
        }

        public MSFTNetQosPolicySettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AppPathNameMatchCondition
        {
            get
            {
                System.String result;
                this.GetProperty("AppPathNameMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("AppPathNameMatchCondition", value);
            }
        }

        public System.SByte? DSCPAction
        {
            get
            {
                System.SByte? result;
                this.GetProperty("DSCPAction", out result);
                return result;
            }

            set
            {
                this.SetProperty("DSCPAction", value);
            }
        }

        public System.UInt16? IPDstPortEndMatchCondition
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IPDstPortEndMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPDstPortEndMatchCondition", value);
            }
        }

        public System.UInt16? IPDstPortStartMatchCondition
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IPDstPortStartMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPDstPortStartMatchCondition", value);
            }
        }

        public System.String IPDstPrefixMatchCondition
        {
            get
            {
                System.String result;
                this.GetProperty("IPDstPrefixMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPDstPrefixMatchCondition", value);
            }
        }

        public System.UInt16? IPPortMatchCondition
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IPPortMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPPortMatchCondition", value);
            }
        }

        public System.UInt32? IPProtocolMatchCondition
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPProtocolMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPProtocolMatchCondition", value);
            }
        }

        public System.UInt16? IPSrcPortEndMatchCondition
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IPSrcPortEndMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPSrcPortEndMatchCondition", value);
            }
        }

        public System.UInt16? IPSrcPortStartMatchCondition
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IPSrcPortStartMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPSrcPortStartMatchCondition", value);
            }
        }

        public System.String IPSrcPrefixMatchCondition
        {
            get
            {
                System.String result;
                this.GetProperty("IPSrcPrefixMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPSrcPrefixMatchCondition", value);
            }
        }

        public System.String JobObjectMatchCondition
        {
            get
            {
                System.String result;
                this.GetProperty("JobObjectMatchCondition", out result);
                return result;
            }
        }

        public System.Byte? MinBandwidthWeightAction
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MinBandwidthWeightAction", out result);
                return result;
            }

            set
            {
                this.SetProperty("MinBandwidthWeightAction", value);
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

        public System.UInt16? NetDirectPortMatchCondition
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NetDirectPortMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetDirectPortMatchCondition", value);
            }
        }

        public System.UInt32? NetworkProfile
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NetworkProfile", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetworkProfile", value);
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
        }

        public System.UInt32? Precedence
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Precedence", out result);
                return result;
            }

            set
            {
                this.SetProperty("Precedence", value);
            }
        }

        public System.SByte? PriorityValue8021Action
        {
            get
            {
                System.SByte? result;
                this.GetProperty("PriorityValue8021Action", out result);
                return result;
            }

            set
            {
                this.SetProperty("PriorityValue8021Action", value);
            }
        }

        public System.UInt32? TemplateMatchCondition
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TemplateMatchCondition", out result);
                return result;
            }
        }

        public System.UInt64? ThrottleRateAction
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ThrottleRateAction", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThrottleRateAction", value);
            }
        }

        public System.String URIMatchCondition
        {
            get
            {
                System.String result;
                this.GetProperty("URIMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("URIMatchCondition", value);
            }
        }

        public System.Boolean? URIRecursiveMatchCondition
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("URIRecursiveMatchCondition", out result);
                return result;
            }

            set
            {
                this.SetProperty("URIRecursiveMatchCondition", value);
            }
        }

        public System.String UserMatchCondition
        {
            get
            {
                System.String result;
                this.GetProperty("UserMatchCondition", out result);
                return result;
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }
    }
}