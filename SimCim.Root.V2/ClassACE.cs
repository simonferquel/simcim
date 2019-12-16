using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class ACE : SecurityRelatedClass
    {
        protected ACE()
        {
        }

        protected ACE(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AccessMask
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AccessMask", out result);
                return result;
            }

            set
            {
                this.SetProperty("AccessMask", value);
            }
        }

        public System.UInt32? AceFlags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AceFlags", out result);
                return result;
            }

            set
            {
                this.SetProperty("AceFlags", value);
            }
        }

        public System.UInt32? AceType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AceType", out result);
                return result;
            }

            set
            {
                this.SetProperty("AceType", value);
            }
        }

        public System.String GuidInheritedObjectType
        {
            get
            {
                System.String result;
                this.GetProperty("GuidInheritedObjectType", out result);
                return result;
            }

            set
            {
                this.SetProperty("GuidInheritedObjectType", value);
            }
        }

        public System.String GuidObjectType
        {
            get
            {
                System.String result;
                this.GetProperty("GuidObjectType", out result);
                return result;
            }

            set
            {
                this.SetProperty("GuidObjectType", value);
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

        public Trustee Trustee
        {
            get
            {
                Trustee result;
                this.GetInfrastructureObjectProperty("Trustee", out result);
                return result;
            }

            set
            {
                this.SetProperty("Trustee", value);
            }
        }
    }
}