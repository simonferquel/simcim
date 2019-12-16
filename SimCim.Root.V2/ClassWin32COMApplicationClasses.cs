using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32COMApplicationClasses : CIMComponent
    {
        protected Win32COMApplicationClasses()
        {
        }

        protected Win32COMApplicationClasses(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32COMApplication GroupComponent
        {
            get
            {
                Win32COMApplication result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32COMClass PartComponent
        {
            get
            {
                Win32COMClass result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}