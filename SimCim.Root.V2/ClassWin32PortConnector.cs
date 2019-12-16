using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PortConnector : CIMPhysicalConnector
    {
        public Win32PortConnector()
        {
        }

        public Win32PortConnector(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ExternalReferenceDesignator
        {
            get
            {
                System.String result;
                this.GetProperty("ExternalReferenceDesignator", out result);
                return result;
            }
        }

        public System.String InternalReferenceDesignator
        {
            get
            {
                System.String result;
                this.GetProperty("InternalReferenceDesignator", out result);
                return result;
            }
        }

        public System.UInt16? PortType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PortType", out result);
                return result;
            }
        }
    }
}