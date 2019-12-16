using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ProgIDSpecification : CIMCheck
    {
        public Win32ProgIDSpecification()
        {
        }

        public Win32ProgIDSpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Parent
        {
            get
            {
                System.String result;
                this.GetProperty("Parent", out result);
                return result;
            }
        }

        public System.String ProgID
        {
            get
            {
                System.String result;
                this.GetProperty("ProgID", out result);
                return result;
            }
        }
    }
}