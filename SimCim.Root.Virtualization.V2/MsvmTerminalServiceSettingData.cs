using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmTerminalServiceSettingData : CIMSettingData
    {
        public MsvmTerminalServiceSettingData()
        {
        }

        public MsvmTerminalServiceSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] AllowedHashAlgorithms
        {
            get
            {
                System.String[] result;
                this.GetProperty("AllowedHashAlgorithms", out result);
                return result;
            }
        }

        public System.Byte[] AuthCertificateHash
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("AuthCertificateHash", out result);
                return result;
            }
        }

        public System.Boolean? DisableSelfSignedCertificateGeneration
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DisableSelfSignedCertificateGeneration", out result);
                return result;
            }
        }

        public System.UInt32? ListenerPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ListenerPort", out result);
                return result;
            }
        }

        public System.String[] TrustedIssuerCertificateHashes
        {
            get
            {
                System.String[] result;
                this.GetProperty("TrustedIssuerCertificateHashes", out result);
                return result;
            }
        }
    }
}