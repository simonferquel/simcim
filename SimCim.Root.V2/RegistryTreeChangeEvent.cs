using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class RegistryTreeChangeEvent : RegistryEvent
    {
        public RegistryTreeChangeEvent()
        {
        }

        public RegistryTreeChangeEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Hive
        {
            get
            {
                System.String result;
                this.GetProperty("Hive", out result);
                return result;
            }

            set
            {
                this.SetProperty("Hive", value);
            }
        }

        public System.String RootPath
        {
            get
            {
                System.String result;
                this.GetProperty("RootPath", out result);
                return result;
            }

            set
            {
                this.SetProperty("RootPath", value);
            }
        }
    }
}