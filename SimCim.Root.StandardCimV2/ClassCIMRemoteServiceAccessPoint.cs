using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMRemoteServiceAccessPoint : CIMServiceAccessPoint
    {
        public CIMRemoteServiceAccessPoint()
        {
        }

        public CIMRemoteServiceAccessPoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AccessContext
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AccessContext", out result);
                return result;
            }

            set
            {
                this.SetProperty("AccessContext", value);
            }
        }

        public System.String AccessInfo
        {
            get
            {
                System.String result;
                this.GetProperty("AccessInfo", out result);
                return result;
            }

            set
            {
                this.SetProperty("AccessInfo", value);
            }
        }

        public System.UInt16? InfoFormat
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("InfoFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("InfoFormat", value);
            }
        }

        public System.String OtherAccessContext
        {
            get
            {
                System.String result;
                this.GetProperty("OtherAccessContext", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherAccessContext", value);
            }
        }

        public System.String OtherInfoFormatDescription
        {
            get
            {
                System.String result;
                this.GetProperty("OtherInfoFormatDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherInfoFormatDescription", value);
            }
        }
    }
}