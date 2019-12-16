using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDirectorySpecificationFile : GenericInfrastructureObject
    {
        protected CIMDirectorySpecificationFile()
        {
        }

        protected CIMDirectorySpecificationFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMDirectorySpecification DirectorySpecification
        {
            get
            {
                CIMDirectorySpecification result;
                this.GetInfrastructureObjectProperty("DirectorySpecification", out result);
                return result;
            }
        }

        public CIMFileSpecification FileSpecification
        {
            get
            {
                CIMFileSpecification result;
                this.GetInfrastructureObjectProperty("FileSpecification", out result);
                return result;
            }
        }
    }
}