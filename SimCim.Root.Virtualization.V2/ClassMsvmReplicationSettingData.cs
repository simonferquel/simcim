using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmReplicationSettingData : CIMVirtualSystemSettingData
    {
        public MsvmReplicationSettingData()
        {
        }

        public MsvmReplicationSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AdditionalSettings
        {
            get
            {
                System.String result;
                this.GetProperty("AdditionalSettings", out result);
                return result;
            }
        }

        public System.UInt16? ApplicationConsistentSnapshotInterval
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ApplicationConsistentSnapshotInterval", out result);
                return result;
            }
        }

        public System.UInt16? AuthenticationType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AuthenticationType", out result);
                return result;
            }
        }

        public System.Boolean? AutoResynchronizeEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AutoResynchronizeEnabled", out result);
                return result;
            }
        }

        public System.DateTime? AutoResynchronizeIntervalEnd
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("AutoResynchronizeIntervalEnd", out result);
                return result;
            }
        }

        public System.DateTime? AutoResynchronizeIntervalStart
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("AutoResynchronizeIntervalStart", out result);
                return result;
            }
        }

        public System.Boolean? BypassProxyServer
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BypassProxyServer", out result);
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

        public System.Boolean? CompressionEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CompressionEnabled", out result);
                return result;
            }
        }

        public System.Boolean? EnableWriteOrderPreservationAcrossDisks
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EnableWriteOrderPreservationAcrossDisks", out result);
                return result;
            }
        }

        public System.String[] IncludedDisks
        {
            get
            {
                System.String[] result;
                this.GetProperty("IncludedDisks", out result);
                return result;
            }
        }

        public System.String PrimaryConnectionPoint
        {
            get
            {
                System.String result;
                this.GetProperty("PrimaryConnectionPoint", out result);
                return result;
            }
        }

        public System.String PrimaryHostSystem
        {
            get
            {
                System.String result;
                this.GetProperty("PrimaryHostSystem", out result);
                return result;
            }
        }

        public System.String RecoveryConnectionPoint
        {
            get
            {
                System.String result;
                this.GetProperty("RecoveryConnectionPoint", out result);
                return result;
            }
        }

        public System.UInt16? RecoveryHistory
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RecoveryHistory", out result);
                return result;
            }
        }

        public System.String RecoveryHostSystem
        {
            get
            {
                System.String result;
                this.GetProperty("RecoveryHostSystem", out result);
                return result;
            }
        }

        public System.UInt16? RecoveryServerPortNumber
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RecoveryServerPortNumber", out result);
                return result;
            }
        }

        public System.Boolean? ReplicateHostKvpItems
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ReplicateHostKvpItems", out result);
                return result;
            }
        }

        public System.UInt16? ReplicationInterval
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ReplicationInterval", out result);
                return result;
            }
        }

        public System.String ReplicationProvider
        {
            get
            {
                System.String result;
                this.GetProperty("ReplicationProvider", out result);
                return result;
            }
        }

        public System.String RootCertificateThumbPrint
        {
            get
            {
                System.String result;
                this.GetProperty("RootCertificateThumbPrint", out result);
                return result;
            }
        }
    }
}