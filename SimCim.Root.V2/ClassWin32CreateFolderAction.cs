using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32CreateFolderAction : CIMCreateDirectoryAction
    {
        public Win32CreateFolderAction()
        {
        }

        public Win32CreateFolderAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}