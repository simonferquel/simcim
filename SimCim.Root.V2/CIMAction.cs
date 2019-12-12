using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMAction : GenericInfrastructureObject
    {
        protected CIMAction()
        {
        }

        protected CIMAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ActionID
        {
            get
            {
                System.String result;
                this.GetProperty("ActionID", out result);
                return result;
            }
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

        public System.String Description
        {
            get
            {
                System.String result;
                this.GetProperty("Description", out result);
                return result;
            }
        }

        public System.UInt16? Direction
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Direction", out result);
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

        public CIMCheck ResolveWin32ActionCheckCheck()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ActionCheck", "CIM_Check", "Action", "Check");
            return instances.Select(i => (CIMCheck)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SoftwareFeature ResolveWin32SoftwareFeatureActionElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SoftwareFeatureAction", "Win32_SoftwareFeature", "Action", "Element");
            return instances.Select(i => (Win32SoftwareFeature)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SoftwareElement ResolveWin32SoftwareElementActionElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SoftwareElementAction", "Win32_SoftwareElement", "Action", "Element");
            return instances.Select(i => (Win32SoftwareElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}