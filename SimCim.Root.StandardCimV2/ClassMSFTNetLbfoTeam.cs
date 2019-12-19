using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetLbfoTeam : MSFTNetImPlatTeam
    {
        public MSFTNetLbfoTeam()
        {
        }

        public MSFTNetLbfoTeam(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? LacpTimer
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LacpTimer", out result);
                return result;
            }

            set
            {
                this.SetProperty("LacpTimer", value);
            }
        }

        public System.UInt32? LoadBalancingAlgorithm
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LoadBalancingAlgorithm", out result);
                return result;
            }

            set
            {
                this.SetProperty("LoadBalancingAlgorithm", value);
            }
        }

        public System.UInt32? Status
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Status", out result);
                return result;
            }

            set
            {
                this.SetProperty("Status", value);
            }
        }

        public System.UInt32? TeamingMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TeamingMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("TeamingMode", value);
            }
        }

        public (System.UInt32 retval, MSFTNetLbfoTeam outCmdletOutput) Rename(System.String inName, System.String inNewName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetLbfoTeam)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }
    }
}