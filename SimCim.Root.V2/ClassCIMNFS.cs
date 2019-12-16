using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMNFS : CIMRemoteFileSystem
    {
        protected CIMNFS()
        {
        }

        protected CIMNFS(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AttributeCaching
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AttributeCaching", out result);
                return result;
            }
        }

        public System.UInt16? AttributeCachingForDirectoriesMax
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AttributeCachingForDirectoriesMax", out result);
                return result;
            }
        }

        public System.UInt16? AttributeCachingForDirectoriesMin
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AttributeCachingForDirectoriesMin", out result);
                return result;
            }
        }

        public System.UInt16? AttributeCachingForRegularFilesMax
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AttributeCachingForRegularFilesMax", out result);
                return result;
            }
        }

        public System.UInt16? AttributeCachingForRegularFilesMin
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AttributeCachingForRegularFilesMin", out result);
                return result;
            }
        }

        public System.Boolean? ForegroundMount
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ForegroundMount", out result);
                return result;
            }
        }

        public System.Boolean? HardMount
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HardMount", out result);
                return result;
            }
        }

        public System.Boolean? Interrupt
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Interrupt", out result);
                return result;
            }
        }

        public System.UInt16? MountFailureRetries
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MountFailureRetries", out result);
                return result;
            }
        }

        public System.UInt64? ReadBufferSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBufferSize", out result);
                return result;
            }
        }

        public System.UInt16? RetransmissionAttempts
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RetransmissionAttempts", out result);
                return result;
            }
        }

        public System.UInt32? RetransmissionTimeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RetransmissionTimeout", out result);
                return result;
            }
        }

        public System.UInt32? ServerCommunicationPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ServerCommunicationPort", out result);
                return result;
            }
        }

        public System.UInt64? WriteBufferSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBufferSize", out result);
                return result;
            }
        }
    }
}