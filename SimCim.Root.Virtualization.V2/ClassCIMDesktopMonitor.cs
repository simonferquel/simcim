using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMDesktopMonitor : CIMDisplay
    {
        protected CIMDesktopMonitor()
        {
        }

        protected CIMDesktopMonitor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Bandwidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Bandwidth", out result);
                return result;
            }

            set
            {
                this.SetProperty("Bandwidth", value);
            }
        }

        public System.UInt16? DisplayType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DisplayType", out result);
                return result;
            }

            set
            {
                this.SetProperty("DisplayType", value);
            }
        }

        public System.UInt32? ScreenHeight
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ScreenHeight", out result);
                return result;
            }

            set
            {
                this.SetProperty("ScreenHeight", value);
            }
        }

        public System.UInt32? ScreenWidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ScreenWidth", out result);
                return result;
            }

            set
            {
                this.SetProperty("ScreenWidth", value);
            }
        }
    }
}