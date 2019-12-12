using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SecuritySettingAuditing : GenericInfrastructureObject
    {
        protected Win32SecuritySettingAuditing()
        {
        }

        protected Win32SecuritySettingAuditing(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AuditedAccessMask
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuditedAccessMask", out result);
                return result;
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
        }

        public System.String GuidObjectType
        {
            get
            {
                System.String result;
                this.GetProperty("GuidObjectType", out result);
                return result;
            }
        }

        public System.UInt32? Inheritance
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Inheritance", out result);
                return result;
            }
        }

        public Win32SecuritySetting SecuritySetting
        {
            get
            {
                Win32SecuritySetting result;
                this.GetInfrastructureObjectProperty("SecuritySetting", out result);
                return result;
            }
        }

        public Win32SID Trustee
        {
            get
            {
                Win32SID result;
                this.GetInfrastructureObjectProperty("Trustee", out result);
                return result;
            }
        }

        public System.UInt32? Type
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Type", out result);
                return result;
            }
        }
    }
}