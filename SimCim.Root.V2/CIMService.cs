using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMService : CIMLogicalElement
    {
        protected CIMService()
        {
        }

        protected CIMService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }
        }

        public System.Boolean? Started
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Started", out result);
                return result;
            }
        }

        public System.String StartMode
        {
            get
            {
                System.String result;
                this.GetProperty("StartMode", out result);
                return result;
            }
        }

        public System.String SystemCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemCreationClassName", out result);
                return result;
            }
        }

        public System.String SystemName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemName", out result);
                return result;
            }
        }

        public System.UInt32 StartService()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "StartService", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 StopService()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "StopService", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}