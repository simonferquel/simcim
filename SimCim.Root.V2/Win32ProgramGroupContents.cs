using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ProgramGroupContents : CIMComponent
    {
        public Win32ProgramGroupContents()
        {
        }

        public Win32ProgramGroupContents(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32LogicalProgramGroup GroupComponent
        {
            get
            {
                Win32LogicalProgramGroup result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new Win32ProgramGroupOrItem PartComponent
        {
            get
            {
                Win32ProgramGroupOrItem result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}