using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OptionalFeature : CIMLogicalElement
    {
        public Win32OptionalFeature()
        {
        }

        public Win32OptionalFeature(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? InstallState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InstallState", out result);
                return result;
            }
        }
    }
}