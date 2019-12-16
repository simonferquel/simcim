using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32AccountSID : GenericInfrastructureObject
    {
        public Win32AccountSID()
        {
        }

        public Win32AccountSID(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32Account Element
        {
            get
            {
                Win32Account result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public Win32SID Setting
        {
            get
            {
                Win32SID result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}