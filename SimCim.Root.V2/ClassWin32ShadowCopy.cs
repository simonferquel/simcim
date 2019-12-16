using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ShadowCopy : CIMLogicalElement
    {
        public Win32ShadowCopy()
        {
        }

        public Win32ShadowCopy(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ClientAccessible
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ClientAccessible", out result);
                return result;
            }
        }

        public System.UInt32? Count
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Count", out result);
                return result;
            }
        }

        public System.String DeviceObject
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceObject", out result);
                return result;
            }
        }

        public System.Boolean? Differential
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Differential", out result);
                return result;
            }
        }

        public System.Boolean? ExposedLocally
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ExposedLocally", out result);
                return result;
            }
        }

        public System.String ExposedName
        {
            get
            {
                System.String result;
                this.GetProperty("ExposedName", out result);
                return result;
            }
        }

        public System.String ExposedPath
        {
            get
            {
                System.String result;
                this.GetProperty("ExposedPath", out result);
                return result;
            }
        }

        public System.Boolean? ExposedRemotely
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ExposedRemotely", out result);
                return result;
            }
        }

        public System.Boolean? HardwareAssisted
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HardwareAssisted", out result);
                return result;
            }
        }

        public System.String ID
        {
            get
            {
                System.String result;
                this.GetProperty("ID", out result);
                return result;
            }
        }

        public System.Boolean? Imported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Imported", out result);
                return result;
            }
        }

        public System.Boolean? NoAutoRelease
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NoAutoRelease", out result);
                return result;
            }
        }

        public System.Boolean? NotSurfaced
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NotSurfaced", out result);
                return result;
            }
        }

        public System.Boolean? NoWriters
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NoWriters", out result);
                return result;
            }
        }

        public System.String OriginatingMachine
        {
            get
            {
                System.String result;
                this.GetProperty("OriginatingMachine", out result);
                return result;
            }
        }

        public System.Boolean? Persistent
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Persistent", out result);
                return result;
            }
        }

        public System.Boolean? Plex
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Plex", out result);
                return result;
            }
        }

        public System.String ProviderID
        {
            get
            {
                System.String result;
                this.GetProperty("ProviderID", out result);
                return result;
            }
        }

        public System.String ServiceMachine
        {
            get
            {
                System.String result;
                this.GetProperty("ServiceMachine", out result);
                return result;
            }
        }

        public System.String SetID
        {
            get
            {
                System.String result;
                this.GetProperty("SetID", out result);
                return result;
            }
        }

        public System.UInt32? State
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("State", out result);
                return result;
            }
        }

        public System.Boolean? Transportable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Transportable", out result);
                return result;
            }
        }

        public System.String VolumeName
        {
            get
            {
                System.String result;
                this.GetProperty("VolumeName", out result);
                return result;
            }
        }

        public (System.UInt32 retval, System.String outShadowID) Create(System.String inContext, System.String inVolume)
        {
            var parameters = new CimMethodParametersCollection();
            if (inContext != null)
                parameters.Add(CimMethodParameter.Create("Context", inContext, CimType.String, inContext == null ? CimFlags.NullValue : CimFlags.None));
            if (inVolume != null)
                parameters.Add(CimMethodParameter.Create("Volume", inVolume, CimType.String, inVolume == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["ShadowID"].Value);
        }

        public System.UInt32 Revert(System.Boolean? inForceDismount)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForceDismount.HasValue)
                parameters.Add(CimMethodParameter.Create("ForceDismount", inForceDismount.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Revert", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}