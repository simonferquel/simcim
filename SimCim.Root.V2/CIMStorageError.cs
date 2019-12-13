using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMStorageError : GenericInfrastructureObject
    {
        protected CIMStorageError()
        {
        }

        protected CIMStorageError(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DeviceCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceCreationClassName", out result);
                return result;
            }
        }

        public System.String DeviceID
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceID", out result);
                return result;
            }
        }

        public System.UInt64? EndingAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EndingAddress", out result);
                return result;
            }
        }

        public System.UInt64 StartingAddress
        {
            get
            {
                System.UInt64 result;
                this.GetProperty("StartingAddress", out result);
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
    }
}