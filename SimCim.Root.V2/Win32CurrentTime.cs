using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32CurrentTime : GenericInfrastructureObject
    {
        protected Win32CurrentTime()
        {
        }

        protected Win32CurrentTime(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Day
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Day", out result);
                return result;
            }
        }

        public System.UInt32? DayOfWeek
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DayOfWeek", out result);
                return result;
            }
        }

        public System.UInt32? Hour
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Hour", out result);
                return result;
            }
        }

        public System.UInt32? Milliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Milliseconds", out result);
                return result;
            }
        }

        public System.UInt32? Minute
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Minute", out result);
                return result;
            }
        }

        public System.UInt32? Month
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Month", out result);
                return result;
            }
        }

        public System.UInt32? Quarter
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Quarter", out result);
                return result;
            }
        }

        public System.UInt32? Second
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Second", out result);
                return result;
            }
        }

        public System.UInt32? WeekInMonth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WeekInMonth", out result);
                return result;
            }
        }

        public System.UInt32? Year
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Year", out result);
                return result;
            }
        }
    }
}