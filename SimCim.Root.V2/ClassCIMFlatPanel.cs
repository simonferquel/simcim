using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMFlatPanel : CIMDisplay
    {
        protected CIMFlatPanel()
        {
        }

        protected CIMFlatPanel(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? DisplayType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DisplayType", out result);
                return result;
            }
        }

        public System.UInt32? HorizontalResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HorizontalResolution", out result);
                return result;
            }
        }

        public System.UInt16? LightSource
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LightSource", out result);
                return result;
            }
        }

        public System.UInt16? ScanMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ScanMode", out result);
                return result;
            }
        }

        public System.Boolean? SupportsColor
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsColor", out result);
                return result;
            }
        }

        public System.UInt32? VerticalResolution
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VerticalResolution", out result);
                return result;
            }
        }
    }
}