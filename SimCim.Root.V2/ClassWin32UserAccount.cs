using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32UserAccount : Win32Account
    {
        public Win32UserAccount()
        {
        }

        public Win32UserAccount(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AccountType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AccountType", out result);
                return result;
            }
        }

        public System.Boolean? Disabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Disabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("Disabled", value);
            }
        }

        public System.String FullName
        {
            get
            {
                System.String result;
                this.GetProperty("FullName", out result);
                return result;
            }

            set
            {
                this.SetProperty("FullName", value);
            }
        }

        public System.Boolean? Lockout
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Lockout", out result);
                return result;
            }

            set
            {
                this.SetProperty("Lockout", value);
            }
        }

        public System.Boolean? PasswordChangeable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PasswordChangeable", out result);
                return result;
            }

            set
            {
                this.SetProperty("PasswordChangeable", value);
            }
        }

        public System.Boolean? PasswordExpires
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PasswordExpires", out result);
                return result;
            }

            set
            {
                this.SetProperty("PasswordExpires", value);
            }
        }

        public System.Boolean? PasswordRequired
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PasswordRequired", out result);
                return result;
            }

            set
            {
                this.SetProperty("PasswordRequired", value);
            }
        }

        public System.UInt32 Rename(System.String inName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Rename", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}