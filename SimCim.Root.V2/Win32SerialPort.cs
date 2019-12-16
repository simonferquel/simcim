using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SerialPort : CIMSerialController
    {
        public Win32SerialPort()
        {
        }

        public Win32SerialPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Binary
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Binary", out result);
                return result;
            }
        }

        public System.UInt32? MaximumInputBufferSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumInputBufferSize", out result);
                return result;
            }
        }

        public System.UInt32? MaximumOutputBufferSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumOutputBufferSize", out result);
                return result;
            }
        }

        public System.Boolean? OSAutoDiscovered
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OSAutoDiscovered", out result);
                return result;
            }
        }

        public System.String ProviderType
        {
            get
            {
                System.String result;
                this.GetProperty("ProviderType", out result);
                return result;
            }
        }

        public System.Boolean? SettableBaudRate
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SettableBaudRate", out result);
                return result;
            }
        }

        public System.Boolean? SettableDataBits
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SettableDataBits", out result);
                return result;
            }
        }

        public System.Boolean? SettableFlowControl
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SettableFlowControl", out result);
                return result;
            }
        }

        public System.Boolean? SettableParity
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SettableParity", out result);
                return result;
            }
        }

        public System.Boolean? SettableParityCheck
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SettableParityCheck", out result);
                return result;
            }
        }

        public System.Boolean? SettableRLSD
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SettableRLSD", out result);
                return result;
            }
        }

        public System.Boolean? SettableStopBits
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SettableStopBits", out result);
                return result;
            }
        }

        public System.Boolean? Supports16BitMode
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Supports16BitMode", out result);
                return result;
            }
        }

        public System.Boolean? SupportsDTRDSR
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsDTRDSR", out result);
                return result;
            }
        }

        public System.Boolean? SupportsElapsedTimeouts
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsElapsedTimeouts", out result);
                return result;
            }
        }

        public System.Boolean? SupportsIntTimeouts
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsIntTimeouts", out result);
                return result;
            }
        }

        public System.Boolean? SupportsParityCheck
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsParityCheck", out result);
                return result;
            }
        }

        public System.Boolean? SupportsRLSD
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsRLSD", out result);
                return result;
            }
        }

        public System.Boolean? SupportsRTSCTS
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsRTSCTS", out result);
                return result;
            }
        }

        public System.Boolean? SupportsSpecialCharacters
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsSpecialCharacters", out result);
                return result;
            }
        }

        public System.Boolean? SupportsXOnXOff
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsXOnXOff", out result);
                return result;
            }
        }

        public System.Boolean? SupportsXOnXOffSet
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SupportsXOnXOffSet", out result);
                return result;
            }
        }

        public Win32POTSModem ResolveWin32POTSModemToSerialPortDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_POTSModemToSerialPort", "Win32_POTSModem", "Antecedent", "Dependent");
            return instances.Select(i => (Win32POTSModem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32SerialPortConfiguration ResolveWin32SerialPortSettingSetting()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SerialPortSetting", "Win32_SerialPortConfiguration", "Element", "Setting");
            return instances.Select(i => (Win32SerialPortConfiguration)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}