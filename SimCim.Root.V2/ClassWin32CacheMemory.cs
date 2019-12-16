using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32CacheMemory : CIMCacheMemory
    {
        public Win32CacheMemory()
        {
        }

        public Win32CacheMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CacheSpeed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheSpeed", out result);
                return result;
            }
        }

        public System.UInt16[] CurrentSRAM
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("CurrentSRAM", out result);
                return result;
            }
        }

        public System.UInt16? ErrorCorrectType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ErrorCorrectType", out result);
                return result;
            }
        }

        public System.UInt32? InstalledSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InstalledSize", out result);
                return result;
            }
        }

        public System.UInt16? Location
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Location", out result);
                return result;
            }
        }

        public System.UInt32? MaxCacheSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxCacheSize", out result);
                return result;
            }
        }

        public System.UInt16[] SupportedSRAM
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("SupportedSRAM", out result);
                return result;
            }
        }
    }
}