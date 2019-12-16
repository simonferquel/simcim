using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ClassicCOMApplicationClasses : Win32COMApplicationClasses
    {
        public Win32ClassicCOMApplicationClasses()
        {
        }

        public Win32ClassicCOMApplicationClasses(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32DCOMApplication GroupComponent
        {
            get
            {
                Win32DCOMApplication result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32ClassicCOMClass PartComponent
        {
            get
            {
                Win32ClassicCOMClass result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}