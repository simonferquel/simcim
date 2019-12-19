using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMSecurityAssociationEndpoint : CIMProtocolEndpoint
    {
        public CIMSecurityAssociationEndpoint()
        {
        }

        public CIMSecurityAssociationEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? IdleDurationSeconds
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IdleDurationSeconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("IdleDurationSeconds", value);
            }
        }

        public System.UInt64? LifetimeKilobytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LifetimeKilobytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("LifetimeKilobytes", value);
            }
        }

        public System.UInt64? LifetimeSeconds
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LifetimeSeconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("LifetimeSeconds", value);
            }
        }

        public System.Boolean? PacketLoggingActive
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PacketLoggingActive", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketLoggingActive", value);
            }
        }

        public System.Byte? RefreshThresholdKbytesPercentage
        {
            get
            {
                System.Byte? result;
                this.GetProperty("RefreshThresholdKbytesPercentage", out result);
                return result;
            }

            set
            {
                this.SetProperty("RefreshThresholdKbytesPercentage", value);
            }
        }

        public System.Byte? RefreshThresholdSecondsPercentage
        {
            get
            {
                System.Byte? result;
                this.GetProperty("RefreshThresholdSecondsPercentage", out result);
                return result;
            }

            set
            {
                this.SetProperty("RefreshThresholdSecondsPercentage", value);
            }
        }
    }
}