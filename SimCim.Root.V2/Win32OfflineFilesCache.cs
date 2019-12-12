using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesCache : GenericInfrastructureObject
    {
        public Win32OfflineFilesCache()
        {
        }

        public Win32OfflineFilesCache(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Active
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Active", out result);
                return result;
            }
        }

        public System.Boolean? Enabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Enabled", out result);
                return result;
            }
        }

        public System.String Location
        {
            get
            {
                System.String result;
                this.GetProperty("Location", out result);
                return result;
            }
        }

        public (System.UInt32 retval, System.Boolean? outRebootRequired) Enable(System.Boolean? inEnable)
        {
            var parameters = new CimMethodParametersCollection();
            if (inEnable.HasValue)
                parameters.Add(CimMethodParameter.Create("Enable", inEnable.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Enable", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["RebootRequired"].Value);
        }

        public System.UInt32 RenameItem(System.String inNewPath, System.String inOriginalPath, System.Boolean? inReplaceIfExists)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("NewPath", inNewPath, inNewPath == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("OriginalPath", inOriginalPath, inOriginalPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inReplaceIfExists.HasValue)
                parameters.Add(CimMethodParameter.Create("ReplaceIfExists", inReplaceIfExists.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ReplaceIfExists", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RenameItem", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 RenameItemEx(System.String inNewPath, System.String inOriginalPath, System.Boolean? inReplaceIfExists)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("NewPath", inNewPath, inNewPath == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("OriginalPath", inOriginalPath, inOriginalPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inReplaceIfExists.HasValue)
                parameters.Add(CimMethodParameter.Create("ReplaceIfExists", inReplaceIfExists.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ReplaceIfExists", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RenameItemEx", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Synchronize(System.UInt32? inFlags, System.String[] inPaths)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFlags.HasValue)
                parameters.Add(CimMethodParameter.Create("Flags", inFlags.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Flags", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Paths", inPaths, inPaths == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Synchronize", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Pin(System.Boolean? inDeep, System.UInt32? inFlags, System.String[] inPaths)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDeep.HasValue)
                parameters.Add(CimMethodParameter.Create("Deep", inDeep.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Deep", null, CimFlags.NullValue));
            if (inFlags.HasValue)
                parameters.Add(CimMethodParameter.Create("Flags", inFlags.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Flags", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Paths", inPaths, inPaths == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Pin", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Unpin(System.Boolean? inDeep, System.UInt32? inFlags, System.String[] inPaths)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDeep.HasValue)
                parameters.Add(CimMethodParameter.Create("Deep", inDeep.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Deep", null, CimFlags.NullValue));
            if (inFlags.HasValue)
                parameters.Add(CimMethodParameter.Create("Flags", inFlags.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Flags", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Paths", inPaths, inPaths == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Unpin", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 DeleteItems(System.UInt32? inFlags, System.String[] inPaths)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFlags.HasValue)
                parameters.Add(CimMethodParameter.Create("Flags", inFlags.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Flags", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Paths", inPaths, inPaths == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DeleteItems", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Encrypt(System.Boolean? inEncrypt, System.UInt32? inFlags)
        {
            var parameters = new CimMethodParametersCollection();
            if (inEncrypt.HasValue)
                parameters.Add(CimMethodParameter.Create("Encrypt", inEncrypt.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Encrypt", null, CimFlags.NullValue));
            if (inFlags.HasValue)
                parameters.Add(CimMethodParameter.Create("Flags", inFlags.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Flags", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Encrypt", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 SuspendRoot(System.String inPath, System.Boolean? inSuspend)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inSuspend.HasValue)
                parameters.Add(CimMethodParameter.Create("Suspend", inSuspend.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Suspend", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SuspendRoot", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.Boolean? outOpenFiles) TransitionOffline(System.UInt32? inFlags, System.Boolean? inForce, System.String inPath)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFlags.HasValue)
                parameters.Add(CimMethodParameter.Create("Flags", inFlags.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Flags", null, CimFlags.NullValue));
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Force", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "TransitionOffline", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.Boolean? )result.OutParameters["OpenFiles"].Value);
        }

        public System.UInt32 TransitionOnline(System.UInt32? inFlags, System.String inPath)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFlags.HasValue)
                parameters.Add(CimMethodParameter.Create("Flags", inFlags.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Flags", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Path", inPath, inPath == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "TransitionOnline", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}