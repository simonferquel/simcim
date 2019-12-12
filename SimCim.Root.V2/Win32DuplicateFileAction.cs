using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DuplicateFileAction : CIMCopyFileAction
    {
        public Win32DuplicateFileAction()
        {
        }

        public Win32DuplicateFileAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String FileKey
        {
            get
            {
                System.String result;
                this.GetProperty("FileKey", out result);
                return result;
            }
        }
    }
}