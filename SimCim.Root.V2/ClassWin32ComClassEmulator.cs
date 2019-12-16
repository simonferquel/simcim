using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ComClassEmulator : GenericInfrastructureObject
    {
        public Win32ComClassEmulator()
        {
        }

        public Win32ComClassEmulator(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32ClassicCOMClass NewVersion
        {
            get
            {
                Win32ClassicCOMClass result;
                this.GetInfrastructureObjectProperty("NewVersion", out result);
                return result;
            }
        }

        public Win32ClassicCOMClass OldVersion
        {
            get
            {
                Win32ClassicCOMClass result;
                this.GetInfrastructureObjectProperty("OldVersion", out result);
                return result;
            }
        }
    }
}