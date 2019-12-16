using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ComClassAutoEmulator : GenericInfrastructureObject
    {
        public Win32ComClassAutoEmulator()
        {
        }

        public Win32ComClassAutoEmulator(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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