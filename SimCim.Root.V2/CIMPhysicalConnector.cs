using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPhysicalConnector : CIMPhysicalElement
    {
        protected CIMPhysicalConnector()
        {
        }

        protected CIMPhysicalConnector(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ConnectorPinout
        {
            get
            {
                System.String result;
                this.GetProperty("ConnectorPinout", out result);
                return result;
            }
        }

        public System.UInt16[] ConnectorType
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ConnectorType", out result);
                return result;
            }
        }
    }
}