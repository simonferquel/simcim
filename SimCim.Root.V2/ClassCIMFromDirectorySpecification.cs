using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMFromDirectorySpecification : GenericInfrastructureObject
    {
        protected CIMFromDirectorySpecification()
        {
        }

        protected CIMFromDirectorySpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMFileAction FileName
        {
            get
            {
                CIMFileAction result;
                this.GetInfrastructureObjectProperty("FileName", out result);
                return result;
            }
        }

        public CIMDirectorySpecification SourceDirectory
        {
            get
            {
                CIMDirectorySpecification result;
                this.GetInfrastructureObjectProperty("SourceDirectory", out result);
                return result;
            }
        }
    }
}