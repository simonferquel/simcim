using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSystem : CIMEnabledLogicalElement
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

            set
            {
                this.SetProperty("CreationClassName", value);
            }
        }

        public System.String[] IdentifyingDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("IdentifyingDescriptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("IdentifyingDescriptions", value);
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

            set
            {
                this.SetProperty("NameFormat", value);
            }
        }

        public System.String[] OtherIdentifyingInfo
        {
            get
            {
                System.String[] result;
                this.GetProperty("OtherIdentifyingInfo", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherIdentifyingInfo", value);
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

            set
            {
                this.SetProperty("PrimaryOwnerContact", value);
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

            set
            {
                this.SetProperty("PrimaryOwnerName", value);
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