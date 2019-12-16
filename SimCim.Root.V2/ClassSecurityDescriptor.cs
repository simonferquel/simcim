using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class SecurityDescriptor : SecurityRelatedClass
    {
        protected SecurityDescriptor()
        {
        }

        protected SecurityDescriptor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ControlFlags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ControlFlags", out result);
                return result;
            }

            set
            {
                this.SetProperty("ControlFlags", value);
            }
        }

        public IEnumerable<ACE> DACL
        {
            get
            {
                IEnumerable<ACE> result;
                this.GetInfrastructureObjectProperty("DACL", out result);
                return result;
            }

            set
            {
                this.SetProperty("DACL", value);
            }
        }

        public ACE Group
        {
            get
            {
                ACE result;
                this.GetInfrastructureObjectProperty("Group", out result);
                return result;
            }

            set
            {
                this.SetProperty("Group", value);
            }
        }

        public ACE Owner
        {
            get
            {
                ACE result;
                this.GetInfrastructureObjectProperty("Owner", out result);
                return result;
            }

            set
            {
                this.SetProperty("Owner", value);
            }
        }

        public IEnumerable<ACE> SACL
        {
            get
            {
                IEnumerable<ACE> result;
                this.GetInfrastructureObjectProperty("SACL", out result);
                return result;
            }

            set
            {
                this.SetProperty("SACL", value);
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