﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmInstalledEthernetSwitchExtension : CIMManagedSystemElement
    {
        public MsvmInstalledEthernetSwitchExtension()
        {
        }

        public MsvmInstalledEthernetSwitchExtension(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? ExtensionType
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ExtensionType", out result);
                return result;
            }
        }

        public System.String Vendor
        {
            get
            {
                System.String result;
                this.GetProperty("Vendor", out result);
                return result;
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }
    }
}