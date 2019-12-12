using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPotsModem : CIMLogicalDevice
    {
        protected CIMPotsModem()
        {
        }

        protected CIMPotsModem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AnswerMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AnswerMode", out result);
                return result;
            }
        }

        public System.UInt16? CompressionInfo
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CompressionInfo", out result);
                return result;
            }
        }

        public System.String[] CountriesSupported
        {
            get
            {
                System.String[] result;
                this.GetProperty("CountriesSupported", out result);
                return result;
            }
        }

        public System.String CountrySelected
        {
            get
            {
                System.String result;
                this.GetProperty("CountrySelected", out result);
                return result;
            }
        }

        public System.String[] CurrentPasswords
        {
            get
            {
                System.String[] result;
                this.GetProperty("CurrentPasswords", out result);
                return result;
            }
        }

        public System.UInt16? DialType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DialType", out result);
                return result;
            }
        }

        public System.UInt16? ErrorControlInfo
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ErrorControlInfo", out result);
                return result;
            }
        }

        public System.UInt32? InactivityTimeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InactivityTimeout", out result);
                return result;
            }
        }

        public System.UInt32? MaxBaudRateToPhone
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxBaudRateToPhone", out result);
                return result;
            }
        }

        public System.UInt32? MaxBaudRateToSerialPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxBaudRateToSerialPort", out result);
                return result;
            }
        }

        public System.UInt16? MaxNumberOfPasswords
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MaxNumberOfPasswords", out result);
                return result;
            }
        }

        public System.UInt16? ModulationScheme
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ModulationScheme", out result);
                return result;
            }
        }

        public System.Byte? RingsBeforeAnswer
        {
            get
            {
                System.Byte? result;
                this.GetProperty("RingsBeforeAnswer", out result);
                return result;
            }
        }

        public System.UInt16? SpeakerVolumeInfo
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SpeakerVolumeInfo", out result);
                return result;
            }
        }

        public System.Boolean? SupportsCallback
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsCallback", out result);
                return result;
            }
        }

        public System.Boolean? SupportsSynchronousConnect
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsSynchronousConnect", out result);
                return result;
            }
        }

        public System.DateTime? TimeOfLastReset
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeOfLastReset", out result);
                return result;
            }
        }
    }
}