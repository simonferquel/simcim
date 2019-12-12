using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSystem : CIMLogicalElement
    {
        protected CIMSystem()
        {
        }

        protected CIMSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }
        }

        public System.String NameFormat
        {
            get
            {
                System.String result;
                this.GetProperty("NameFormat", out result);
                return result;
            }
        }

        public System.String PrimaryOwnerContact
        {
            get
            {
                System.String result;
                this.GetProperty("PrimaryOwnerContact", out result);
                return result;
            }
        }

        public System.String PrimaryOwnerName
        {
            get
            {
                System.String result;
                this.GetProperty("PrimaryOwnerName", out result);
                return result;
            }
        }

        public System.String[] Roles
        {
            get
            {
                System.String[] result;
                this.GetProperty("Roles", out result);
                return result;
            }

            set
            {
                this.SetProperty("Roles", value);
            }
        }
    }
}