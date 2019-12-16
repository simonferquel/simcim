using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetPrefixPolicy : CIMManagedElement
    {
        public MSFTNetPrefixPolicy()
        {
        }

        public MSFTNetPrefixPolicy(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Label
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Label", out result);
                return result;
            }

            set
            {
                this.SetProperty("Label", value);
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

        public System.String Prefix
        {
            get
            {
                System.String result;
                this.GetProperty("Prefix", out result);
                return result;
            }
        }

        public System.Byte Store
        {
            get
            {
                System.Byte result;
                this.GetProperty("Store", out result);
                return result;
            }
        }

        public (System.UInt32 retval, IEnumerable<MSFTNetPrefixPolicy> outCmdletOutput) Create(System.UInt32? inLabel, System.Boolean? inPassThru, System.String inPolicyStore, System.UInt32? inPrecedence, System.String inPrefix)
        {
            var parameters = new CimMethodParametersCollection();
            if (inLabel.HasValue)
                parameters.Add(CimMethodParameter.Create("Label", inLabel.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            if (inPolicyStore != null)
                parameters.Add(CimMethodParameter.Create("PolicyStore", inPolicyStore, CimType.String, inPolicyStore == null ? CimFlags.NullValue : CimFlags.None));
            if (inPrecedence.HasValue)
                parameters.Add(CimMethodParameter.Create("Precedence", inPrecedence.Value, CimFlags.None));
            if (inPrefix != null)
                parameters.Add(CimMethodParameter.Create("Prefix", inPrefix, CimType.String, inPrefix == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<MSFTNetPrefixPolicy>)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }
    }
}