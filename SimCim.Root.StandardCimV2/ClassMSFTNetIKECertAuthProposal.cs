using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetIKECertAuthProposal : MSFTNetIKEAuthProposal
    {
        public MSFTNetIKECertAuthProposal()
        {
        }

        public MSFTNetIKECertAuthProposal(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CertName
        {
            get
            {
                System.String result;
                this.GetProperty("CertName", out result);
                return result;
            }

            set
            {
                this.SetProperty("CertName", value);
            }
        }

        public System.UInt16? CertNameType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CertNameType", out result);
                return result;
            }

            set
            {
                this.SetProperty("CertNameType", value);
            }
        }

        public System.String[] EKUs
        {
            get
            {
                System.String[] result;
                this.GetProperty("EKUs", out result);
                return result;
            }

            set
            {
                this.SetProperty("EKUs", value);
            }
        }

        public System.Boolean? ExcludeCAName
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ExcludeCAName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExcludeCAName", value);
            }
        }

        public System.Boolean? FollowRenewal
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("FollowRenewal", out result);
                return result;
            }

            set
            {
                this.SetProperty("FollowRenewal", value);
            }
        }

        public System.Boolean? MapToAccount
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MapToAccount", out result);
                return result;
            }

            set
            {
                this.SetProperty("MapToAccount", value);
            }
        }

        public System.Boolean? SelectionCriteria
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SelectionCriteria", out result);
                return result;
            }

            set
            {
                this.SetProperty("SelectionCriteria", value);
            }
        }

        public System.UInt16? SigningAlgorithm
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SigningAlgorithm", out result);
                return result;
            }

            set
            {
                this.SetProperty("SigningAlgorithm", value);
            }
        }

        public System.String Thumbprint
        {
            get
            {
                System.String result;
                this.GetProperty("Thumbprint", out result);
                return result;
            }

            set
            {
                this.SetProperty("Thumbprint", value);
            }
        }

        public System.String TrustedCA
        {
            get
            {
                System.String result;
                this.GetProperty("TrustedCA", out result);
                return result;
            }

            set
            {
                this.SetProperty("TrustedCA", value);
            }
        }

        public System.UInt16? TrustedCAType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TrustedCAType", out result);
                return result;
            }

            set
            {
                this.SetProperty("TrustedCAType", value);
            }
        }

        public System.Boolean? ValidationCriteria
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ValidationCriteria", out result);
                return result;
            }

            set
            {
                this.SetProperty("ValidationCriteria", value);
            }
        }
    }
}