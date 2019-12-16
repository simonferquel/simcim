using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32RemoveFileAction : CIMRemoveFileAction
    {
        public Win32RemoveFileAction()
        {
        }

        public Win32RemoveFileAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DirProperty
        {
            get
            {
                System.String result;
                this.GetProperty("DirProperty", out result);
                return result;
            }
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

        public System.String FileName
        {
            get
            {
                System.String result;
                this.GetProperty("FileName", out result);
                return result;
            }
        }

        public System.UInt16? InstallMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("InstallMode", out result);
                return result;
            }
        }
    }
}