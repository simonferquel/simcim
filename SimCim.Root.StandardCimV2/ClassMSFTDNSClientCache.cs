using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTDNSClientCache : CIMManagedElement
    {
        public MSFTDNSClientCache()
        {
        }

        public MSFTDNSClientCache(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Data
        {
            get
            {
                System.String result;
                this.GetProperty("Data", out result);
                return result;
            }
        }

        public System.UInt16? DataLength
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DataLength", out result);
                return result;
            }
        }

        public System.String Entry
        {
            get
            {
                System.String result;
                this.GetProperty("Entry", out result);
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

        public System.Byte? Section
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Section", out result);
                return result;
            }
        }

        public System.UInt32? Status
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Status", out result);
                return result;
            }
        }

        public System.UInt32? TimeToLive
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TimeToLive", out result);
                return result;
            }
        }

        public System.UInt16? Type
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Type", out result);
                return result;
            }
        }

        public System.UInt32 Clear()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Clear", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}