using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ShadowStorage : GenericInfrastructureObject
    {
        public Win32ShadowStorage()
        {
        }

        public Win32ShadowStorage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AllocatedSpace
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AllocatedSpace", out result);
                return result;
            }
        }

        public Win32Volume DiffVolume
        {
            get
            {
                Win32Volume result;
                this.GetInfrastructureObjectProperty("DiffVolume", out result);
                return result;
            }
        }

        public System.UInt64? MaxSpace
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxSpace", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxSpace", value);
            }
        }

        public System.UInt64? UsedSpace
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UsedSpace", out result);
                return result;
            }
        }

        public Win32Volume Volume
        {
            get
            {
                Win32Volume result;
                this.GetInfrastructureObjectProperty("Volume", out result);
                return result;
            }
        }

        public System.UInt32 Create(System.String inDiffVolume, System.UInt64? inMaxSpace, System.String inVolume)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDiffVolume != null)
                parameters.Add(CimMethodParameter.Create("DiffVolume", inDiffVolume, CimType.String, inDiffVolume == null ? CimFlags.NullValue : CimFlags.None));
            if (inMaxSpace.HasValue)
                parameters.Add(CimMethodParameter.Create("MaxSpace", inMaxSpace.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("MaxSpace", null, CimFlags.NullValue));
            if (inVolume != null)
                parameters.Add(CimMethodParameter.Create("Volume", inVolume, CimType.String, inVolume == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}