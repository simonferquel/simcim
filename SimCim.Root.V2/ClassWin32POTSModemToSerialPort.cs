using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32POTSModemToSerialPort : CIMControlledBy
    {
        public Win32POTSModemToSerialPort()
        {
        }

        public Win32POTSModemToSerialPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32SerialPort Antecedent
        {
            get
            {
                Win32SerialPort result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32POTSModem Dependent
        {
            get
            {
                Win32POTSModem result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}