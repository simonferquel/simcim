﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoftwareFeature : CIMSoftwareFeature
    {
        public Win32SoftwareFeature()
        {
        }

        public Win32SoftwareFeature(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Accesses
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Accesses", out result);
                return result;
            }
        }

        public System.UInt16? Attributes
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Attributes", out result);
                return result;
            }
        }

        public System.Int16? InstallState
        {
            get
            {
                System.Int16? result;
                this.GetProperty("InstallState", out result);
                return result;
            }
        }

        public System.DateTime? LastUse
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastUse", out result);
                return result;
            }
        }

        public System.UInt32 Reinstall(System.UInt16? inReinstallMode)
        {
            var parameters = new CimMethodParametersCollection();
            if (inReinstallMode.HasValue)
                parameters.Add(CimMethodParameter.Create("ReinstallMode", inReinstallMode.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reinstall", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Configure(System.UInt16? inInstallState)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInstallState.HasValue)
                parameters.Add(CimMethodParameter.Create("InstallState", inInstallState.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Configure", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}