using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class CIMDNSGeneralSettingData : CIMIPAssignmentSettingData
    {
        public CIMDNSGeneralSettingData()
        {
        }

        public CIMDNSGeneralSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AppendParentSuffixes
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AppendParentSuffixes", out result);
                return result;
            }

            set
            {
                this.SetProperty("AppendParentSuffixes", value);
            }
        }

        public System.Boolean? AppendPrimarySuffixes
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AppendPrimarySuffixes", out result);
                return result;
            }

            set
            {
                this.SetProperty("AppendPrimarySuffixes", value);
            }
        }

        public System.String[] DNSSuffixesToAppend
        {
            get
            {
                System.String[] result;
                this.GetProperty("DNSSuffixesToAppend", out result);
                return result;
            }

            set
            {
                this.SetProperty("DNSSuffixesToAppend", value);
            }
        }
    }
}