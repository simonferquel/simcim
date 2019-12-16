using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCheck : GenericInfrastructureObject
    {
        protected CIMCheck()
        {
        }

        protected CIMCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Caption
        {
            get
            {
                System.String result;
                this.GetProperty("Caption", out result);
                return result;
            }
        }

        public System.String CheckID
        {
            get
            {
                System.String result;
                this.GetProperty("CheckID", out result);
                return result;
            }
        }

        public System.Boolean? CheckMode
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CheckMode", out result);
                return result;
            }
        }

        public System.String Description
        {
            get
            {
                System.String result;
                this.GetProperty("Description", out result);
                return result;
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.String SoftwareElementID
        {
            get
            {
                System.String result;
                this.GetProperty("SoftwareElementID", out result);
                return result;
            }
        }

        public System.UInt16? SoftwareElementState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SoftwareElementState", out result);
                return result;
            }
        }

        public System.UInt16? TargetOperatingSystem
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TargetOperatingSystem", out result);
                return result;
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }

        public System.UInt32 Invoke()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Invoke", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public CIMAction ResolveWin32ActionCheckAction()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ActionCheck", "CIM_Action", "Check", "Action");
            return instances.Select(i => (CIMAction)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SoftwareFeature ResolveWin32SoftwareFeatureCheckElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SoftwareFeatureCheck", "Win32_SoftwareFeature", "Check", "Element");
            return instances.Select(i => (Win32SoftwareFeature)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32SoftwareElement> ResolveWin32SoftwareElementCheckElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SoftwareElementCheck", "Win32_SoftwareElement", "Check", "Element");
            return instances.Select(i => (Win32SoftwareElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32Product ResolveWin32ProductCheckProduct()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ProductCheck", "Win32_Product", "Check", "Product");
            return instances.Select(i => (Win32Product)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMCheck ResolveWin32CheckCheckLocation()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_CheckCheck", "CIM_Check", "Check", "Location");
            return instances.Select(i => (CIMCheck)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMCheck ResolveWin32CheckCheckCheck()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_CheckCheck", "CIM_Check", "Location", "Check");
            return instances.Select(i => (CIMCheck)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}