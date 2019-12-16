using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class CIMNetworkPort : CIMLogicalPort
    {
        public CIMNetworkPort()
        {
        }

        public CIMNetworkPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? ActiveMaximumTransmissionUnit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ActiveMaximumTransmissionUnit", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveMaximumTransmissionUnit", value);
            }
        }

        public System.Boolean? AutoSense
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AutoSense", out result);
                return result;
            }

            set
            {
                this.SetProperty("AutoSense", value);
            }
        }

        public System.Boolean? FullDuplex
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("FullDuplex", out result);
                return result;
            }

            set
            {
                this.SetProperty("FullDuplex", value);
            }
        }

        public System.UInt16? LinkTechnology
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LinkTechnology", out result);
                return result;
            }

            set
            {
                this.SetProperty("LinkTechnology", value);
            }
        }

        public System.String[] NetworkAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("NetworkAddresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("NetworkAddresses", value);
            }
        }

        public System.String OtherLinkTechnology
        {
            get
            {
                System.String result;
                this.GetProperty("OtherLinkTechnology", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherLinkTechnology", value);
            }
        }

        public System.String OtherNetworkPortType
        {
            get
            {
                System.String result;
                this.GetProperty("OtherNetworkPortType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherNetworkPortType", value);
            }
        }

        public System.String PermanentAddress
        {
            get
            {
                System.String result;
                this.GetProperty("PermanentAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("PermanentAddress", value);
            }
        }

        public System.UInt16? PortNumber
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PortNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("PortNumber", value);
            }
        }

        public System.UInt64? SupportedMaximumTransmissionUnit
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SupportedMaximumTransmissionUnit", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportedMaximumTransmissionUnit", value);
            }
        }
    }
}