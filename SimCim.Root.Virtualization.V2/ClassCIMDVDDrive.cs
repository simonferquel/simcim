using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMDVDDrive : CIMMediaAccessDevice
    {
        protected CIMDVDDrive()
        {
        }

        protected CIMDVDDrive(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] FormatsSupported
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("FormatsSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("FormatsSupported", value);
            }
        }
    }
}