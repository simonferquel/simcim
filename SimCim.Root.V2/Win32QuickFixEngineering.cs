using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32QuickFixEngineering : CIMLogicalElement
    {
        public Win32QuickFixEngineering()
        {
        }

        public Win32QuickFixEngineering(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.String FixComments
        {
            get
            {
                System.String result;
                this.GetProperty("FixComments", out result);
                return result;
            }
        }

        public System.String HotFixID
        {
            get
            {
                System.String result;
                this.GetProperty("HotFixID", out result);
                return result;
            }
        }

        public System.String InstalledBy
        {
            get
            {
                System.String result;
                this.GetProperty("InstalledBy", out result);
                return result;
            }
        }

        public System.String InstalledOn
        {
            get
            {
                System.String result;
                this.GetProperty("InstalledOn", out result);
                return result;
            }
        }

        public System.String ServicePackInEffect
        {
            get
            {
                System.String result;
                this.GetProperty("ServicePackInEffect", out result);
                return result;
            }
        }

        public Win32OperatingSystem ResolveWin32OperatingSystemQFEAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_OperatingSystemQFE", "Win32_OperatingSystem", "Dependent", "Antecedent");
            return instances.Select(i => (Win32OperatingSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}