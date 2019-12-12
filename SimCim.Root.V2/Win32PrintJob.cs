using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PrintJob : CIMJob
    {
        public Win32PrintJob()
        {
        }

        public Win32PrintJob(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Color
        {
            get
            {
                System.String result;
                this.GetProperty("Color", out result);
                return result;
            }
        }

        public System.String DataType
        {
            get
            {
                System.String result;
                this.GetProperty("DataType", out result);
                return result;
            }
        }

        public System.String Document
        {
            get
            {
                System.String result;
                this.GetProperty("Document", out result);
                return result;
            }
        }

        public System.String DriverName
        {
            get
            {
                System.String result;
                this.GetProperty("DriverName", out result);
                return result;
            }
        }

        public System.String HostPrintQueue
        {
            get
            {
                System.String result;
                this.GetProperty("HostPrintQueue", out result);
                return result;
            }
        }

        public System.UInt32? JobId
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("JobId", out result);
                return result;
            }
        }

        public System.UInt32? PagesPrinted
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PagesPrinted", out result);
                return result;
            }
        }

        public System.UInt32? PaperLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PaperLength", out result);
                return result;
            }
        }

        public System.String PaperSize
        {
            get
            {
                System.String result;
                this.GetProperty("PaperSize", out result);
                return result;
            }
        }

        public System.UInt32? PaperWidth
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PaperWidth", out result);
                return result;
            }
        }

        public System.String Parameters
        {
            get
            {
                System.String result;
                this.GetProperty("Parameters", out result);
                return result;
            }
        }

        public System.String PrintProcessor
        {
            get
            {
                System.String result;
                this.GetProperty("PrintProcessor", out result);
                return result;
            }
        }

        public System.UInt32? Size
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Size", out result);
                return result;
            }
        }

        public System.UInt32? SizeHigh
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SizeHigh", out result);
                return result;
            }
        }

        public System.UInt32? StatusMask
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StatusMask", out result);
                return result;
            }
        }

        public System.UInt32? TotalPages
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalPages", out result);
                return result;
            }
        }

        public System.UInt32 Pause()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Pause", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Resume()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Resume", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}