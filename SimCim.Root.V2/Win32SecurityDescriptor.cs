using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SecurityDescriptor : SecurityDescriptor
    {
        protected Win32SecurityDescriptor()
        {
        }

        protected Win32SecurityDescriptor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new IEnumerable<Win32ACE> DACL
        {
            get
            {
                IEnumerable<Win32ACE> result;
                this.GetInfrastructureObjectProperty("DACL", out result);
                return result;
            }

            set
            {
                this.SetProperty("DACL", value);
            }
        }

        public new Win32Trustee Group
        {
            get
            {
                Win32Trustee result;
                this.GetInfrastructureObjectProperty("Group", out result);
                return result;
            }

            set
            {
                this.SetProperty("Group", value);
            }
        }

        public new Win32Trustee Owner
        {
            get
            {
                Win32Trustee result;
                this.GetInfrastructureObjectProperty("Owner", out result);
                return result;
            }

            set
            {
                this.SetProperty("Owner", value);
            }
        }

        public new IEnumerable<Win32ACE> SACL
        {
            get
            {
                IEnumerable<Win32ACE> result;
                this.GetInfrastructureObjectProperty("SACL", out result);
                return result;
            }

            set
            {
                this.SetProperty("SACL", value);
            }
        }
    }
}