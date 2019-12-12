using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataNETDataProviderforSqlServerNETDataProviderforSqlServer : Win32PerfRawData
    {
        public Win32PerfRawDataNETDataProviderforSqlServerNETDataProviderforSqlServer()
        {
        }

        public Win32PerfRawDataNETDataProviderforSqlServerNETDataProviderforSqlServer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? HardConnectsPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HardConnectsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("HardConnectsPerSecond", value);
            }
        }

        public System.UInt32? HardDisconnectsPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HardDisconnectsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("HardDisconnectsPerSecond", value);
            }
        }

        public System.UInt32? NumberOfActiveConnectionPoolGroups
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfActiveConnectionPoolGroups", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfActiveConnectionPoolGroups", value);
            }
        }

        public System.UInt32? NumberOfActiveConnectionPools
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfActiveConnectionPools", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfActiveConnectionPools", value);
            }
        }

        public System.UInt32? NumberOfActiveConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfActiveConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfActiveConnections", value);
            }
        }

        public System.UInt32? NumberOfFreeConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfFreeConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfFreeConnections", value);
            }
        }

        public System.UInt32? NumberOfInactiveConnectionPoolGroups
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfInactiveConnectionPoolGroups", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfInactiveConnectionPoolGroups", value);
            }
        }

        public System.UInt32? NumberOfInactiveConnectionPools
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfInactiveConnectionPools", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfInactiveConnectionPools", value);
            }
        }

        public System.UInt32? NumberOfNonPooledConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfNonPooledConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfNonPooledConnections", value);
            }
        }

        public System.UInt32? NumberOfPooledConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfPooledConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfPooledConnections", value);
            }
        }

        public System.UInt32? NumberOfReclaimedConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfReclaimedConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfReclaimedConnections", value);
            }
        }

        public System.UInt32? NumberOfStasisConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfStasisConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfStasisConnections", value);
            }
        }

        public System.UInt32? SoftConnectsPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SoftConnectsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("SoftConnectsPerSecond", value);
            }
        }

        public System.UInt32? SoftDisconnectsPerSecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SoftDisconnectsPerSecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("SoftDisconnectsPerSecond", value);
            }
        }
    }
}