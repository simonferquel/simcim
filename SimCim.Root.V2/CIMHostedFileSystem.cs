using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMHostedFileSystem : CIMSystemComponent
    {
        protected CIMHostedFileSystem()
        {
        }

        protected CIMHostedFileSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMComputerSystem GroupComponent
        {
            get
            {
                CIMComputerSystem result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMFileSystem PartComponent
        {
            get
            {
                CIMFileSystem result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}