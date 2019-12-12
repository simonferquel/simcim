using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics()
        {
        }

        public Win32PerfFormattedDataTCPIPCountersTCPIPPerformanceDiagnostics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Deniedconnectorsendrequestsinlowpowermode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Deniedconnectorsendrequestsinlowpowermode", out result);
                return result;
            }

            set
            {
                this.SetProperty("Deniedconnectorsendrequestsinlowpowermode", value);
            }
        }

        public System.UInt32? IPv4NBLsindicatedwithlowresourceflag
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4NBLsindicatedwithlowresourceflag", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4NBLsindicatedwithlowresourceflag", value);
            }
        }

        public System.UInt32? IPv4NBLsindicatedwithoutprevalidation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4NBLsindicatedwithoutprevalidation", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4NBLsindicatedwithoutprevalidation", value);
            }
        }

        public System.UInt32? IPv4NBLsPersecindicatedwithlowresourceflag
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4NBLsPersecindicatedwithlowresourceflag", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4NBLsPersecindicatedwithlowresourceflag", value);
            }
        }

        public System.UInt32? IPv4NBLsPersecindicatedwithoutprevalidation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4NBLsPersecindicatedwithoutprevalidation", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4NBLsPersecindicatedwithoutprevalidation", value);
            }
        }

        public System.UInt32? IPv4NBLsPersectreatedasnonprevalidated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4NBLsPersectreatedasnonprevalidated", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4NBLsPersectreatedasnonprevalidated", value);
            }
        }

        public System.UInt32? IPv4NBLstreatedasnonprevalidated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4NBLstreatedasnonprevalidated", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4NBLstreatedasnonprevalidated", value);
            }
        }

        public System.UInt32? IPv4outboundNBLsnotprocessedviafastpath
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4outboundNBLsnotprocessedviafastpath", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4outboundNBLsnotprocessedviafastpath", value);
            }
        }

        public System.UInt32? IPv4outboundNBLsPersecnotprocessedviafastpath
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4outboundNBLsPersecnotprocessedviafastpath", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4outboundNBLsPersecnotprocessedviafastpath", value);
            }
        }

        public System.UInt32? IPv6NBLsindicatedwithlowresourceflag
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6NBLsindicatedwithlowresourceflag", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv6NBLsindicatedwithlowresourceflag", value);
            }
        }

        public System.UInt32? IPv6NBLsindicatedwithoutprevalidation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6NBLsindicatedwithoutprevalidation", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv6NBLsindicatedwithoutprevalidation", value);
            }
        }

        public System.UInt32? IPv6NBLsPersecindicatedwithlowresourceflag
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6NBLsPersecindicatedwithlowresourceflag", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv6NBLsPersecindicatedwithlowresourceflag", value);
            }
        }

        public System.UInt32? IPv6NBLsPersecindicatedwithoutprevalidation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6NBLsPersecindicatedwithoutprevalidation", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv6NBLsPersecindicatedwithoutprevalidation", value);
            }
        }

        public System.UInt32? IPv6NBLsPersectreatedasnonprevalidated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6NBLsPersectreatedasnonprevalidated", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv6NBLsPersectreatedasnonprevalidated", value);
            }
        }

        public System.UInt32? IPv6NBLstreatedasnonprevalidated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6NBLstreatedasnonprevalidated", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv6NBLstreatedasnonprevalidated", value);
            }
        }

        public System.UInt32? IPv6outboundNBLsnotprocessedviafastpath
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6outboundNBLsnotprocessedviafastpath", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv6outboundNBLsnotprocessedviafastpath", value);
            }
        }

        public System.UInt32? IPv6outboundNBLsPersecnotprocessedviafastpath
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6outboundNBLsPersecnotprocessedviafastpath", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv6outboundNBLsPersecnotprocessedviafastpath", value);
            }
        }

        public System.UInt32? RSCsegmentforwardingfailuresduringsoftwaresegmentation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RSCsegmentforwardingfailuresduringsoftwaresegmentation", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCsegmentforwardingfailuresduringsoftwaresegmentation", value);
            }
        }

        public System.UInt32? RSCsegmentsforwardedviaLSO
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RSCsegmentsforwardedviaLSO", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCsegmentsforwardedviaLSO", value);
            }
        }

        public System.UInt32? RSCsegmentsforwardedviasoftwaresegmentation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RSCsegmentsforwardedviasoftwaresegmentation", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCsegmentsforwardedviasoftwaresegmentation", value);
            }
        }

        public System.UInt32? RSCsegmentsforwardedviasoftwaresegmentationandchecksum
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RSCsegmentsforwardedviasoftwaresegmentationandchecksum", out result);
                return result;
            }

            set
            {
                this.SetProperty("RSCsegmentsforwardedviasoftwaresegmentationandchecksum", value);
            }
        }

        public System.UInt32? TCPchecksumerrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPchecksumerrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPchecksumerrors", value);
            }
        }

        public System.UInt32? TCPconnectrequestsfallenoffloopbackfastpath
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPconnectrequestsfallenoffloopbackfastpath", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPconnectrequestsfallenoffloopbackfastpath", value);
            }
        }

        public System.UInt32? TCPconnectrequestsPersecfallenoffloopbackfastpath
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPconnectrequestsPersecfallenoffloopbackfastpath", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPconnectrequestsPersecfallenoffloopbackfastpath", value);
            }
        }

        public System.UInt32? TCPinboundsegmentsnotprocessedviafastpath
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPinboundsegmentsnotprocessedviafastpath", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPinboundsegmentsnotprocessedviafastpath", value);
            }
        }

        public System.UInt32? TCPinboundsegmentsPersecnotprocessedviafastpath
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPinboundsegmentsPersecnotprocessedviafastpath", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPinboundsegmentsPersecnotprocessedviafastpath", value);
            }
        }

        public System.UInt32? TCPRSCbytesreceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPRSCbytesreceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPRSCbytesreceived", value);
            }
        }

        public System.UInt32? TCPRSCevents
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPRSCevents", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPRSCevents", value);
            }
        }

        public System.UInt32? TCPtimeouts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TCPtimeouts", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPtimeouts", value);
            }
        }

        public System.UInt32? UDPdatagramscreatedviasoftwaresegmentation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UDPdatagramscreatedviasoftwaresegmentation", out result);
                return result;
            }

            set
            {
                this.SetProperty("UDPdatagramscreatedviasoftwaresegmentation", value);
            }
        }

        public System.UInt32? UDPURObytesreceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UDPURObytesreceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("UDPURObytesreceived", value);
            }
        }

        public System.UInt32? UDPUROevents
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UDPUROevents", out result);
                return result;
            }

            set
            {
                this.SetProperty("UDPUROevents", value);
            }
        }

        public System.UInt32? UROsegmentforwardingfailuresduringsoftwaresegmentation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UROsegmentforwardingfailuresduringsoftwaresegmentation", out result);
                return result;
            }

            set
            {
                this.SetProperty("UROsegmentforwardingfailuresduringsoftwaresegmentation", value);
            }
        }

        public System.UInt32? UROsegmentsforwardedviasoftwaresegmentation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UROsegmentsforwardedviasoftwaresegmentation", out result);
                return result;
            }

            set
            {
                this.SetProperty("UROsegmentsforwardedviasoftwaresegmentation", value);
            }
        }

        public System.UInt32? UROsegmentsforwardedviasoftwaresegmentationandchecksum
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UROsegmentsforwardedviasoftwaresegmentationandchecksum", out result);
                return result;
            }

            set
            {
                this.SetProperty("UROsegmentsforwardedviasoftwaresegmentationandchecksum", value);
            }
        }
    }
}