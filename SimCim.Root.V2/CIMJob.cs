using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMJob : CIMLogicalElement
    {
        protected CIMJob()
        {
        }

        protected CIMJob(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? ElapsedTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("ElapsedTime", out result);
                return result;
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
        }

        public System.String Notify
        {
            get
            {
                System.String result;
                this.GetProperty("Notify", out result);
                return result;
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
        }

        public System.UInt32? Priority
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Priority", out result);
                return result;
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
        }

        public System.DateTime? TimeSubmitted
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeSubmitted", out result);
                return result;
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
        }
    }
}