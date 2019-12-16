using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ActionCheck : GenericInfrastructureObject
    {
        public Win32ActionCheck()
        {
        }

        public Win32ActionCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMAction Action
        {
            get
            {
                CIMAction result;
                this.GetInfrastructureObjectProperty("Action", out result);
                return result;
            }
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
    }
}