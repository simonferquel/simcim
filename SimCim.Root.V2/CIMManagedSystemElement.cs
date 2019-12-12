using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMManagedSystemElement : GenericInfrastructureObject
    {
        protected CIMManagedSystemElement()
        {
        }

        protected CIMManagedSystemElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Caption
        {
            get
            {
                System.String result;
                this.GetProperty("Caption", out result);
                return result;
            }
        }

        public System.String Description
        {
            get
            {
                System.String result;
                this.GetProperty("Description", out result);
                return result;
            }
        }

        public System.DateTime? InstallDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("InstallDate", out result);
                return result;
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
        }

        public System.String Status
        {
            get
            {
                System.String result;
                this.GetProperty("Status", out result);
                return result;
            }
        }
    }
}