using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32TerminalService : Win32Service
    {
        public Win32TerminalService()
        {
        }

        public Win32TerminalService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? DisconnectedSessions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DisconnectedSessions", out result);
                return result;
            }
        }

        public System.UInt32? TotalSessions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalSessions", out result);
                return result;
            }
        }
    }
}