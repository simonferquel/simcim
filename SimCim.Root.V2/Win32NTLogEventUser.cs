using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NTLogEventUser : GenericInfrastructureObject
    {
        public Win32NTLogEventUser()
        {
        }

        public Win32NTLogEventUser(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32NTLogEvent Record
        {
            get
            {
                Win32NTLogEvent result;
                this.GetInfrastructureObjectProperty("Record", out result);
                return result;
            }
        }

        public Win32UserAccount User
        {
            get
            {
                Win32UserAccount result;
                this.GetInfrastructureObjectProperty("User", out result);
                return result;
            }
        }
    }
}