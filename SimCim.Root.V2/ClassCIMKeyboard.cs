using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMKeyboard : CIMUserDevice
    {
        protected CIMKeyboard()
        {
        }

        protected CIMKeyboard(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Layout
        {
            get
            {
                System.String result;
                this.GetProperty("Layout", out result);
                return result;
            }
        }

        public System.UInt16? NumberOfFunctionKeys
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NumberOfFunctionKeys", out result);
                return result;
            }
        }

        public System.UInt16? Password
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Password", out result);
                return result;
            }
        }
    }
}