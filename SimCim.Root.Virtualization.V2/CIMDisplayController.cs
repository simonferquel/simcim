using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMDisplayController : CIMController
    {
        protected CIMDisplayController()
        {
        }

        protected CIMDisplayController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] AcceleratorCapabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("AcceleratorCapabilities", out result);
                return result;
            }

            set
            {
                this.SetProperty("AcceleratorCapabilities", value);
            }
        }

        public System.String[] CapabilityDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("CapabilityDescriptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("CapabilityDescriptions", value);
            }
        }

        public System.UInt32? MaxMemorySupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxMemorySupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxMemorySupported", value);
            }
        }

        public System.UInt32? NumberOfVideoPages
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfVideoPages", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfVideoPages", value);
            }
        }

        public System.String OtherVideoArchitecture
        {
            get
            {
                System.String result;
                this.GetProperty("OtherVideoArchitecture", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherVideoArchitecture", value);
            }
        }

        public System.String OtherVideoMemoryType
        {
            get
            {
                System.String result;
                this.GetProperty("OtherVideoMemoryType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherVideoMemoryType", value);
            }
        }

        public System.UInt16? VideoArchitecture
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VideoArchitecture", out result);
                return result;
            }

            set
            {
                this.SetProperty("VideoArchitecture", value);
            }
        }

        public System.UInt16? VideoMemoryType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VideoMemoryType", out result);
                return result;
            }

            set
            {
                this.SetProperty("VideoMemoryType", value);
            }
        }

        public System.String VideoProcessor
        {
            get
            {
                System.String result;
                this.GetProperty("VideoProcessor", out result);
                return result;
            }

            set
            {
                this.SetProperty("VideoProcessor", value);
            }
        }

        public CIMVideoHead ResolveCIMVideoHeadOnControllerDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_VideoHeadOnController", "CIM_VideoHead", "Antecedent", "Dependent");
            return instances.Select(i => (CIMVideoHead)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmVideoHead ResolveMsvmVideoHeadOnControllerDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_VideoHeadOnController", "Msvm_VideoHead", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmVideoHead)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}