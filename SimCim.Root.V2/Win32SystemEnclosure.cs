using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemEnclosure : CIMChassis
    {
        public Win32SystemEnclosure()
        {
        }

        public Win32SystemEnclosure(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? SecurityStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SecurityStatus", out result);
                return result;
            }
        }

        public System.String SMBIOSAssetTag
        {
            get
            {
                System.String result;
                this.GetProperty("SMBIOSAssetTag", out result);
                return result;
            }
        }
    }
}