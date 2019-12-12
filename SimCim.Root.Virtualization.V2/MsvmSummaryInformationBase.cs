using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class MsvmSummaryInformationBase : CIMView
    {
        protected MsvmSummaryInformationBase()
        {
        }

        protected MsvmSummaryInformationBase(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? CreationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("CreationTime", out result);
                return result;
            }
        }

        public System.UInt16? EnabledState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnabledState", out result);
                return result;
            }
        }

        public System.UInt16? EnhancedSessionModeState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnhancedSessionModeState", out result);
                return result;
            }
        }

        public System.UInt16? HealthState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HealthState", out result);
                return result;
            }
        }

        public System.String HostComputerSystemName
        {
            get
            {
                System.String result;
                this.GetProperty("HostComputerSystemName", out result);
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

        public System.String Notes
        {
            get
            {
                System.String result;
                this.GetProperty("Notes", out result);
                return result;
            }
        }

        public System.UInt16? NumberOfProcessors
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NumberOfProcessors", out result);
                return result;
            }
        }

        public System.UInt16[] OperationalStatus
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("OperationalStatus", out result);
                return result;
            }
        }

        public System.String OtherEnabledState
        {
            get
            {
                System.String result;
                this.GetProperty("OtherEnabledState", out result);
                return result;
            }
        }

        public System.String[] StatusDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("StatusDescriptions", out result);
                return result;
            }
        }

        public System.UInt64? UpTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UpTime", out result);
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

        public System.String[] VirtualSwitchNames
        {
            get
            {
                System.String[] result;
                this.GetProperty("VirtualSwitchNames", out result);
                return result;
            }
        }

        public System.String VirtualSystemSubType
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualSystemSubType", out result);
                return result;
            }
        }

        public CIMComputerSystem ResolveMsvmComputerSystemSummaryInformationAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ComputerSystemSummaryInformation", "CIM_ComputerSystem", "Dependent", "Antecedent");
            return instances.Select(i => (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}