using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32TimeZone : CIMSetting
    {
        public Win32TimeZone()
        {
        }

        public Win32TimeZone(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Int32? Bias
        {
            get
            {
                System.Int32? result;
                this.GetProperty("Bias", out result);
                return result;
            }
        }

        public System.Int32? DaylightBias
        {
            get
            {
                System.Int32? result;
                this.GetProperty("DaylightBias", out result);
                return result;
            }
        }

        public System.UInt32? DaylightDay
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DaylightDay", out result);
                return result;
            }
        }

        public System.Byte? DaylightDayOfWeek
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DaylightDayOfWeek", out result);
                return result;
            }
        }

        public System.UInt32? DaylightHour
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DaylightHour", out result);
                return result;
            }
        }

        public System.UInt32? DaylightMillisecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DaylightMillisecond", out result);
                return result;
            }
        }

        public System.UInt32? DaylightMinute
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DaylightMinute", out result);
                return result;
            }
        }

        public System.UInt32? DaylightMonth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DaylightMonth", out result);
                return result;
            }
        }

        public System.String DaylightName
        {
            get
            {
                System.String result;
                this.GetProperty("DaylightName", out result);
                return result;
            }
        }

        public System.UInt32? DaylightSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DaylightSecond", out result);
                return result;
            }
        }

        public System.UInt32? DaylightYear
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DaylightYear", out result);
                return result;
            }
        }

        public System.UInt32? StandardBias
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StandardBias", out result);
                return result;
            }
        }

        public System.UInt32? StandardDay
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StandardDay", out result);
                return result;
            }
        }

        public System.Byte? StandardDayOfWeek
        {
            get
            {
                System.Byte? result;
                this.GetProperty("StandardDayOfWeek", out result);
                return result;
            }
        }

        public System.UInt32? StandardHour
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StandardHour", out result);
                return result;
            }
        }

        public System.UInt32? StandardMillisecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StandardMillisecond", out result);
                return result;
            }
        }

        public System.UInt32? StandardMinute
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StandardMinute", out result);
                return result;
            }
        }

        public System.UInt32? StandardMonth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StandardMonth", out result);
                return result;
            }
        }

        public System.String StandardName
        {
            get
            {
                System.String result;
                this.GetProperty("StandardName", out result);
                return result;
            }
        }

        public System.UInt32? StandardSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StandardSecond", out result);
                return result;
            }
        }

        public System.UInt32? StandardYear
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StandardYear", out result);
                return result;
            }
        }
    }
}