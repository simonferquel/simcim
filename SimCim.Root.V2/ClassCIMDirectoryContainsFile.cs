using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class CIMDirectoryContainsFile : CIMComponent
    {
        public CIMDirectoryContainsFile()
        {
        }

        public CIMDirectoryContainsFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMDirectory GroupComponent
        {
            get
            {
                CIMDirectory result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMDataFile PartComponent
        {
            get
            {
                CIMDataFile result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}