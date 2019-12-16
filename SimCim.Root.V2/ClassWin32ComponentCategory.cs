using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ComponentCategory : CIMLogicalElement
    {
        public Win32ComponentCategory()
        {
        }

        public Win32ComponentCategory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CategoryId
        {
            get
            {
                System.String result;
                this.GetProperty("CategoryId", out result);
                return result;
            }
        }
    }
}