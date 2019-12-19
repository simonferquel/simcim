using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetIKEQMCryptoProposal : MSFTNetIKECryptoProposal
    {
        public MSFTNetIKEQMCryptoProposal()
        {
        }

        public MSFTNetIKEQMCryptoProposal(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Encapsulation
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Encapsulation", out result);
                return result;
            }

            set
            {
                this.SetProperty("Encapsulation", value);
            }
        }

        public System.UInt16? HashAlgorithmAH
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HashAlgorithmAH", out result);
                return result;
            }

            set
            {
                this.SetProperty("HashAlgorithmAH", value);
            }
        }

        public System.UInt16? HashAlgorithmESP
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HashAlgorithmESP", out result);
                return result;
            }

            set
            {
                this.SetProperty("HashAlgorithmESP", value);
            }
        }

        public System.UInt32? MaxLifetimeMinutes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxLifetimeMinutes", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxLifetimeMinutes", value);
            }
        }
    }
}