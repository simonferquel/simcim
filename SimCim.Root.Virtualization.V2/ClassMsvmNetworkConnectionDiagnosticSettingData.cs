using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmNetworkConnectionDiagnosticSettingData : CIMSettingData
    {
        public MsvmNetworkConnectionDiagnosticSettingData()
        {
        }

        public MsvmNetworkConnectionDiagnosticSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? IsolationId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IsolationId", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsolationId", value);
            }
        }

        public System.Boolean? IsSender
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsSender", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsSender", value);
            }
        }

        public System.UInt32? PayloadSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PayloadSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("PayloadSize", value);
            }
        }

        public System.String ReceiverIP
        {
            get
            {
                System.String result;
                this.GetProperty("ReceiverIP", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiverIP", value);
            }
        }

        public System.String ReceiverMac
        {
            get
            {
                System.String result;
                this.GetProperty("ReceiverMac", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiverMac", value);
            }
        }

        public System.String SenderIP
        {
            get
            {
                System.String result;
                this.GetProperty("SenderIP", out result);
                return result;
            }

            set
            {
                this.SetProperty("SenderIP", value);
            }
        }

        public System.UInt32? SequenceNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SequenceNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("SequenceNumber", value);
            }
        }
    }
}