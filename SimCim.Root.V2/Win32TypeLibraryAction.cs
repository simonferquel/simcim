using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32TypeLibraryAction : CIMAction
    {
        public Win32TypeLibraryAction()
        {
        }

        public Win32TypeLibraryAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Cost
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Cost", out result);
                return result;
            }
        }

        public System.UInt16? Language
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Language", out result);
                return result;
            }
        }

        public System.String LibID
        {
            get
            {
                System.String result;
                this.GetProperty("LibID", out result);
                return result;
            }
        }
    }
}