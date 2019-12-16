using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Product : CIMProduct
    {
        public Win32Product()
        {
        }

        public Win32Product(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AssignmentType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AssignmentType", out result);
                return result;
            }
        }

        public System.String HelpLink
        {
            get
            {
                System.String result;
                this.GetProperty("HelpLink", out result);
                return result;
            }
        }

        public System.String HelpTelephone
        {
            get
            {
                System.String result;
                this.GetProperty("HelpTelephone", out result);
                return result;
            }
        }

        public System.String InstallDate
        {
            get
            {
                System.String result;
                this.GetProperty("InstallDate", out result);
                return result;
            }
        }

        public System.DateTime? InstallDate2
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("InstallDate2", out result);
                return result;
            }
        }

        public System.String InstallLocation
        {
            get
            {
                System.String result;
                this.GetProperty("InstallLocation", out result);
                return result;
            }
        }

        public System.String InstallSource
        {
            get
            {
                System.String result;
                this.GetProperty("InstallSource", out result);
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

        public System.String Language
        {
            get
            {
                System.String result;
                this.GetProperty("Language", out result);
                return result;
            }
        }

        public System.String LocalPackage
        {
            get
            {
                System.String result;
                this.GetProperty("LocalPackage", out result);
                return result;
            }
        }

        public System.String PackageCache
        {
            get
            {
                System.String result;
                this.GetProperty("PackageCache", out result);
                return result;
            }
        }

        public System.String PackageCode
        {
            get
            {
                System.String result;
                this.GetProperty("PackageCode", out result);
                return result;
            }
        }

        public System.String PackageName
        {
            get
            {
                System.String result;
                this.GetProperty("PackageName", out result);
                return result;
            }
        }

        public System.String ProductID
        {
            get
            {
                System.String result;
                this.GetProperty("ProductID", out result);
                return result;
            }
        }

        public System.String RegCompany
        {
            get
            {
                System.String result;
                this.GetProperty("RegCompany", out result);
                return result;
            }
        }

        public System.String RegOwner
        {
            get
            {
                System.String result;
                this.GetProperty("RegOwner", out result);
                return result;
            }
        }

        public System.String Transforms
        {
            get
            {
                System.String result;
                this.GetProperty("Transforms", out result);
                return result;
            }
        }

        public System.String URLInfoAbout
        {
            get
            {
                System.String result;
                this.GetProperty("URLInfoAbout", out result);
                return result;
            }
        }

        public System.String URLUpdateInfo
        {
            get
            {
                System.String result;
                this.GetProperty("URLUpdateInfo", out result);
                return result;
            }
        }

        public System.UInt32? WordCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WordCount", out result);
                return result;
            }
        }

        public System.UInt32 Install(System.Boolean? inAllUsers, System.String inOptions, System.String inPackageLocation)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAllUsers.HasValue)
                parameters.Add(CimMethodParameter.Create("AllUsers", inAllUsers.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("AllUsers", null, CimFlags.NullValue));
            if (inOptions != null)
                parameters.Add(CimMethodParameter.Create("Options", inOptions, CimType.String, inOptions == null ? CimFlags.NullValue : CimFlags.None));
            if (inPackageLocation != null)
                parameters.Add(CimMethodParameter.Create("PackageLocation", inPackageLocation, CimType.String, inPackageLocation == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Install", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Admin(System.String inOptions, System.String inPackageLocation, System.String inTargetLocation)
        {
            var parameters = new CimMethodParametersCollection();
            if (inOptions != null)
                parameters.Add(CimMethodParameter.Create("Options", inOptions, CimType.String, inOptions == null ? CimFlags.NullValue : CimFlags.None));
            if (inPackageLocation != null)
                parameters.Add(CimMethodParameter.Create("PackageLocation", inPackageLocation, CimType.String, inPackageLocation == null ? CimFlags.NullValue : CimFlags.None));
            if (inTargetLocation != null)
                parameters.Add(CimMethodParameter.Create("TargetLocation", inTargetLocation, CimType.String, inTargetLocation == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Admin", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Advertise(System.Boolean? inAllUsers, System.String inOptions, System.String inPackageLocation)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAllUsers.HasValue)
                parameters.Add(CimMethodParameter.Create("AllUsers", inAllUsers.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("AllUsers", null, CimFlags.NullValue));
            if (inOptions != null)
                parameters.Add(CimMethodParameter.Create("Options", inOptions, CimType.String, inOptions == null ? CimFlags.NullValue : CimFlags.None));
            if (inPackageLocation != null)
                parameters.Add(CimMethodParameter.Create("PackageLocation", inPackageLocation, CimType.String, inPackageLocation == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Advertise", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Reinstall(System.UInt16? inReinstallMode)
        {
            var parameters = new CimMethodParametersCollection();
            if (inReinstallMode.HasValue)
                parameters.Add(CimMethodParameter.Create("ReinstallMode", inReinstallMode.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ReinstallMode", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reinstall", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Upgrade(System.String inOptions, System.String inPackageLocation)
        {
            var parameters = new CimMethodParametersCollection();
            if (inOptions != null)
                parameters.Add(CimMethodParameter.Create("Options", inOptions, CimType.String, inOptions == null ? CimFlags.NullValue : CimFlags.None));
            if (inPackageLocation != null)
                parameters.Add(CimMethodParameter.Create("PackageLocation", inPackageLocation, CimType.String, inPackageLocation == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Upgrade", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Configure(System.UInt16? inInstallLevel, System.UInt16? inInstallState, System.String inOptions)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInstallLevel.HasValue)
                parameters.Add(CimMethodParameter.Create("InstallLevel", inInstallLevel.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("InstallLevel", null, CimFlags.NullValue));
            if (inInstallState.HasValue)
                parameters.Add(CimMethodParameter.Create("InstallState", inInstallState.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("InstallState", null, CimFlags.NullValue));
            if (inOptions != null)
                parameters.Add(CimMethodParameter.Create("Options", inOptions, CimType.String, inOptions == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Configure", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Uninstall()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Uninstall", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public Win32MSIResource ResolveWin32ProductResourceResource()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ProductResource", "Win32_MSIResource", "Product", "Resource");
            return instances.Select(i => (Win32MSIResource)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32SoftwareFeature> ResolveWin32ProductSoftwareFeaturesComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ProductSoftwareFeatures", "Win32_SoftwareFeature", "Product", "Component");
            return instances.Select(i => (Win32SoftwareFeature)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMCheck ResolveWin32ProductCheckCheck()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ProductCheck", "CIM_Check", "Product", "Check");
            return instances.Select(i => (CIMCheck)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}