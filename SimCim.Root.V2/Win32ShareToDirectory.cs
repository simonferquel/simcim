using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ShareToDirectory : GenericInfrastructureObject
    {
        public Win32ShareToDirectory()
        {
        }

        public Win32ShareToDirectory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32Share Share
        {
            get
            {
                Win32Share result;
                this.GetInfrastructureObjectProperty("Share", out result);
                return result;
            }
        }

        public CIMDirectory SharedElement
        {
            get
            {
                CIMDirectory result;
                this.GetInfrastructureObjectProperty("SharedElement", out result);
                return result;
            }
        }
    }
}