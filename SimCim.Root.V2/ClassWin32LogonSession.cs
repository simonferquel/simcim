using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogonSession : Win32Session
    {
        public Win32LogonSession()
        {
        }

        public Win32LogonSession(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AuthenticationPackage
        {
            get
            {
                System.String result;
                this.GetProperty("AuthenticationPackage", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuthenticationPackage", value);
            }
        }

        public System.String LogonId
        {
            get
            {
                System.String result;
                this.GetProperty("LogonId", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogonId", value);
            }
        }

        public System.UInt32? LogonType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LogonType", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogonType", value);
            }
        }
    }
}