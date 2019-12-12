using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ScheduledJob : CIMJob
    {
        public Win32ScheduledJob()
        {
        }

        public Win32ScheduledJob(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Command
        {
            get
            {
                System.String result;
                this.GetProperty("Command", out result);
                return result;
            }
        }

        public System.UInt32? DaysOfMonth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DaysOfMonth", out result);
                return result;
            }
        }

        public System.UInt32? DaysOfWeek
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DaysOfWeek", out result);
                return result;
            }
        }

        public System.Boolean? InteractWithDesktop
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("InteractWithDesktop", out result);
                return result;
            }
        }

        public System.UInt32? JobId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("JobId", out result);
                return result;
            }
        }

        public System.Boolean? RunRepeatedly
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RunRepeatedly", out result);
                return result;
            }
        }

        public (System.UInt32 retval, System.UInt32? outJobId) Create(System.String inCommand, System.UInt32? inDaysOfMonth, System.UInt32? inDaysOfWeek, System.Boolean? inInteractWithDesktop, System.Boolean? inRunRepeatedly, System.DateTime? inStartTime)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Command", inCommand, inCommand == null ? CimFlags.NullValue : CimFlags.None));
            if (inDaysOfMonth.HasValue)
                parameters.Add(CimMethodParameter.Create("DaysOfMonth", inDaysOfMonth.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("DaysOfMonth", null, CimFlags.NullValue));
            if (inDaysOfWeek.HasValue)
                parameters.Add(CimMethodParameter.Create("DaysOfWeek", inDaysOfWeek.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("DaysOfWeek", null, CimFlags.NullValue));
            if (inInteractWithDesktop.HasValue)
                parameters.Add(CimMethodParameter.Create("InteractWithDesktop", inInteractWithDesktop.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("InteractWithDesktop", null, CimFlags.NullValue));
            if (inRunRepeatedly.HasValue)
                parameters.Add(CimMethodParameter.Create("RunRepeatedly", inRunRepeatedly.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("RunRepeatedly", null, CimFlags.NullValue));
            if (inStartTime.HasValue)
                parameters.Add(CimMethodParameter.Create("StartTime", inStartTime.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("StartTime", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt32? )result.OutParameters["JobId"].Value);
        }

        public System.UInt32 Delete()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Delete", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}