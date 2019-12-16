using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataOfflineFilesClientSideCaching : Win32PerfRawData
    {
        public Win32PerfRawDataOfflineFilesClientSideCaching()
        {
        }

        public Win32PerfRawDataOfflineFilesClientSideCaching(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? ApplicationBytesReadFromCache
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ApplicationBytesReadFromCache", out result);
                return result;
            }

            set
            {
                this.SetProperty("ApplicationBytesReadFromCache", value);
            }
        }

        public System.UInt64? ApplicationBytesReadFromServer
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ApplicationBytesReadFromServer", out result);
                return result;
            }

            set
            {
                this.SetProperty("ApplicationBytesReadFromServer", value);
            }
        }

        public System.UInt64? ApplicationBytesReadFromServerNotCached
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ApplicationBytesReadFromServerNotCached", out result);
                return result;
            }

            set
            {
                this.SetProperty("ApplicationBytesReadFromServerNotCached", value);
            }
        }

        public System.UInt64? PrefetchBytesReadFromCache
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PrefetchBytesReadFromCache", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrefetchBytesReadFromCache", value);
            }
        }

        public System.UInt64? PrefetchBytesReadFromServer
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PrefetchBytesReadFromServer", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrefetchBytesReadFromServer", value);
            }
        }

        public System.UInt32? PrefetchOperationsQueued
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PrefetchOperationsQueued", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrefetchOperationsQueued", value);
            }
        }

        public System.UInt64? SMBBranchCacheBytesPublished
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBBranchCacheBytesPublished", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheBytesPublished", value);
            }
        }

        public System.UInt64? SMBBranchCacheBytesReceived
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBBranchCacheBytesReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheBytesReceived", value);
            }
        }

        public System.UInt64? SMBBranchCacheBytesRequested
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBBranchCacheBytesRequested", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheBytesRequested", value);
            }
        }

        public System.UInt64? SMBBranchCacheBytesRequestedFromServer
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBBranchCacheBytesRequestedFromServer", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheBytesRequestedFromServer", value);
            }
        }

        public System.UInt64? SMBBranchCacheHashBytesReceived
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SMBBranchCacheHashBytesReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashBytesReceived", value);
            }
        }

        public System.UInt32? SMBBranchCacheHashesReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBBranchCacheHashesReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashesReceived", value);
            }
        }

        public System.UInt32? SMBBranchCacheHashesRequested
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SMBBranchCacheHashesRequested", out result);
                return result;
            }

            set
            {
                this.SetProperty("SMBBranchCacheHashesRequested", value);
            }
        }
    }
}