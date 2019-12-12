using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ShortcutFile : CIMDataFile
    {
        public Win32ShortcutFile()
        {
        }

        public Win32ShortcutFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Target
        {
            get
            {
                System.String result;
                this.GetProperty("Target", out result);
                return result;
            }
        }
    }
}