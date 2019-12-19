using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMIPAssignmentSettingData : CIMSettingData
    {
        public CIMIPAssignmentSettingData()
        {
        }

        public CIMIPAssignmentSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AddressOrigin
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AddressOrigin", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddressOrigin", value);
            }
        }

        public System.UInt16? ProtocolIFType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProtocolIFType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolIFType", value);
            }
        }
    }
}