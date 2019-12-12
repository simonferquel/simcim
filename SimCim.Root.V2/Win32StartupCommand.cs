using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32StartupCommand : CIMSetting
    {
        public Win32StartupCommand()
        {
        }

        public Win32StartupCommand(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Command
        {
            get
            {
                System.String result;
                this.GetProperty("Command", out result);
                return result;
            }
        }

        public System.String Location
        {
            get
            {
                System.String result;
                this.GetProperty("Location", out result);
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

        public System.String User
        {
            get
            {
                System.String result;
                this.GetProperty("User", out result);
                return result;
            }
        }

        public System.String UserSID
        {
            get
            {
                System.String result;
                this.GetProperty("UserSID", out result);
                return result;
            }
        }
    }
}