using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NamedJobObjectSecLimit : CIMCollectionSetting
    {
        public Win32NamedJobObjectSecLimit()
        {
        }

        public Win32NamedJobObjectSecLimit(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new Win32NamedJobObjectSecLimitSetting Setting
        {
            get
            {
                Win32NamedJobObjectSecLimitSetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}