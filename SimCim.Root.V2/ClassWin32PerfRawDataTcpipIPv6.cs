using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataTcpipIPv6 : Win32PerfRawData
    {
        public Win32PerfRawDataTcpipIPv6()
        {
        }

        public Win32PerfRawDataTcpipIPv6(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? DatagramsForwardedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsForwardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsForwardedPersec", value);
            }
        }

        public System.UInt32? DatagramsOutboundDiscarded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsOutboundDiscarded", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsOutboundDiscarded", value);
            }
        }

        public System.UInt32? DatagramsOutboundNoRoute
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsOutboundNoRoute", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsOutboundNoRoute", value);
            }
        }

        public System.UInt32? DatagramsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsPersec", value);
            }
        }

        public System.UInt32? DatagramsReceivedAddressErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsReceivedAddressErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsReceivedAddressErrors", value);
            }
        }

        public System.UInt32? DatagramsReceivedDeliveredPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsReceivedDeliveredPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsReceivedDeliveredPersec", value);
            }
        }

        public System.UInt32? DatagramsReceivedDiscarded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsReceivedDiscarded", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsReceivedDiscarded", value);
            }
        }

        public System.UInt32? DatagramsReceivedHeaderErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsReceivedHeaderErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsReceivedHeaderErrors", value);
            }
        }

        public System.UInt32? DatagramsReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsReceivedPersec", value);
            }
        }

        public System.UInt32? DatagramsReceivedUnknownProtocol
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsReceivedUnknownProtocol", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsReceivedUnknownProtocol", value);
            }
        }

        public System.UInt32? DatagramsSentPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsSentPersec", value);
            }
        }

        public System.UInt32? FragmentationFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FragmentationFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("FragmentationFailures", value);
            }
        }

        public System.UInt32? FragmentedDatagramsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FragmentedDatagramsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FragmentedDatagramsPersec", value);
            }
        }

        public System.UInt32? FragmentReassemblyFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FragmentReassemblyFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("FragmentReassemblyFailures", value);
            }
        }

        public System.UInt32? FragmentsCreatedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FragmentsCreatedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FragmentsCreatedPersec", value);
            }
        }

        public System.UInt32? FragmentsReassembledPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FragmentsReassembledPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FragmentsReassembledPersec", value);
            }
        }

        public System.UInt32? FragmentsReceivedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FragmentsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FragmentsReceivedPersec", value);
            }
        }
    }
}