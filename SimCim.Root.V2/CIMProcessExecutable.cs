using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class CIMProcessExecutable : CIMDependency
    {
        public CIMProcessExecutable()
        {
        }

        public CIMProcessExecutable(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMDataFile Antecedent
        {
            get
            {
                CIMDataFile result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMProcess Dependent
        {
            get
            {
                CIMProcess result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }

        public System.UInt64? BaseAddress
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BaseAddress", out result);
                return result;
            }
        }

        public System.UInt32? GlobalProcessCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GlobalProcessCount", out result);
                return result;
            }
        }

        public System.UInt32? ModuleInstance
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ModuleInstance", out result);
                return result;
            }
        }

        public System.UInt32? ProcessCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessCount", out result);
                return result;
            }
        }
    }
}