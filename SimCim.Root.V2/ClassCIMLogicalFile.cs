using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMLogicalFile : CIMLogicalElement
    {
        protected CIMLogicalFile()
        {
        }

        protected CIMLogicalFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AccessMask
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AccessMask", out result);
                return result;
            }
        }

        public System.Boolean? Archive
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Archive", out result);
                return result;
            }
        }

        public System.Boolean? Compressed
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Compressed", out result);
                return result;
            }
        }

        public System.String CompressionMethod
        {
            get
            {
                System.String result;
                this.GetProperty("CompressionMethod", out result);
                return result;
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
        }

        public System.DateTime? CreationDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("CreationDate", out result);
                return result;
            }
        }

        public System.String CSCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CSCreationClassName", out result);
                return result;
            }
        }

        public System.String CSName
        {
            get
            {
                System.String result;
                this.GetProperty("CSName", out result);
                return result;
            }
        }

        public System.String Drive
        {
            get
            {
                System.String result;
                this.GetProperty("Drive", out result);
                return result;
            }
        }

        public System.String EightDotThreeFileName
        {
            get
            {
                System.String result;
                this.GetProperty("EightDotThreeFileName", out result);
                return result;
            }
        }

        public System.Boolean? Encrypted
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Encrypted", out result);
                return result;
            }
        }

        public System.String EncryptionMethod
        {
            get
            {
                System.String result;
                this.GetProperty("EncryptionMethod", out result);
                return result;
            }
        }

        public System.String Extension
        {
            get
            {
                System.String result;
                this.GetProperty("Extension", out result);
                return result;
            }
        }

        public System.String FileName
        {
            get
            {
                System.String result;
                this.GetProperty("FileName", out result);
                return result;
            }
        }

        public System.UInt64? FileSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FileSize", out result);
                return result;
            }
        }

        public System.String FileType
        {
            get
            {
                System.String result;
                this.GetProperty("FileType", out result);
                return result;
            }
        }

        public System.String FSCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("FSCreationClassName", out result);
                return result;
            }
        }

        public System.String FSName
        {
            get
            {
                System.String result;
                this.GetProperty("FSName", out result);
                return result;
            }
        }

        public System.Boolean? Hidden
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Hidden", out result);
                return result;
            }
        }

        public System.UInt64? InUseCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InUseCount", out result);
                return result;
            }
        }

        public System.DateTime? LastAccessed
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastAccessed", out result);
                return result;
            }
        }

        public System.DateTime? LastModified
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastModified", out result);
                return result;
            }
        }

        public System.String Path
        {
            get
            {
                System.String result;
                this.GetProperty("Path", out result);
                return result;
            }
        }

        public System.Boolean? Readable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Readable", out result);
                return result;
            }
        }

        public System.Boolean? System
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("System", out result);
                return result;
            }
        }

        public System.Boolean? Writeable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Writeable", out result);
                return result;
            }
        }

        public System.UInt32 TakeOwnerShip()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "TakeOwnerShip", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ChangeSecurityPermissions(System.UInt32? inOption, Win32SecurityDescriptor inSecurityDescriptor)
        {
            var parameters = new CimMethodParametersCollection();
            if (inOption.HasValue)
                parameters.Add(CimMethodParameter.Create("Option", inOption.Value, CimFlags.None));
            if (inSecurityDescriptor != null)
                parameters.Add(CimMethodParameter.Create("SecurityDescriptor", inSecurityDescriptor.AsCimInstance(), CimType.Instance, inSecurityDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ChangeSecurityPermissions", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Copy(System.String inFileName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFileName != null)
                parameters.Add(CimMethodParameter.Create("FileName", inFileName, CimType.String, inFileName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Copy", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Rename(System.String inFileName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFileName != null)
                parameters.Add(CimMethodParameter.Create("FileName", inFileName, CimType.String, inFileName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Delete()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Delete", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Compress()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Compress", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Uncompress()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Uncompress", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.String outStopFileName) TakeOwnerShipEx(System.Boolean? inRecursive, System.String inStartFileName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inRecursive.HasValue)
                parameters.Add(CimMethodParameter.Create("Recursive", inRecursive.Value, CimFlags.None));
            if (inStartFileName != null)
                parameters.Add(CimMethodParameter.Create("StartFileName", inStartFileName, CimType.String, inStartFileName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "TakeOwnerShipEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["StopFileName"].Value);
        }

        public (System.UInt32 retval, System.String outStopFileName) ChangeSecurityPermissionsEx(System.UInt32? inOption, System.Boolean? inRecursive, Win32SecurityDescriptor inSecurityDescriptor, System.String inStartFileName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inOption.HasValue)
                parameters.Add(CimMethodParameter.Create("Option", inOption.Value, CimFlags.None));
            if (inRecursive.HasValue)
                parameters.Add(CimMethodParameter.Create("Recursive", inRecursive.Value, CimFlags.None));
            if (inSecurityDescriptor != null)
                parameters.Add(CimMethodParameter.Create("SecurityDescriptor", inSecurityDescriptor.AsCimInstance(), CimType.Instance, inSecurityDescriptor == null ? CimFlags.NullValue : CimFlags.None));
            if (inStartFileName != null)
                parameters.Add(CimMethodParameter.Create("StartFileName", inStartFileName, CimType.String, inStartFileName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ChangeSecurityPermissionsEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["StopFileName"].Value);
        }

        public (System.UInt32 retval, System.String outStopFileName) CopyEx(System.String inFileName, System.Boolean? inRecursive, System.String inStartFileName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inFileName != null)
                parameters.Add(CimMethodParameter.Create("FileName", inFileName, CimType.String, inFileName == null ? CimFlags.NullValue : CimFlags.None));
            if (inRecursive.HasValue)
                parameters.Add(CimMethodParameter.Create("Recursive", inRecursive.Value, CimFlags.None));
            if (inStartFileName != null)
                parameters.Add(CimMethodParameter.Create("StartFileName", inStartFileName, CimType.String, inStartFileName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CopyEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["StopFileName"].Value);
        }

        public (System.UInt32 retval, System.String outStopFileName) DeleteEx(System.String inStartFileName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inStartFileName != null)
                parameters.Add(CimMethodParameter.Create("StartFileName", inStartFileName, CimType.String, inStartFileName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DeleteEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["StopFileName"].Value);
        }

        public (System.UInt32 retval, System.String outStopFileName) CompressEx(System.Boolean? inRecursive, System.String inStartFileName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inRecursive.HasValue)
                parameters.Add(CimMethodParameter.Create("Recursive", inRecursive.Value, CimFlags.None));
            if (inStartFileName != null)
                parameters.Add(CimMethodParameter.Create("StartFileName", inStartFileName, CimType.String, inStartFileName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CompressEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["StopFileName"].Value);
        }

        public (System.UInt32 retval, System.String outStopFileName) UncompressEx(System.Boolean? inRecursive, System.String inStartFileName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inRecursive.HasValue)
                parameters.Add(CimMethodParameter.Create("Recursive", inRecursive.Value, CimFlags.None));
            if (inStartFileName != null)
                parameters.Add(CimMethodParameter.Create("StartFileName", inStartFileName, CimType.String, inStartFileName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "UncompressEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["StopFileName"].Value);
        }

        public System.Boolean GetEffectivePermission(System.UInt32? inPermissions)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPermissions.HasValue)
                parameters.Add(CimMethodParameter.Create("Permissions", inPermissions.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetEffectivePermission", parameters);
            return (System.Boolean)result.ReturnValue.Value;
        }
    }
}