using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ComputerSystemProcessor : Win32SystemDevices
    {
        public Win32ComputerSystemProcessor()
        {
        }

        public Win32ComputerSystemProcessor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Processor PartComponent
        {
            get
            {
                Win32Processor result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}