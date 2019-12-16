using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NamedJobObject : CIMCollectionOfMSEs
    {
        public Win32NamedJobObject()
        {
        }

        public Win32NamedJobObject(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BasicUIRestrictions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BasicUIRestrictions", out result);
                return result;
            }
        }
    }
}