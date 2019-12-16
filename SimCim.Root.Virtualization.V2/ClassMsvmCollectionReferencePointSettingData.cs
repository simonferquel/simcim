using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCollectionReferencePointSettingData : CIMSettingData
    {
        public MsvmCollectionReferencePointSettingData()
        {
        }

        public MsvmCollectionReferencePointSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? ConsistencyLevel
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ConsistencyLevel", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConsistencyLevel", value);
            }
        }
    }
}