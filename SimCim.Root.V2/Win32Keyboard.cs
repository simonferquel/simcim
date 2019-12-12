using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Keyboard : CIMKeyboard
    {
        public Win32Keyboard()
        {
        }

        public Win32Keyboard(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}