using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCacheMemory : CIMMemory
    {
        protected CIMCacheMemory()
        {
        }

        protected CIMCacheMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Associativity
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Associativity", out result);
                return result;
            }
        }

        public System.UInt16? CacheType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CacheType", out result);
                return result;
            }
        }

        public System.UInt32? FlushTimer
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FlushTimer", out result);
                return result;
            }
        }

        public System.UInt16? Level
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Level", out result);
                return result;
            }
        }

        public System.UInt32? LineSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LineSize", out result);
                return result;
            }
        }

        public System.UInt16? ReadPolicy
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ReadPolicy", out result);
                return result;
            }
        }

        public System.UInt16? ReplacementPolicy
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ReplacementPolicy", out result);
                return result;
            }
        }

        public System.UInt16? WritePolicy
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("WritePolicy", out result);
                return result;
            }
        }
    }
}