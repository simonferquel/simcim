using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32CheckCheck : GenericInfrastructureObject
    {
        public Win32CheckCheck()
        {
        }

        public Win32CheckCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMCheck Check
        {
            get
            {
                CIMCheck result;
                this.GetInfrastructureObjectProperty("Check", out result);
                return result;
            }
        }

        public CIMCheck Location
        {
            get
            {
                CIMCheck result;
                this.GetInfrastructureObjectProperty("Location", out result);
                return result;
            }
        }
    }
}