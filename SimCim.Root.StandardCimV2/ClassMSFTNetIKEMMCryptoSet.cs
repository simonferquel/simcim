﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetIKEMMCryptoSet : MSFTNetIKECryptoSet
    {
        public MSFTNetIKEMMCryptoSet()
        {
        }

        public MSFTNetIKEMMCryptoSet(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ForceDiffieHellman
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ForceDiffieHellman", out result);
                return result;
            }

            set
            {
                this.SetProperty("ForceDiffieHellman", value);
            }
        }

        public System.UInt32? MaxLifetimeMinutes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxLifetimeMinutes", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxLifetimeMinutes", value);
            }
        }

        public System.UInt32? MaxLifetimeSessions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxLifetimeSessions", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxLifetimeSessions", value);
            }
        }

        public System.UInt32 Rename(System.String inNewName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 CloneObject(System.String inNewGPOSession, System.String inNewID, System.String inNewName, System.String inNewPolicyStore)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNewGPOSession != null)
                parameters.Add(CimMethodParameter.Create("NewGPOSession", inNewGPOSession, CimType.String, inNewGPOSession == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewID != null)
                parameters.Add(CimMethodParameter.Create("NewID", inNewID, CimType.String, inNewID == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewName != null)
                parameters.Add(CimMethodParameter.Create("NewName", inNewName, CimType.String, inNewName == null ? CimFlags.NullValue : CimFlags.None));
            if (inNewPolicyStore != null)
                parameters.Add(CimMethodParameter.Create("NewPolicyStore", inNewPolicyStore, CimType.String, inNewPolicyStore == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CloneObject", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}