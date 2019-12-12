using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMBIOSElement : CIMSoftwareElement
    {
        protected CIMBIOSElement()
        {
        }

        protected CIMBIOSElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CurrentLanguage
        {
            get
            {
                System.String result;
                this.GetProperty("CurrentLanguage", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentLanguage", value);
            }
        }

        public System.String[] ListOfLanguages
        {
            get
            {
                System.String[] result;
                this.GetProperty("ListOfLanguages", out result);
                return result;
            }

            set
            {
                this.SetProperty("ListOfLanguages", value);
            }
        }

        public System.UInt64? LoadedEndingAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LoadedEndingAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("LoadedEndingAddress", value);
            }
        }

        public System.UInt64? LoadedStartingAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LoadedStartingAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("LoadedStartingAddress", value);
            }
        }

        public System.String LoadUtilityInformation
        {
            get
            {
                System.String result;
                this.GetProperty("LoadUtilityInformation", out result);
                return result;
            }

            set
            {
                this.SetProperty("LoadUtilityInformation", value);
            }
        }

        public System.Boolean? PrimaryBIOS
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PrimaryBIOS", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrimaryBIOS", value);
            }
        }

        public System.String[] RegistryURIs
        {
            get
            {
                System.String[] result;
                this.GetProperty("RegistryURIs", out result);
                return result;
            }

            set
            {
                this.SetProperty("RegistryURIs", value);
            }
        }

        public System.DateTime? ReleaseDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("ReleaseDate", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReleaseDate", value);
            }
        }

        public CIMComputerSystem ResolveCIMSystemBIOSGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SystemBIOS", "CIM_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}