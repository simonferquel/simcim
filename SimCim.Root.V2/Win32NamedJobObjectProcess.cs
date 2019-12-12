using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NamedJobObjectProcess : CIMCollectedMSEs
    {
        public Win32NamedJobObjectProcess()
        {
        }

        public Win32NamedJobObjectProcess(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32NamedJobObject Collection
        {
            get
            {
                Win32NamedJobObject result;
                this.GetInfrastructureObjectProperty("Collection", out result);
                return result;
            }
        }

        public new Win32Process Member
        {
            get
            {
                Win32Process result;
                this.GetInfrastructureObjectProperty("Member", out result);
                return result;
            }
        }
    }
}