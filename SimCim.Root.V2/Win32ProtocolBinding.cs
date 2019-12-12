using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ProtocolBinding : GenericInfrastructureObject
    {
        public Win32ProtocolBinding()
        {
        }

        public Win32ProtocolBinding(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32NetworkProtocol Antecedent
        {
            get
            {
                Win32NetworkProtocol result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public Win32SystemDriver Dependent
        {
            get
            {
                Win32SystemDriver result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }

        public Win32NetworkAdapter Device
        {
            get
            {
                Win32NetworkAdapter result;
                this.GetInfrastructureObjectProperty("Device", out result);
                return result;
            }
        }
    }
}