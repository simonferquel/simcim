using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PingStatus : GenericInfrastructureObject
    {
        public Win32PingStatus()
        {
        }

        public Win32PingStatus(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Address
        {
            get
            {
                System.String result;
                this.GetProperty("Address", out result);
                return result;
            }
        }

        public System.UInt32 BufferSize
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("BufferSize", out result);
                return result;
            }
        }

        public System.Boolean NoFragmentation
        {
            get
            {
                System.Boolean result;
                this.GetProperty("NoFragmentation", out result);
                return result;
            }
        }

        public System.UInt32? PrimaryAddressResolutionStatus
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PrimaryAddressResolutionStatus", out result);
                return result;
            }
        }

        public System.String ProtocolAddress
        {
            get
            {
                System.String result;
                this.GetProperty("ProtocolAddress", out result);
                return result;
            }
        }

        public System.String ProtocolAddressResolved
        {
            get
            {
                System.String result;
                this.GetProperty("ProtocolAddressResolved", out result);
                return result;
            }
        }

        public System.UInt32 RecordRoute
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("RecordRoute", out result);
                return result;
            }
        }

        public System.Boolean? ReplyInconsistency
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ReplyInconsistency", out result);
                return result;
            }
        }

        public System.UInt32? ReplySize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReplySize", out result);
                return result;
            }
        }

        public System.Boolean ResolveAddressNames
        {
            get
            {
                System.Boolean result;
                this.GetProperty("ResolveAddressNames", out result);
                return result;
            }
        }

        public System.UInt32? ResponseTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ResponseTime", out result);
                return result;
            }
        }

        public System.UInt32? ResponseTimeToLive
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ResponseTimeToLive", out result);
                return result;
            }
        }

        public System.String[] RouteRecord
        {
            get
            {
                System.String[] result;
                this.GetProperty("RouteRecord", out result);
                return result;
            }
        }

        public System.String[] RouteRecordResolved
        {
            get
            {
                System.String[] result;
                this.GetProperty("RouteRecordResolved", out result);
                return result;
            }
        }

        public System.String SourceRoute
        {
            get
            {
                System.String result;
                this.GetProperty("SourceRoute", out result);
                return result;
            }
        }

        public System.UInt32 SourceRouteType
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("SourceRouteType", out result);
                return result;
            }
        }

        public System.UInt32? StatusCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StatusCode", out result);
                return result;
            }
        }

        public System.UInt32 Timeout
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("Timeout", out result);
                return result;
            }
        }

        public System.UInt32[] TimeStampRecord
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("TimeStampRecord", out result);
                return result;
            }
        }

        public System.String[] TimeStampRecordAddress
        {
            get
            {
                System.String[] result;
                this.GetProperty("TimeStampRecordAddress", out result);
                return result;
            }
        }

        public System.String[] TimeStampRecordAddressResolved
        {
            get
            {
                System.String[] result;
                this.GetProperty("TimeStampRecordAddressResolved", out result);
                return result;
            }
        }

        public System.UInt32 TimestampRoute
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("TimestampRoute", out result);
                return result;
            }
        }

        public System.UInt32 TimeToLive
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("TimeToLive", out result);
                return result;
            }
        }

        public System.UInt32 TypeofService
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("TypeofService", out result);
                return result;
            }
        }
    }
}