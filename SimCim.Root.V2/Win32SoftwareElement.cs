using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoftwareElement : CIMSoftwareElement
    {
        public Win32SoftwareElement()
        {
        }

        public Win32SoftwareElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.String Path
        {
            get
            {
                System.String result;
                this.GetProperty("Path", out result);
                return result;
            }
        }

        public Win32SoftwareFeature ResolveWin32SoftwareFeatureSoftwareElementsGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SoftwareFeatureSoftwareElements", "Win32_SoftwareFeature", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32SoftwareFeature)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32MSIResource ResolveWin32SoftwareElementResourceSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SoftwareElementResource", "Win32_MSIResource", "Element", "Setting");
            return instances.Select(i => (Win32MSIResource)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMComputerSystem ResolveWin32InstalledSoftwareElementSystem()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_InstalledSoftwareElement", "CIM_ComputerSystem", "Software", "System");
            return instances.Select(i => (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMCheck> ResolveWin32SoftwareElementCheckCheck()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SoftwareElementCheck", "CIM_Check", "Element", "Check");
            return instances.Select(i => (CIMCheck)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<Win32ODBCDriverSpecification> ResolveWin32ODBCDriverSoftwareElementCheck()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ODBCDriverSoftwareElement", "Win32_ODBCDriverSpecification", "Element", "Check");
            return instances.Select(i => (Win32ODBCDriverSpecification)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMAction> ResolveWin32SoftwareElementActionAction()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SoftwareElementAction", "CIM_Action", "Element", "Action");
            return instances.Select(i => (CIMAction)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}