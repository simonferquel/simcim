using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataSMSvcHost4000SMSvcHost4000 : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataSMSvcHost4000SMSvcHost4000()
        {
        }

        public Win32PerfFormattedDataSMSvcHost4000SMSvcHost4000(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ConnectionsAcceptedovernetpipe
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionsAcceptedovernetpipe", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionsAcceptedovernetpipe", value);
            }
        }

        public System.UInt32? ConnectionsAcceptedovernettcp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionsAcceptedovernettcp", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionsAcceptedovernettcp", value);
            }
        }

        public System.UInt32? ConnectionsDispatchedovernetpipe
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionsDispatchedovernetpipe", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionsDispatchedovernetpipe", value);
            }
        }

        public System.UInt32? ConnectionsDispatchedovernettcp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionsDispatchedovernettcp", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionsDispatchedovernettcp", value);
            }
        }

        public System.UInt32? DispatchFailuresovernetpipe
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DispatchFailuresovernetpipe", out result);
                return result;
            }

            set
            {
                this.SetProperty("DispatchFailuresovernetpipe", value);
            }
        }

        public System.UInt32? DispatchFailuresovernettcp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DispatchFailuresovernettcp", out result);
                return result;
            }

            set
            {
                this.SetProperty("DispatchFailuresovernettcp", value);
            }
        }

        public System.UInt32? ProtocolFailuresovernetpipe
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProtocolFailuresovernetpipe", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolFailuresovernetpipe", value);
            }
        }

        public System.UInt32? ProtocolFailuresovernettcp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProtocolFailuresovernettcp", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProtocolFailuresovernettcp", value);
            }
        }

        public System.UInt32? RegistrationsActivefornetpipe
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RegistrationsActivefornetpipe", out result);
                return result;
            }

            set
            {
                this.SetProperty("RegistrationsActivefornetpipe", value);
            }
        }

        public System.UInt32? RegistrationsActivefornettcp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RegistrationsActivefornettcp", out result);
                return result;
            }

            set
            {
                this.SetProperty("RegistrationsActivefornettcp", value);
            }
        }

        public System.UInt32? UrisRegisteredfornetpipe
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UrisRegisteredfornetpipe", out result);
                return result;
            }

            set
            {
                this.SetProperty("UrisRegisteredfornetpipe", value);
            }
        }

        public System.UInt32? UrisRegisteredfornettcp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UrisRegisteredfornettcp", out result);
                return result;
            }

            set
            {
                this.SetProperty("UrisRegisteredfornettcp", value);
            }
        }

        public System.UInt32? UrisUnregisteredfornetpipe
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UrisUnregisteredfornetpipe", out result);
                return result;
            }

            set
            {
                this.SetProperty("UrisUnregisteredfornetpipe", value);
            }
        }

        public System.UInt32? UrisUnregisteredfornettcp
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UrisUnregisteredfornettcp", out result);
                return result;
            }

            set
            {
                this.SetProperty("UrisUnregisteredfornettcp", value);
            }
        }
    }
}