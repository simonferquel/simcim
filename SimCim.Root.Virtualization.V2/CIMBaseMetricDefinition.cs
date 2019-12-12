using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMBaseMetricDefinition : CIMManagedElement
    {
        protected CIMBaseMetricDefinition()
        {
        }

        protected CIMBaseMetricDefinition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] BreakdownDimensions
        {
            get
            {
                System.String[] result;
                this.GetProperty("BreakdownDimensions", out result);
                return result;
            }

            set
            {
                this.SetProperty("BreakdownDimensions", value);
            }
        }

        public System.UInt16? Calculable
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Calculable", out result);
                return result;
            }

            set
            {
                this.SetProperty("Calculable", value);
            }
        }

        public System.UInt16? ChangeType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ChangeType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ChangeType", value);
            }
        }

        public System.UInt16? DataType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DataType", out result);
                return result;
            }

            set
            {
                this.SetProperty("DataType", value);
            }
        }

        public System.UInt16? GatheringType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("GatheringType", out result);
                return result;
            }

            set
            {
                this.SetProperty("GatheringType", value);
            }
        }

        public System.String Id
        {
            get
            {
                System.String result;
                this.GetProperty("Id", out result);
                return result;
            }

            set
            {
                this.SetProperty("Id", value);
            }
        }

        public System.Boolean? IsContinuous
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsContinuous", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsContinuous", value);
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

            set
            {
                this.SetProperty("Name", value);
            }
        }

        public System.String ProgrammaticUnits
        {
            get
            {
                System.String result;
                this.GetProperty("ProgrammaticUnits", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProgrammaticUnits", value);
            }
        }

        public System.UInt16? TimeScope
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TimeScope", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeScope", value);
            }
        }

        public System.String Units
        {
            get
            {
                System.String result;
                this.GetProperty("Units", out result);
                return result;
            }

            set
            {
                this.SetProperty("Units", value);
            }
        }

        public CIMManagedElement ResolveCIMMetricDefForMEAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_MetricDefForME", "CIM_ManagedElement", "Dependent", "Antecedent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveMsvmMetricDefForMEAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_MetricDefForME", "CIM_ManagedElement", "Dependent", "Antecedent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMBaseMetricValue ResolveCIMMetricInstanceDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_MetricInstance", "CIM_BaseMetricValue", "Antecedent", "Dependent");
            return instances.Select(i => (CIMBaseMetricValue)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMBaseMetricValue ResolveMsvmMetricInstanceDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_MetricInstance", "CIM_BaseMetricValue", "Antecedent", "Dependent");
            return instances.Select(i => (CIMBaseMetricValue)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}