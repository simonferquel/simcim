using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataRemotePerfProviderHyperVVMRemoting : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataRemotePerfProviderHyperVVMRemoting()
        {
        }

        public Win32PerfFormattedDataRemotePerfProviderHyperVVMRemoting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ConnectedClients
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectedClients", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectedClients", value);
            }
        }

        public System.UInt32? UpdatedPixelsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UpdatedPixelsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("UpdatedPixelsPersec", value);
            }
        }
    }
}