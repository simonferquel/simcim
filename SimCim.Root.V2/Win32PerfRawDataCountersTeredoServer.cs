using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersTeredoServer : Win32PerfRawData
    {
        public Win32PerfRawDataCountersTeredoServer()
        {
        }

        public Win32PerfRawDataCountersTeredoServer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? InTeredoServerErrorPacketsAuthenticationError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerErrorPacketsAuthenticationError", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerErrorPacketsAuthenticationError", value);
            }
        }

        public System.UInt32? InTeredoServerErrorPacketsDestinationError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerErrorPacketsDestinationError", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerErrorPacketsDestinationError", value);
            }
        }

        public System.UInt32? InTeredoServerErrorPacketsHeaderError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerErrorPacketsHeaderError", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerErrorPacketsHeaderError", value);
            }
        }

        public System.UInt32? InTeredoServerErrorPacketsSourceError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerErrorPacketsSourceError", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerErrorPacketsSourceError", value);
            }
        }

        public System.UInt32? InTeredoServerErrorPacketsTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerErrorPacketsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerErrorPacketsTotal", value);
            }
        }

        public System.UInt32? InTeredoServerSuccessPacketsBubbles
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerSuccessPacketsBubbles", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerSuccessPacketsBubbles", value);
            }
        }

        public System.UInt32? InTeredoServerSuccessPacketsEcho
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerSuccessPacketsEcho", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerSuccessPacketsEcho", value);
            }
        }

        public System.UInt32? InTeredoServerSuccessPacketsRSPrimary
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerSuccessPacketsRSPrimary", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerSuccessPacketsRSPrimary", value);
            }
        }

        public System.UInt32? InTeredoServerSuccessPacketsRSSecondary
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerSuccessPacketsRSSecondary", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerSuccessPacketsRSSecondary", value);
            }
        }

        public System.UInt32? InTeredoServerSuccessPacketsTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerSuccessPacketsTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerSuccessPacketsTotal", value);
            }
        }

        public System.UInt32? InTeredoServerTotalPacketsSuccessError
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerTotalPacketsSuccessError", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerTotalPacketsSuccessError", value);
            }
        }

        public System.UInt32? InTeredoServerTotalPacketsSuccessErrorPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InTeredoServerTotalPacketsSuccessErrorPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InTeredoServerTotalPacketsSuccessErrorPersec", value);
            }
        }

        public System.UInt32? OutTeredoServerRAPrimary
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutTeredoServerRAPrimary", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoServerRAPrimary", value);
            }
        }

        public System.UInt32? OutTeredoServerRASecondary
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutTeredoServerRASecondary", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutTeredoServerRASecondary", value);
            }
        }
    }
}