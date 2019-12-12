using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class RegistryValueChangeEvent : RegistryEvent
    {
        public RegistryValueChangeEvent()
        {
        }

        public RegistryValueChangeEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String KeyPath
        {
            get
            {
                System.String result;
                this.GetProperty("KeyPath", out result);
                return result;
            }

            set
            {
                this.SetProperty("KeyPath", value);
            }
        }

        public System.String ValueName
        {
            get
            {
                System.String result;
                this.GetProperty("ValueName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ValueName", value);
            }
        }
    }
}