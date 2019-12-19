using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetTransportConnection : CIMNetworkPipe
    {
        public MSFTNetTransportConnection()
        {
        }

        public MSFTNetTransportConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? CreationTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("CreationTime", out result);
                return result;
            }
        }

        public System.String LocalAddress
        {
            get
            {
                System.String result;
                this.GetProperty("LocalAddress", out result);
                return result;
            }
        }

        public System.UInt16? LocalPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LocalPort", out result);
                return result;
            }
        }

        public System.UInt32? OwningProcess
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OwningProcess", out result);
                return result;
            }
        }
    }
}