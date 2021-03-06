﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemOperatingSystem : CIMInstalledOS
    {
        public Win32SystemOperatingSystem()
        {
        }

        public Win32SystemOperatingSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32ComputerSystem GroupComponent
        {
            get
            {
                Win32ComputerSystem result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32OperatingSystem PartComponent
        {
            get
            {
                Win32OperatingSystem result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}