using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetEventSession : CIMLogicalElement
    {
        public MSFTNetEventSession()
        {
        }

        public MSFTNetEventSession(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? CaptureMode
        {
            get
            {
                System.Byte? result;
                this.GetProperty("CaptureMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureMode", value);
            }
        }

        public System.String Guid
        {
            get
            {
                System.String result;
                this.GetProperty("Guid", out result);
                return result;
            }

            set
            {
                this.SetProperty("Guid", value);
            }
        }

        public System.String LocalFilePath
        {
            get
            {
                System.String result;
                this.GetProperty("LocalFilePath", out result);
                return result;
            }

            set
            {
                this.SetProperty("LocalFilePath", value);
            }
        }

        public System.UInt32? MaxFileSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxFileSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxFileSize", value);
            }
        }

        public System.Byte? MaxNumberOfBuffers
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MaxNumberOfBuffers", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxNumberOfBuffers", value);
            }
        }

        public System.Byte? SessionStatus
        {
            get
            {
                System.Byte? result;
                this.GetProperty("SessionStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionStatus", value);
            }
        }

        public System.UInt32? TraceBufferSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TraceBufferSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("TraceBufferSize", value);
            }
        }

        public System.UInt32 Start()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Start", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 Stop()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Stop", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}