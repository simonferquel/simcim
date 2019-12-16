using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPCVideoController : CIMVideoController
    {
        protected CIMPCVideoController()
        {
        }

        protected CIMPCVideoController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? NumberOfColorPlanes
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NumberOfColorPlanes", out result);
                return result;
            }
        }

        public System.UInt16? VideoArchitecture
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VideoArchitecture", out result);
                return result;
            }
        }

        public System.UInt16? VideoMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VideoMode", out result);
                return result;
            }
        }
    }
}