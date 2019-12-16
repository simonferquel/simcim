using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SoftwareElement : CIMSoftwareElement
    {
        public Win32SoftwareElement()
        {
        }

        public Win32SoftwareElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Attributes
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Attributes", out result);
                return result;
            }
        }

        public System.Int16? InstallState
        {
            get
            {
                System.Int16? result;
                this.GetProperty("InstallState", out result);
                return result;
            }
        }

        public System.String Path
        {
            get
            {
                System.String result;
                this.GetProperty("Path", out result);
                return result;
            }
        }
    }
}