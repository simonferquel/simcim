using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ImplementedCategory : GenericInfrastructureObject
    {
        public Win32ImplementedCategory()
        {
        }

        public Win32ImplementedCategory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32ComponentCategory Category
        {
            get
            {
                Win32ComponentCategory result;
                this.GetInfrastructureObjectProperty("Category", out result);
                return result;
            }
        }

        public Win32ClassicCOMClass Component
        {
            get
            {
                Win32ClassicCOMClass result;
                this.GetInfrastructureObjectProperty("Component", out result);
                return result;
            }
        }
    }
}