using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMExecuteProgram : CIMAction
    {
        protected CIMExecuteProgram()
        {
        }

        protected CIMExecuteProgram(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CommandLine
        {
            get
            {
                System.String result;
                this.GetProperty("CommandLine", out result);
                return result;
            }
        }

        public System.String ProgramPath
        {
            get
            {
                System.String result;
                this.GetProperty("ProgramPath", out result);
                return result;
            }
        }
    }
}