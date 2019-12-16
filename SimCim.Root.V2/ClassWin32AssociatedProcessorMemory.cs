using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32AssociatedProcessorMemory : CIMAssociatedProcessorMemory
    {
        public Win32AssociatedProcessorMemory()
        {
        }

        public Win32AssociatedProcessorMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32CacheMemory Antecedent
        {
            get
            {
                Win32CacheMemory result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32Processor Dependent
        {
            get
            {
                Win32Processor result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}