using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32MountPoint : GenericInfrastructureObject
    {
        public Win32MountPoint()
        {
        }

        public Win32MountPoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32Directory Directory
        {
            get
            {
                Win32Directory result;
                this.GetInfrastructureObjectProperty("Directory", out result);
                return result;
            }
        }

        public Win32Volume Volume
        {
            get
            {
                Win32Volume result;
                this.GetInfrastructureObjectProperty("Volume", out result);
                return result;
            }
        }
    }
}