using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterQosClassificationElement : GenericInfrastructureObject
    {
        public MSFTNetAdapterQosClassificationElement()
        {
        }

        public MSFTNetAdapterQosClassificationElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? Priority
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Priority", out result);
                return result;
            }
        }

        public System.UInt16? ProtocolSelector
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProtocolSelector", out result);
                return result;
            }
        }

        public System.UInt16? ProtocolSpecificValue
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProtocolSpecificValue", out result);
                return result;
            }
        }
    }
}