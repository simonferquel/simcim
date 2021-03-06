﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPDevicePropertyReal32 : Win32PnPDeviceProperty
    {
        public Win32PnPDevicePropertyReal32()
        {
        }

        public Win32PnPDevicePropertyReal32(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Single? Data
        {
            get
            {
                System.Single? result;
                this.GetProperty("Data", out result);
                return result;
            }
        }
    }
}