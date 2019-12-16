using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32Account : CIMLogicalElement
    {
        protected Win32Account()
        {
        }

        protected Win32Account(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Domain
        {
            get
            {
                System.String result;
                this.GetProperty("Domain", out result);
                return result;
            }
        }

        public System.Boolean? LocalAccount
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LocalAccount", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalAccount", value);
            }
        }

        public System.String SID
        {
            get
            {
                System.String result;
                this.GetProperty("SID", out result);
                return result;
            }
        }

        public System.Byte? SIDType
        {
            get
            {
                System.Byte? result;
                this.GetProperty("SIDType", out result);
                return result;
            }
        }
    }
}