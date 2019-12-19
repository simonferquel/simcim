using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTPrinterNfcTagTasks : GenericInfrastructureObject
    {
        public MSFTPrinterNfcTagTasks()
        {
        }

        public MSFTPrinterNfcTagTasks(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 WriteByManualSpecification(System.Boolean? inLock, System.String[] inSharePath, System.String[] inWsdAddress)
        {
            var parameters = new CimMethodParametersCollection();
            if (inLock.HasValue)
                parameters.Add(CimMethodParameter.Create("Lock", inLock.Value, CimFlags.None));
            if (inSharePath != null)
                parameters.Add(CimMethodParameter.Create("SharePath", inSharePath, CimType.StringArray, inSharePath == null ? CimFlags.NullValue : CimFlags.None));
            if (inWsdAddress != null)
                parameters.Add(CimMethodParameter.Create("WsdAddress", inWsdAddress, CimType.StringArray, inWsdAddress == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "WriteByManualSpecification", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 WriteByPrinterNfcTag(MSFTPrinterNfcTag inInputObject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inInputObject != null)
                parameters.Add(CimMethodParameter.Create("InputObject", inInputObject.AsCimInstance(), CimType.Instance, inInputObject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "WriteByPrinterNfcTag", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, MSFTPrinterNfcTag outcmdletOutput) Read()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Read", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTPrinterNfcTag)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}