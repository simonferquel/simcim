using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataFaxServiceFaxService : Win32PerfRawData
    {
        public Win32PerfRawDataFaxServiceFaxService()
        {
        }

        public Win32PerfRawDataFaxServiceFaxService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Bytesreceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Bytesreceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("Bytesreceived", value);
            }
        }

        public System.UInt32? Bytessent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Bytessent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Bytessent", value);
            }
        }

        public System.UInt32? Failedfaxestransmissions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Failedfaxestransmissions", out result);
                return result;
            }

            set
            {
                this.SetProperty("Failedfaxestransmissions", value);
            }
        }

        public System.UInt32? Failedoutgoingconnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Failedoutgoingconnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("Failedoutgoingconnections", value);
            }
        }

        public System.UInt32? Failedreceptions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Failedreceptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("Failedreceptions", value);
            }
        }

        public System.UInt32? Faxessent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Faxessent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Faxessent", value);
            }
        }

        public System.UInt32? Minutesreceiving
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Minutesreceiving", out result);
                return result;
            }

            set
            {
                this.SetProperty("Minutesreceiving", value);
            }
        }

        public System.UInt32? Minutessending
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Minutessending", out result);
                return result;
            }

            set
            {
                this.SetProperty("Minutessending", value);
            }
        }

        public System.UInt32? Pagessent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Pagessent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Pagessent", value);
            }
        }

        public System.UInt32? Receivedfaxes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Receivedfaxes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Receivedfaxes", value);
            }
        }

        public System.UInt32? Receivedpages
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Receivedpages", out result);
                return result;
            }

            set
            {
                this.SetProperty("Receivedpages", value);
            }
        }

        public System.UInt32? Totalbytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Totalbytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Totalbytes", value);
            }
        }

        public System.UInt32? Totalfaxessentandreceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Totalfaxessentandreceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("Totalfaxessentandreceived", value);
            }
        }

        public System.UInt32? Totalminutessendingandreceiving
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Totalminutessendingandreceiving", out result);
                return result;
            }

            set
            {
                this.SetProperty("Totalminutessendingandreceiving", value);
            }
        }

        public System.UInt32? Totalpages
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Totalpages", out result);
                return result;
            }

            set
            {
                this.SetProperty("Totalpages", value);
            }
        }
    }
}