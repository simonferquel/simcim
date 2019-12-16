using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMJob : CIMLogicalElement
    {
        protected CIMJob()
        {
        }

        protected CIMJob(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? DeleteOnCompletion
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DeleteOnCompletion", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeleteOnCompletion", value);
            }
        }

        public System.DateTime? ElapsedTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("ElapsedTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("ElapsedTime", value);
            }
        }

        public System.UInt16? ErrorCode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ErrorCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorCode", value);
            }
        }

        public System.String ErrorDescription
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorDescription", value);
            }
        }

        public System.UInt32? JobRunTimes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("JobRunTimes", out result);
                return result;
            }

            set
            {
                this.SetProperty("JobRunTimes", value);
            }
        }

        public System.String JobStatus
        {
            get
            {
                System.String result;
                this.GetProperty("JobStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("JobStatus", value);
            }
        }

        public System.UInt16? LocalOrUtcTime
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LocalOrUtcTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalOrUtcTime", value);
            }
        }

        public System.String Notify
        {
            get
            {
                System.String result;
                this.GetProperty("Notify", out result);
                return result;
            }

            set
            {
                this.SetProperty("Notify", value);
            }
        }

        public System.String OtherRecoveryAction
        {
            get
            {
                System.String result;
                this.GetProperty("OtherRecoveryAction", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherRecoveryAction", value);
            }
        }

        public System.String Owner
        {
            get
            {
                System.String result;
                this.GetProperty("Owner", out result);
                return result;
            }

            set
            {
                this.SetProperty("Owner", value);
            }
        }

        public System.UInt16? PercentComplete
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PercentComplete", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentComplete", value);
            }
        }

        public System.UInt32? Priority
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Priority", out result);
                return result;
            }

            set
            {
                this.SetProperty("Priority", value);
            }
        }

        public System.UInt16? RecoveryAction
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RecoveryAction", out result);
                return result;
            }

            set
            {
                this.SetProperty("RecoveryAction", value);
            }
        }

        public System.SByte? RunDay
        {
            get
            {
                System.SByte? result;
                this.GetProperty("RunDay", out result);
                return result;
            }

            set
            {
                this.SetProperty("RunDay", value);
            }
        }

        public System.SByte? RunDayOfWeek
        {
            get
            {
                System.SByte? result;
                this.GetProperty("RunDayOfWeek", out result);
                return result;
            }

            set
            {
                this.SetProperty("RunDayOfWeek", value);
            }
        }

        public System.Byte? RunMonth
        {
            get
            {
                System.Byte? result;
                this.GetProperty("RunMonth", out result);
                return result;
            }

            set
            {
                this.SetProperty("RunMonth", value);
            }
        }

        public System.DateTime? RunStartInterval
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("RunStartInterval", out result);
                return result;
            }

            set
            {
                this.SetProperty("RunStartInterval", value);
            }
        }

        public System.DateTime? ScheduledStartTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("ScheduledStartTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("ScheduledStartTime", value);
            }
        }

        public System.DateTime? StartTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("StartTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartTime", value);
            }
        }

        public System.DateTime? TimeSubmitted
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeSubmitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeSubmitted", value);
            }
        }

        public System.DateTime? UntilTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("UntilTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("UntilTime", value);
            }
        }

        public System.UInt32 KillJob(System.Boolean? inDeleteOnKill)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDeleteOnKill.HasValue)
                parameters.Add(CimMethodParameter.Create("DeleteOnKill", inDeleteOnKill.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("DeleteOnKill", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "KillJob", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public CIMManagedElement ResolveCIMAffectedJobElementAffectedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_AffectedJobElement", "CIM_ManagedElement", "AffectingElement", "AffectedElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMManagedElement> ResolveMsvmAffectedJobElementAffectedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_AffectedJobElement", "CIM_ManagedElement", "AffectingElement", "AffectedElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMManagedElement ResolveCIMOwningJobElementOwningElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_OwningJobElement", "CIM_ManagedElement", "OwnedElement", "OwningElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveMsvmOwningJobElementOwningElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_OwningJobElement", "CIM_ManagedElement", "OwnedElement", "OwningElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}