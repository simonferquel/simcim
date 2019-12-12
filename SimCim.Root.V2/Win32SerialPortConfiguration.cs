using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SerialPortConfiguration : CIMSetting
    {
        public Win32SerialPortConfiguration()
        {
        }

        public Win32SerialPortConfiguration(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AbortReadWriteOnError
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AbortReadWriteOnError", out result);
                return result;
            }
        }

        public System.UInt32? BaudRate
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BaudRate", out result);
                return result;
            }
        }

        public System.Boolean? BinaryModeEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("BinaryModeEnabled", out result);
                return result;
            }
        }

        public System.UInt32? BitsPerByte
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BitsPerByte", out result);
                return result;
            }
        }

        public System.Boolean? ContinueXMitOnXOff
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ContinueXMitOnXOff", out result);
                return result;
            }
        }

        public System.Boolean? CTSOutflowControl
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CTSOutflowControl", out result);
                return result;
            }
        }

        public System.Boolean? DiscardNULLBytes
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DiscardNULLBytes", out result);
                return result;
            }
        }

        public System.Boolean? DSROutflowControl
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DSROutflowControl", out result);
                return result;
            }
        }

        public System.Boolean? DSRSensitivity
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DSRSensitivity", out result);
                return result;
            }
        }

        public System.String DTRFlowControlType
        {
            get
            {
                System.String result;
                this.GetProperty("DTRFlowControlType", out result);
                return result;
            }
        }

        public System.UInt32? EOFCharacter
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EOFCharacter", out result);
                return result;
            }
        }

        public System.UInt32? ErrorReplaceCharacter
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorReplaceCharacter", out result);
                return result;
            }
        }

        public System.Boolean? ErrorReplacementEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ErrorReplacementEnabled", out result);
                return result;
            }
        }

        public System.UInt32? EventCharacter
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EventCharacter", out result);
                return result;
            }
        }

        public System.Boolean? IsBusy
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsBusy", out result);
                return result;
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.String Parity
        {
            get
            {
                System.String result;
                this.GetProperty("Parity", out result);
                return result;
            }
        }

        public System.Boolean? ParityCheckEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ParityCheckEnabled", out result);
                return result;
            }
        }

        public System.String RTSFlowControlType
        {
            get
            {
                System.String result;
                this.GetProperty("RTSFlowControlType", out result);
                return result;
            }
        }

        public System.String StopBits
        {
            get
            {
                System.String result;
                this.GetProperty("StopBits", out result);
                return result;
            }
        }

        public System.UInt32? XOffCharacter
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("XOffCharacter", out result);
                return result;
            }
        }

        public System.UInt32? XOffXMitThreshold
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("XOffXMitThreshold", out result);
                return result;
            }
        }

        public System.UInt32? XOnCharacter
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("XOnCharacter", out result);
                return result;
            }
        }

        public System.UInt32? XOnXMitThreshold
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("XOnXMitThreshold", out result);
                return result;
            }
        }

        public System.UInt32? XOnXOffInFlowControl
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("XOnXOffInFlowControl", out result);
                return result;
            }
        }

        public System.UInt32? XOnXOffOutFlowControl
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("XOnXOffOutFlowControl", out result);
                return result;
            }
        }

        public Win32SerialPort ResolveWin32SerialPortSettingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SerialPortSetting", "Win32_SerialPort", "Setting", "Element");
            return instances.Select(i => (Win32SerialPort)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}