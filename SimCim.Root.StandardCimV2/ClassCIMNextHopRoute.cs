using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMNextHopRoute : CIMManagedElement
    {
        public CIMNextHopRoute()
        {
        }

        public CIMNextHopRoute(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AdminDistance
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AdminDistance", out result);
                return result;
            }

            set
            {
                this.SetProperty("AdminDistance", value);
            }
        }

        public System.String DestinationAddress
        {
            get
            {
                System.String result;
                this.GetProperty("DestinationAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("DestinationAddress", value);
            }
        }

        public System.Boolean? IsStatic
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsStatic", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsStatic", value);
            }
        }

        public System.UInt16? RouteMetric
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RouteMetric", out result);
                return result;
            }

            set
            {
                this.SetProperty("RouteMetric", value);
            }
        }

        public System.UInt16? TypeOfRoute
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TypeOfRoute", out result);
                return result;
            }

            set
            {
                this.SetProperty("TypeOfRoute", value);
            }
        }
    }
}