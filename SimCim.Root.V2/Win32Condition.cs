using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Condition : CIMCheck
    {
        public Win32Condition()
        {
        }

        public Win32Condition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Condition
        {
            get
            {
                System.String result;
                this.GetProperty("Condition", out result);
                return result;
            }
        }

        public System.String Feature
        {
            get
            {
                System.String result;
                this.GetProperty("Feature", out result);
                return result;
            }
        }

        public System.UInt16? Level
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Level", out result);
                return result;
            }
        }
    }
}