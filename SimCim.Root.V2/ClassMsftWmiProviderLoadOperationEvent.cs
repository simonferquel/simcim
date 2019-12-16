using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderLoadOperationEvent : MsftWmiProviderOperationEvent
    {
        public MsftWmiProviderLoadOperationEvent()
        {
        }

        public MsftWmiProviderLoadOperationEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Clsid
        {
            get
            {
                System.String result;
                this.GetProperty("Clsid", out result);
                return result;
            }

            set
            {
                this.SetProperty("Clsid", value);
            }
        }

        public System.Boolean? InProcServer
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("InProcServer", out result);
                return result;
            }

            set
            {
                this.SetProperty("InProcServer", value);
            }
        }

        public System.String InProcServerPath
        {
            get
            {
                System.String result;
                this.GetProperty("InProcServerPath", out result);
                return result;
            }

            set
            {
                this.SetProperty("InProcServerPath", value);
            }
        }

        public System.Boolean? LocalServer
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LocalServer", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalServer", value);
            }
        }

        public System.String LocalServerPath
        {
            get
            {
                System.String result;
                this.GetProperty("LocalServerPath", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalServerPath", value);
            }
        }

        public System.String ServerName
        {
            get
            {
                System.String result;
                this.GetProperty("ServerName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ServerName", value);
            }
        }

        public System.UInt32? Synchronisation
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Synchronisation", out result);
                return result;
            }

            set
            {
                this.SetProperty("Synchronisation", value);
            }
        }

        public System.UInt32? ThreadingModel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadingModel", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThreadingModel", value);
            }
        }
    }
}