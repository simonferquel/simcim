using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DfsTarget : CIMLogicalElement
    {
        public Win32DfsTarget()
        {
        }

        public Win32DfsTarget(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String LinkName
        {
            get
            {
                System.String result;
                this.GetProperty("LinkName", out result);
                return result;
            }

            set
            {
                this.SetProperty("LinkName", value);
            }
        }

        public System.String ServerName
        {
            get
            {
                System.String result;
                this.GetProperty("ServerName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerName", value);
            }
        }

        public System.String ShareName
        {
            get
            {
                System.String result;
                this.GetProperty("ShareName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ShareName", value);
            }
        }

        public System.UInt32? State
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("State", out result);
                return result;
            }

            set
            {
                this.SetProperty("State", value);
            }
        }
    }
}