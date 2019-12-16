using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetSwitchTeam : MSFTNetImPlatTeam
    {
        public MSFTNetSwitchTeam()
        {
        }

        public MSFTNetSwitchTeam(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 Create(System.String inName, System.String[] inTeamMembers)
        {
            var parameters = new CimMethodParametersCollection();
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inTeamMembers != null)
                parameters.Add(CimMethodParameter.Create("TeamMembers", inTeamMembers, CimType.StringArray, inTeamMembers == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Rename(System.String inName, System.String inNewName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 AddMember(System.String inName, System.String inTeam)
        {
            var parameters = new CimMethodParametersCollection();
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inTeam != null)
                parameters.Add(CimMethodParameter.Create("Team", inTeam, CimType.String, inTeam == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddMember", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RemoveMember(System.String inName, System.String inTeam)
        {
            var parameters = new CimMethodParametersCollection();
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inTeam != null)
                parameters.Add(CimMethodParameter.Create("Team", inTeam, CimType.String, inTeam == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveMember", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}