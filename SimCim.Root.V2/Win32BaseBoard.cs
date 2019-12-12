using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32BaseBoard : CIMCard
    {
        public Win32BaseBoard()
        {
        }

        public Win32BaseBoard(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] ConfigOptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("ConfigOptions", out result);
                return result;
            }
        }

        public System.String Product
        {
            get
            {
                System.String result;
                this.GetProperty("Product", out result);
                return result;
            }
        }
    }
}