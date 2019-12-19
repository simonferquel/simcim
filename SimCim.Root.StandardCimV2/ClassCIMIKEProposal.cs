using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMIKEProposal : CIMSAProposal
    {
        public CIMIKEProposal()
        {
        }

        public CIMIKEProposal(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AuthenticationMethod
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AuthenticationMethod", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuthenticationMethod", value);
            }
        }

        public System.UInt16? CipherAlgorithm
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CipherAlgorithm", out result);
                return result;
            }

            set
            {
                this.SetProperty("CipherAlgorithm", value);
            }
        }

        public System.UInt16? GroupId
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("GroupId", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupId", value);
            }
        }

        public System.UInt16? HashAlgorithm
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HashAlgorithm", out result);
                return result;
            }

            set
            {
                this.SetProperty("HashAlgorithm", value);
            }
        }

        public System.UInt64? MaxLifetimeKilobytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxLifetimeKilobytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxLifetimeKilobytes", value);
            }
        }

        public System.UInt64? MaxLifetimeSeconds
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxLifetimeSeconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxLifetimeSeconds", value);
            }
        }

        public System.String OtherAuthenticationMethod
        {
            get
            {
                System.String result;
                this.GetProperty("OtherAuthenticationMethod", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherAuthenticationMethod", value);
            }
        }

        public System.String OtherCipherAlgorithm
        {
            get
            {
                System.String result;
                this.GetProperty("OtherCipherAlgorithm", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherCipherAlgorithm", value);
            }
        }

        public System.String OtherHashAlgorithm
        {
            get
            {
                System.String result;
                this.GetProperty("OtherHashAlgorithm", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherHashAlgorithm", value);
            }
        }

        public System.String VendorID
        {
            get
            {
                System.String result;
                this.GetProperty("VendorID", out result);
                return result;
            }

            set
            {
                this.SetProperty("VendorID", value);
            }
        }
    }
}