using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevice : GenericInfrastructureObject
    {
        public Win32PnPDevice()
        {
        }

        public Win32PnPDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMLogicalDevice SameElement
        {
            get
            {
                CIMLogicalDevice result;
                this.GetInfrastructureObjectProperty("SameElement", out result);
                return result;
            }
        }

        public Win32PnPEntity SystemElement
        {
            get
            {
                Win32PnPEntity result;
                this.GetInfrastructureObjectProperty("SystemElement", out result);
                return result;
            }
        }
    }
}