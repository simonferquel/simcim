using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterSriovCapabilities : GenericInfrastructureObject
    {
        public MSFTNetAdapterSriovCapabilities()
        {
        }

        public MSFTNetAdapterSriovCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AsymmetricQueuePairsForNonDefaultVPortsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AsymmetricQueuePairsForNonDefaultVPortsSupported", out result);
                return result;
            }
        }

        public System.UInt32? MaxNumMacAddresses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumMacAddresses", out result);
                return result;
            }
        }

        public System.UInt32? MaxNumQueuePairs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumQueuePairs", out result);
                return result;
            }
        }

        public System.UInt32? MaxNumQueuePairsPerNonDefaultVPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumQueuePairsPerNonDefaultVPort", out result);
                return result;
            }
        }

        public System.UInt32? MaxNumSwitches
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumSwitches", out result);
                return result;
            }
        }

        public System.UInt32? MaxNumVFs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumVFs", out result);
                return result;
            }
        }

        public System.UInt32? MaxNumVPorts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxNumVPorts", out result);
                return result;
            }
        }

        public System.Boolean? PerVportInterruptModerationSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PerVportInterruptModerationSupported", out result);
                return result;
            }
        }

        public System.Boolean? SingleVportPoolSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SingleVportPoolSupported", out result);
                return result;
            }
        }

        public System.Boolean? VfRssSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VfRssSupported", out result);
                return result;
            }
        }

        public System.Boolean? VlanSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VlanSupported", out result);
                return result;
            }
        }
    }
}