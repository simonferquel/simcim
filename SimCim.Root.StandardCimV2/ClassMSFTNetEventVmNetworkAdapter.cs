using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetEventVmNetworkAdapter : MSFTNetEventPacketCaptureTarget
    {
        public MSFTNetEventVmNetworkAdapter()
        {
        }

        public MSFTNetEventVmNetworkAdapter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String MacAddress
        {
            get
            {
                System.String result;
                this.GetProperty("MacAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("MacAddress", value);
            }
        }

        public System.String PortName
        {
            get
            {
                System.String result;
                this.GetProperty("PortName", out result);
                return result;
            }

            set
            {
                this.SetProperty("PortName", value);
            }
        }

        public System.String SwitchName
        {
            get
            {
                System.String result;
                this.GetProperty("SwitchName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SwitchName", value);
            }
        }

        public System.String VMId
        {
            get
            {
                System.String result;
                this.GetProperty("VMId", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMId", value);
            }
        }

        public System.String VMName
        {
            get
            {
                System.String result;
                this.GetProperty("VMName", out result);
                return result;
            }

            set
            {
                this.SetProperty("VMName", value);
            }
        }
    }
}