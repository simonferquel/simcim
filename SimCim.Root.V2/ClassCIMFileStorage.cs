using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMFileStorage : CIMComponent
    {
        protected CIMFileStorage()
        {
        }

        protected CIMFileStorage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMFileSystem GroupComponent
        {
            get
            {
                CIMFileSystem result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMLogicalFile PartComponent
        {
            get
            {
                CIMLogicalFile result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}