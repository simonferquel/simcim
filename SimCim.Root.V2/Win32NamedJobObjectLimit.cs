using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NamedJobObjectLimit : CIMCollectionSetting
    {
        public Win32NamedJobObjectLimit()
        {
        }

        public Win32NamedJobObjectLimit(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new Win32NamedJobObjectLimitSetting Setting
        {
            get
            {
                Win32NamedJobObjectLimitSetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}