using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ServiceSpecificationService : GenericInfrastructureObject
    {
        public Win32ServiceSpecificationService()
        {
        }

        public Win32ServiceSpecificationService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32ServiceSpecification Check
        {
            get
            {
                Win32ServiceSpecification result;
                this.GetInfrastructureObjectProperty("Check", out result);
                return result;
            }
        }

        public Win32Service Element
        {
            get
            {
                Win32Service result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }
    }
}