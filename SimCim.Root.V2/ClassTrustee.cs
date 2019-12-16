using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Trustee : SecurityRelatedClass
    {
        protected Trustee()
        {
        }

        protected Trustee(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Domain
        {
            get
            {
                System.String result;
                this.GetProperty("Domain", out result);
                return result;
            }

            set
            {
                this.SetProperty("Domain", value);
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

        public System.Byte[] SID
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("SID", out result);
                return result;
            }

            set
            {
                this.SetProperty("SID", value);
            }
        }

        public System.UInt32? SidLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SidLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("SidLength", value);
            }
        }

        public System.String SIDString
        {
            get
            {
                System.String result;
                this.GetProperty("SIDString", out result);
                return result;
            }

            set
            {
                this.SetProperty("SIDString", value);
            }
        }

        public System.UInt64? TIMECREATED
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TIME_CREATED", out result);
                return result;
            }

            set
            {
                this.SetProperty("TIME_CREATED", value);
            }
        }
    }
}