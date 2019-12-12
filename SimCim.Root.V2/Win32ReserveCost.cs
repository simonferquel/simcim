using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ReserveCost : CIMCheck
    {
        public Win32ReserveCost()
        {
        }

        public Win32ReserveCost(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ReserveFolder
        {
            get
            {
                System.String result;
                this.GetProperty("ReserveFolder", out result);
                return result;
            }
        }

        public System.String ReserveKey
        {
            get
            {
                System.String result;
                this.GetProperty("ReserveKey", out result);
                return result;
            }
        }

        public System.UInt32? ReserveLocal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReserveLocal", out result);
                return result;
            }
        }

        public System.UInt32? ReserveSource
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReserveSource", out result);
                return result;
            }
        }
    }
}