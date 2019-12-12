using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32JobObjectStatus : ExtendedStatus
    {
        public Win32JobObjectStatus()
        {
        }

        public Win32JobObjectStatus(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AdditionalDescription
        {
            get
            {
                System.String result;
                this.GetProperty("AdditionalDescription", out result);
                return result;
            }
        }

        public System.UInt32? Win32ErrorCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Win32ErrorCode", out result);
                return result;
            }
        }
    }
}