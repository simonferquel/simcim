using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTDNSClientGlobalSetting : CIMDNSGeneralSettingData
    {
        public MSFTDNSClientGlobalSetting()
        {
        }

        public MSFTDNSClientGlobalSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? DevolutionLevel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DevolutionLevel", out result);
                return result;
            }

            set
            {
                this.SetProperty("DevolutionLevel", value);
            }
        }

        public System.String[] SuffixSearchList
        {
            get
            {
                System.String[] result;
                this.GetProperty("SuffixSearchList", out result);
                return result;
            }

            set
            {
                this.SetProperty("SuffixSearchList", value);
            }
        }

        public System.Boolean? UseDevolution
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UseDevolution", out result);
                return result;
            }

            set
            {
                this.SetProperty("UseDevolution", value);
            }
        }

        public System.Boolean? UseSuffixSearchList
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UseSuffixSearchList", out result);
                return result;
            }

            set
            {
                this.SetProperty("UseSuffixSearchList", value);
            }
        }
    }
}