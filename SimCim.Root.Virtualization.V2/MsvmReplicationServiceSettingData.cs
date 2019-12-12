using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmReplicationServiceSettingData : CIMSettingData
    {
        public MsvmReplicationServiceSettingData()
        {
        }

        public MsvmReplicationServiceSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AllowedAuthenticationType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AllowedAuthenticationType", out result);
                return result;
            }
        }

        public System.String CertificateThumbPrint
        {
            get
            {
                System.String result;
                this.GetProperty("CertificateThumbPrint", out result);
                return result;
            }
        }

        public System.UInt16? HttpPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HttpPort", out result);
                return result;
            }
        }

        public System.UInt16? HttpsPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HttpsPort", out result);
                return result;
            }
        }

        public System.UInt32? MonitoringInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MonitoringInterval", out result);
                return result;
            }
        }

        public System.DateTime? MonitoringStartTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("MonitoringStartTime", out result);
                return result;
            }
        }

        public System.Boolean? RecoveryServerEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RecoveryServerEnabled", out result);
                return result;
            }
        }
    }
}