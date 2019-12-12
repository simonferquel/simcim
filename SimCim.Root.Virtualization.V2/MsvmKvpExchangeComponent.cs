using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmKvpExchangeComponent : CIMLogicalDevice
    {
        public MsvmKvpExchangeComponent()
        {
        }

        public MsvmKvpExchangeComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] GuestExchangeItems
        {
            get
            {
                System.String[] result;
                this.GetProperty("GuestExchangeItems", out result);
                return result;
            }
        }

        public System.String[] GuestIntrinsicExchangeItems
        {
            get
            {
                System.String[] result;
                this.GetProperty("GuestIntrinsicExchangeItems", out result);
                return result;
            }
        }
    }
}