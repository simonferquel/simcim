using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Binary : Win32MSIResource
    {
        public Win32Binary()
        {
        }

        public Win32Binary(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String ProductCode
        {
            get
            {
                System.String result;
                this.GetProperty("ProductCode", out result);
                return result;
            }
        }
    }
}