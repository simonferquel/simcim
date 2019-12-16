using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmKvpExchangeDataItem : CIMManagedElement
    {
        public MsvmKvpExchangeDataItem()
        {
        }

        public MsvmKvpExchangeDataItem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.UInt16? Source
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Source", out result);
                return result;
            }
        }
    }
}