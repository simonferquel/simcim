using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NetworkLoginProfile : CIMSetting
    {
        public Win32NetworkLoginProfile()
        {
        }

        public Win32NetworkLoginProfile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? AccountExpires
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("AccountExpires", out result);
                return result;
            }
        }

        public System.UInt32? AuthorizationFlags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthorizationFlags", out result);
                return result;
            }
        }

        public System.UInt32? BadPasswordCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BadPasswordCount", out result);
                return result;
            }
        }

        public System.UInt32? CodePage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CodePage", out result);
                return result;
            }
        }

        public System.String Comment
        {
            get
            {
                System.String result;
                this.GetProperty("Comment", out result);
                return result;
            }
        }

        public System.UInt32? CountryCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CountryCode", out result);
                return result;
            }
        }

        public System.UInt32? Flags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Flags", out result);
                return result;
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
        }

        public System.String HomeDirectory
        {
            get
            {
                System.String result;
                this.GetProperty("HomeDirectory", out result);
                return result;
            }
        }

        public System.String HomeDirectoryDrive
        {
            get
            {
                System.String result;
                this.GetProperty("HomeDirectoryDrive", out result);
                return result;
            }
        }

        public System.DateTime? LastLogoff
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastLogoff", out result);
                return result;
            }
        }

        public System.DateTime? LastLogon
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("LastLogon", out result);
                return result;
            }
        }

        public System.String LogonHours
        {
            get
            {
                System.String result;
                this.GetProperty("LogonHours", out result);
                return result;
            }
        }

        public System.String LogonServer
        {
            get
            {
                System.String result;
                this.GetProperty("LogonServer", out result);
                return result;
            }
        }

        public System.UInt64? MaximumStorage
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaximumStorage", out result);
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

        public System.UInt32? NumberOfLogons
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfLogons", out result);
                return result;
            }
        }

        public System.String Parameters
        {
            get
            {
                System.String result;
                this.GetProperty("Parameters", out result);
                return result;
            }
        }

        public System.DateTime? PasswordAge
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("PasswordAge", out result);
                return result;
            }
        }

        public System.DateTime? PasswordExpires
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("PasswordExpires", out result);
                return result;
            }
        }

        public System.UInt32? PrimaryGroupId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PrimaryGroupId", out result);
                return result;
            }
        }

        public System.UInt32? Privileges
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Privileges", out result);
                return result;
            }
        }

        public System.String Profile
        {
            get
            {
                System.String result;
                this.GetProperty("Profile", out result);
                return result;
            }
        }

        public System.String ScriptPath
        {
            get
            {
                System.String result;
                this.GetProperty("ScriptPath", out result);
                return result;
            }
        }

        public System.UInt32? UnitsPerWeek
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UnitsPerWeek", out result);
                return result;
            }
        }

        public System.String UserComment
        {
            get
            {
                System.String result;
                this.GetProperty("UserComment", out result);
                return result;
            }
        }

        public System.UInt32? UserId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UserId", out result);
                return result;
            }
        }

        public System.String UserType
        {
            get
            {
                System.String result;
                this.GetProperty("UserType", out result);
                return result;
            }
        }

        public System.String Workstations
        {
            get
            {
                System.String result;
                this.GetProperty("Workstations", out result);
                return result;
            }
        }
    }
}