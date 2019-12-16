using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class CIMManagedElement : GenericInfrastructureObject
    {
        protected CIMManagedElement()
        {
        }

        protected CIMManagedElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

            set
            {
                this.SetProperty("Caption", value);
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

            set
            {
                this.SetProperty("Description", value);
            }
        }

        public System.String ElementName
        {
            get
            {
                System.String result;
                this.GetProperty("ElementName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ElementName", value);
            }
        }

        public System.String InstanceID
        {
            get
            {
                System.String result;
                this.GetProperty("InstanceID", out result);
                return result;
            }

            set
            {
                this.SetProperty("InstanceID", value);
            }
        }
    }
}