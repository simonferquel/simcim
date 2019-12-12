using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersWFPClassify : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersWFPClassify()
        {
        }

        public Win32PerfFormattedDataCountersWFPClassify(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? FWPMLAYERALEAUTHCONNECTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHCONNECTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHCONNECTV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALEAUTHCONNECTV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHCONNECTV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHCONNECTV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERALEAUTHCONNECTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHCONNECTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHCONNECTV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALEAUTHCONNECTV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHCONNECTV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHCONNECTV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERALEAUTHLISTENV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHLISTENV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHLISTENV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALEAUTHLISTENV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHLISTENV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHLISTENV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERALEAUTHLISTENV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHLISTENV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHLISTENV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALEAUTHLISTENV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHLISTENV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHLISTENV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERALEAUTHRECVACCEPTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHRECVACCEPTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHRECVACCEPTV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALEAUTHRECVACCEPTV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHRECVACCEPTV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHRECVACCEPTV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERALEAUTHRECVACCEPTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHRECVACCEPTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHRECVACCEPTV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALEAUTHRECVACCEPTV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEAUTHRECVACCEPTV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEAUTHRECVACCEPTV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERALEBINDREDIRECTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEBINDREDIRECTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEBINDREDIRECTV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALEBINDREDIRECTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEBINDREDIRECTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEBINDREDIRECTV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALECONNECTREDIRECTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALECONNECTREDIRECTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALECONNECTREDIRECTV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALECONNECTREDIRECTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALECONNECTREDIRECTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALECONNECTREDIRECTV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALEENDPOINTCLOSUREV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEENDPOINTCLOSUREV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEENDPOINTCLOSUREV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALEENDPOINTCLOSUREV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEENDPOINTCLOSUREV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEENDPOINTCLOSUREV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALEFLOWESTABLISHEDV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEFLOWESTABLISHEDV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEFLOWESTABLISHEDV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALEFLOWESTABLISHEDV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEFLOWESTABLISHEDV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEFLOWESTABLISHEDV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERALEFLOWESTABLISHEDV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEFLOWESTABLISHEDV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEFLOWESTABLISHEDV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALEFLOWESTABLISHEDV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEFLOWESTABLISHEDV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEFLOWESTABLISHEDV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERALEPRECLASSIFYIPLOCALADDRESSV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEPRECLASSIFYIPLOCALADDRESSV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEPRECLASSIFYIPLOCALADDRESSV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALEPRECLASSIFYIPLOCALADDRESSV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEPRECLASSIFYIPLOCALADDRESSV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEPRECLASSIFYIPLOCALADDRESSV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALEPRECLASSIFYIPLOCALPORTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEPRECLASSIFYIPLOCALPORTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEPRECLASSIFYIPLOCALPORTV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALEPRECLASSIFYIPLOCALPORTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEPRECLASSIFYIPLOCALPORTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEPRECLASSIFYIPLOCALPORTV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALEPRECLASSIFYIPREMOTEADDRESSV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEPRECLASSIFYIPREMOTEADDRESSV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEPRECLASSIFYIPREMOTEADDRESSV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALEPRECLASSIFYIPREMOTEADDRESSV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEPRECLASSIFYIPREMOTEADDRESSV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEPRECLASSIFYIPREMOTEADDRESSV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALEPRECLASSIFYIPREMOTEPORTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEPRECLASSIFYIPREMOTEPORTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEPRECLASSIFYIPREMOTEPORTV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALEPRECLASSIFYIPREMOTEPORTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALEPRECLASSIFYIPREMOTEPORTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALEPRECLASSIFYIPREMOTEPORTV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALERESOURCEASSIGNMENTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALERESOURCEASSIGNMENTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALERESOURCEASSIGNMENTV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALERESOURCEASSIGNMENTV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALERESOURCEASSIGNMENTV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALERESOURCEASSIGNMENTV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERALERESOURCEASSIGNMENTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALERESOURCEASSIGNMENTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALERESOURCEASSIGNMENTV6", value);
            }
        }

        public System.UInt64? FWPMLAYERALERESOURCEASSIGNMENTV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALERESOURCEASSIGNMENTV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALERESOURCEASSIGNMENTV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERALERESOURCERELEASEV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALERESOURCERELEASEV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALERESOURCERELEASEV4", value);
            }
        }

        public System.UInt64? FWPMLAYERALERESOURCERELEASEV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERALERESOURCERELEASEV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERALERESOURCERELEASEV6", value);
            }
        }

        public System.UInt64? FWPMLAYERDATAGRAMDATAV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERDATAGRAMDATAV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERDATAGRAMDATAV4", value);
            }
        }

        public System.UInt64? FWPMLAYERDATAGRAMDATAV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERDATAGRAMDATAV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERDATAGRAMDATAV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERDATAGRAMDATAV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERDATAGRAMDATAV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERDATAGRAMDATAV6", value);
            }
        }

        public System.UInt64? FWPMLAYERDATAGRAMDATAV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERDATAGRAMDATAV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERDATAGRAMDATAV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYEREGRESSVSWITCHETHERNET
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEREGRESSVSWITCHETHERNET", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEREGRESSVSWITCHETHERNET", value);
            }
        }

        public System.UInt64? FWPMLAYEREGRESSVSWITCHTRANSPORTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEREGRESSVSWITCHTRANSPORTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEREGRESSVSWITCHTRANSPORTV4", value);
            }
        }

        public System.UInt64? FWPMLAYEREGRESSVSWITCHTRANSPORTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEREGRESSVSWITCHTRANSPORTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEREGRESSVSWITCHTRANSPORTV6", value);
            }
        }

        public System.UInt64? FWPMLAYERIKEEXTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERIKEEXTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERIKEEXTV4", value);
            }
        }

        public System.UInt64? FWPMLAYERIKEEXTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERIKEEXTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERIKEEXTV6", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDICMPERRORV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDICMPERRORV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDICMPERRORV4", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDICMPERRORV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDICMPERRORV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDICMPERRORV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDICMPERRORV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDICMPERRORV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDICMPERRORV6", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDICMPERRORV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDICMPERRORV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDICMPERRORV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDIPPACKETV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDIPPACKETV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDIPPACKETV4", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDIPPACKETV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDIPPACKETV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDIPPACKETV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDIPPACKETV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDIPPACKETV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDIPPACKETV6", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDIPPACKETV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDIPPACKETV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDIPPACKETV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDMACFRAMEETHERNET
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDMACFRAMEETHERNET", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDMACFRAMEETHERNET", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDMACFRAMENATIVE
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDMACFRAMENATIVE", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDMACFRAMENATIVE", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDMACFRAMENATIVEFAST
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDMACFRAMENATIVEFAST", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDMACFRAMENATIVEFAST", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDSSLTHROTTLING
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDSSLTHROTTLING", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDSSLTHROTTLING", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDTRANSPORTFAST
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDTRANSPORTFAST", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDTRANSPORTFAST", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDTRANSPORTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDTRANSPORTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDTRANSPORTV4", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDTRANSPORTV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDTRANSPORTV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDTRANSPORTV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDTRANSPORTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDTRANSPORTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDTRANSPORTV6", value);
            }
        }

        public System.UInt64? FWPMLAYERINBOUNDTRANSPORTV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINBOUNDTRANSPORTV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINBOUNDTRANSPORTV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERINGRESSVSWITCHETHERNET
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINGRESSVSWITCHETHERNET", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINGRESSVSWITCHETHERNET", value);
            }
        }

        public System.UInt64? FWPMLAYERINGRESSVSWITCHTRANSPORTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINGRESSVSWITCHTRANSPORTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINGRESSVSWITCHTRANSPORTV4", value);
            }
        }

        public System.UInt64? FWPMLAYERINGRESSVSWITCHTRANSPORTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERINGRESSVSWITCHTRANSPORTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERINGRESSVSWITCHTRANSPORTV6", value);
            }
        }

        public System.UInt64? FWPMLAYERIPFORWARDV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERIPFORWARDV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERIPFORWARDV4", value);
            }
        }

        public System.UInt64? FWPMLAYERIPFORWARDV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERIPFORWARDV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERIPFORWARDV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERIPFORWARDV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERIPFORWARDV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERIPFORWARDV6", value);
            }
        }

        public System.UInt64? FWPMLAYERIPFORWARDV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERIPFORWARDV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERIPFORWARDV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERIPSECKMDEMUXV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERIPSECKMDEMUXV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERIPSECKMDEMUXV4", value);
            }
        }

        public System.UInt64? FWPMLAYERIPSECKMDEMUXV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERIPSECKMDEMUXV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERIPSECKMDEMUXV6", value);
            }
        }

        public System.UInt64? FWPMLAYERIPSECV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERIPSECV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERIPSECV4", value);
            }
        }

        public System.UInt64? FWPMLAYERIPSECV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERIPSECV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERIPSECV6", value);
            }
        }

        public System.UInt64? FWPMLAYERKMAUTHORIZATION
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERKMAUTHORIZATION", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERKMAUTHORIZATION", value);
            }
        }

        public System.UInt64? FWPMLAYERNAMERESOLUTIONCACHEV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERNAMERESOLUTIONCACHEV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERNAMERESOLUTIONCACHEV4", value);
            }
        }

        public System.UInt64? FWPMLAYERNAMERESOLUTIONCACHEV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERNAMERESOLUTIONCACHEV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERNAMERESOLUTIONCACHEV6", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDICMPERRORV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDICMPERRORV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDICMPERRORV4", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDICMPERRORV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDICMPERRORV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDICMPERRORV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDICMPERRORV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDICMPERRORV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDICMPERRORV6", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDICMPERRORV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDICMPERRORV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDICMPERRORV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDIPPACKETV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDIPPACKETV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDIPPACKETV4", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDIPPACKETV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDIPPACKETV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDIPPACKETV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDIPPACKETV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDIPPACKETV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDIPPACKETV6", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDIPPACKETV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDIPPACKETV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDIPPACKETV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDMACFRAMEETHERNET
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDMACFRAMEETHERNET", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDMACFRAMEETHERNET", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDMACFRAMENATIVE
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDMACFRAMENATIVE", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDMACFRAMENATIVE", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDMACFRAMENATIVEFAST
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDMACFRAMENATIVEFAST", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDMACFRAMENATIVEFAST", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDTRANSPORTFAST
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDTRANSPORTFAST", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDTRANSPORTFAST", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDTRANSPORTV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDTRANSPORTV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDTRANSPORTV4", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDTRANSPORTV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDTRANSPORTV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDTRANSPORTV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDTRANSPORTV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDTRANSPORTV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDTRANSPORTV6", value);
            }
        }

        public System.UInt64? FWPMLAYEROUTBOUNDTRANSPORTV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYEROUTBOUNDTRANSPORTV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYEROUTBOUNDTRANSPORTV6DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERRPCEPADD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERRPCEPADD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERRPCEPADD", value);
            }
        }

        public System.UInt64? FWPMLAYERRPCEPMAP
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERRPCEPMAP", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERRPCEPMAP", value);
            }
        }

        public System.UInt64? FWPMLAYERRPCPROXYCONN
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERRPCPROXYCONN", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERRPCPROXYCONN", value);
            }
        }

        public System.UInt64? FWPMLAYERRPCPROXYIF
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERRPCPROXYIF", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERRPCPROXYIF", value);
            }
        }

        public System.UInt64? FWPMLAYERRPCUM
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERRPCUM", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERRPCUM", value);
            }
        }

        public System.UInt64? FWPMLAYERSTREAMPACKETV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERSTREAMPACKETV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERSTREAMPACKETV4", value);
            }
        }

        public System.UInt64? FWPMLAYERSTREAMPACKETV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERSTREAMPACKETV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERSTREAMPACKETV6", value);
            }
        }

        public System.UInt64? FWPMLAYERSTREAMV4
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERSTREAMV4", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERSTREAMV4", value);
            }
        }

        public System.UInt64? FWPMLAYERSTREAMV4DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERSTREAMV4DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERSTREAMV4DISCARD", value);
            }
        }

        public System.UInt64? FWPMLAYERSTREAMV6
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERSTREAMV6", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERSTREAMV6", value);
            }
        }

        public System.UInt64? FWPMLAYERSTREAMV6DISCARD
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FWPMLAYERSTREAMV6DISCARD", out result);
                return result;
            }

            set
            {
                this.SetProperty("FWPMLAYERSTREAMV6DISCARD", value);
            }
        }

        public System.UInt64? Total
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Total", out result);
                return result;
            }

            set
            {
                this.SetProperty("Total", value);
            }
        }
    }
}