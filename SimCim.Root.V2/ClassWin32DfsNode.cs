using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DfsNode : CIMLogicalElement
    {
        public Win32DfsNode()
        {
        }

        public Win32DfsNode(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Root
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Root", out result);
                return result;
            }

            set
            {
                this.SetProperty("Root", value);
            }
        }

        public System.UInt32? State
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("State", out result);
                return result;
            }

            set
            {
                this.SetProperty("State", value);
            }
        }

        public System.UInt32? Timeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Timeout", out result);
                return result;
            }

            set
            {
                this.SetProperty("Timeout", value);
            }
        }

        public System.UInt32 Create(System.String inDescription, System.String inDfsEntryPath, System.String inServerName, System.String inShareName)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDescription != null)
                parameters.Add(CimMethodParameter.Create("Description", inDescription, CimType.String, inDescription == null ? CimFlags.NullValue : CimFlags.None));
            if (inDfsEntryPath != null)
                parameters.Add(CimMethodParameter.Create("DfsEntryPath", inDfsEntryPath, CimType.String, inDfsEntryPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inServerName != null)
                parameters.Add(CimMethodParameter.Create("ServerName", inServerName, CimType.String, inServerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inShareName != null)
                parameters.Add(CimMethodParameter.Create("ShareName", inShareName, CimType.String, inShareName == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Create", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}