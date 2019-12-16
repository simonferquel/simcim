using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32CIMLogicalDeviceCIMDataFile : CIMDependency
    {
        public Win32CIMLogicalDeviceCIMDataFile()
        {
        }

        public Win32CIMLogicalDeviceCIMDataFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLogicalDevice Antecedent
        {
            get
            {
                CIMLogicalDevice result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMDataFile Dependent
        {
            get
            {
                CIMDataFile result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }

        public System.UInt16? Purpose
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Purpose", out result);
                return result;
            }
        }

        public System.String PurposeDescription
        {
            get
            {
                System.String result;
                this.GetProperty("PurposeDescription", out result);
                return result;
            }
        }
    }
}