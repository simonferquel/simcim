using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DeviceMemoryAddress : Win32SystemMemoryResource
    {
        public Win32DeviceMemoryAddress()
        {
        }

        public Win32DeviceMemoryAddress(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String MemoryType
        {
            get
            {
                System.String result;
                this.GetProperty("MemoryType", out result);
                return result;
            }
        }
    }
}