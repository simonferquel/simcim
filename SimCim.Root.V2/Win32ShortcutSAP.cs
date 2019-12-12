using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ShortcutSAP : GenericInfrastructureObject
    {
        public Win32ShortcutSAP()
        {
        }

        public Win32ShortcutSAP(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32ShortcutAction Action
        {
            get
            {
                Win32ShortcutAction result;
                this.GetInfrastructureObjectProperty("Action", out result);
                return result;
            }
        }

        public Win32CommandLineAccess Element
        {
            get
            {
                Win32CommandLineAccess result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }
    }
}