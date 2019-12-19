using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetTCPConnection : MSFTNetTransportConnection
    {
        public MSFTNetTCPConnection()
        {
        }

        public MSFTNetTCPConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? AppliedSetting
        {
            get
            {
                System.Byte? result;
                this.GetProperty("AppliedSetting", out result);
                return result;
            }
        }

        public System.Byte? OffloadState
        {
            get
            {
                System.Byte? result;
                this.GetProperty("OffloadState", out result);
                return result;
            }
        }

        public System.String RemoteAddress
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteAddress", out result);
                return result;
            }
        }

        public System.UInt16? RemotePort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RemotePort", out result);
                return result;
            }
        }

        public System.Byte? State
        {
            get
            {
                System.Byte? result;
                this.GetProperty("State", out result);
                return result;
            }
        }
    }
}