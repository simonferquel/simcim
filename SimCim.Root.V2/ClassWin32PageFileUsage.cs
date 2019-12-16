using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PageFileUsage : CIMLogicalElement
    {
        public Win32PageFileUsage()
        {
        }

        public Win32PageFileUsage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AllocatedBaseSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AllocatedBaseSize", out result);
                return result;
            }
        }

        public System.UInt32? CurrentUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentUsage", out result);
                return result;
            }
        }

        public System.UInt32? PeakUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PeakUsage", out result);
                return result;
            }
        }

        public System.Boolean? TempPageFile
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TempPageFile", out result);
                return result;
            }
        }
    }
}