using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalProgramGroup : Win32ProgramGroupOrItem
    {
        public Win32LogicalProgramGroup()
        {
        }

        public Win32LogicalProgramGroup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String GroupName
        {
            get
            {
                System.String result;
                this.GetProperty("GroupName", out result);
                return result;
            }
        }

        public System.String UserName
        {
            get
            {
                System.String result;
                this.GetProperty("UserName", out result);
                return result;
            }
        }
    }
}