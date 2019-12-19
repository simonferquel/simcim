using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTPrinterPortTasks : GenericInfrastructureObject
    {
        public MSFTPrinterPortTasks()
        {
        }

        public MSFTPrinterPortTasks(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 AddByLocalPort(System.String inComputerName, System.String inName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddByLocalPort", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 AddByLprPort(System.String inComputerName, System.String inHostName, System.String inPrinterName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inHostName != null)
                parameters.Add(CimMethodParameter.Create("HostName", inHostName, CimType.String, inHostName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPrinterName != null)
                parameters.Add(CimMethodParameter.Create("PrinterName", inPrinterName, CimType.String, inPrinterName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddByLprPort", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 AddByTcpPort(System.String inComputerName, System.String inName, System.UInt32? inPortNumber, System.String inPrinterHostAddress, System.UInt32? inSNMP, System.String inSNMPCommunity)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPortNumber.HasValue)
                parameters.Add(CimMethodParameter.Create("PortNumber", inPortNumber.Value, CimFlags.None));
            if (inPrinterHostAddress != null)
                parameters.Add(CimMethodParameter.Create("PrinterHostAddress", inPrinterHostAddress, CimType.String, inPrinterHostAddress == null ? CimFlags.NullValue : CimFlags.None));
            if (inSNMP.HasValue)
                parameters.Add(CimMethodParameter.Create("SNMP", inSNMP.Value, CimFlags.None));
            if (inSNMPCommunity != null)
                parameters.Add(CimMethodParameter.Create("SNMPCommunity", inSNMPCommunity, CimType.String, inSNMPCommunity == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddByTcpPort", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 AddByTcpPortLprMode(System.String inComputerName, System.Boolean? inLprByteCounting, System.String inLprHostAddress, System.String inLprQueueName, System.String inName, System.UInt32? inPortNumber, System.UInt32? inSNMP, System.String inSNMPCommunity)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inLprByteCounting.HasValue)
                parameters.Add(CimMethodParameter.Create("LprByteCounting", inLprByteCounting.Value, CimFlags.None));
            if (inLprHostAddress != null)
                parameters.Add(CimMethodParameter.Create("LprHostAddress", inLprHostAddress, CimType.String, inLprHostAddress == null ? CimFlags.NullValue : CimFlags.None));
            if (inLprQueueName != null)
                parameters.Add(CimMethodParameter.Create("LprQueueName", inLprQueueName, CimType.String, inLprQueueName == null ? CimFlags.NullValue : CimFlags.None));
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPortNumber.HasValue)
                parameters.Add(CimMethodParameter.Create("PortNumber", inPortNumber.Value, CimFlags.None));
            if (inSNMP.HasValue)
                parameters.Add(CimMethodParameter.Create("SNMP", inSNMP.Value, CimFlags.None));
            if (inSNMPCommunity != null)
                parameters.Add(CimMethodParameter.Create("SNMPCommunity", inSNMPCommunity, CimType.String, inSNMPCommunity == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddByTcpPortLprMode", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}