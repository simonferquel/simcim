using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPSignedDriverCIMDataFile : CIMDependency
    {
        public Win32PnPSignedDriverCIMDataFile()
        {
        }

        public Win32PnPSignedDriverCIMDataFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32PnPSignedDriver Antecedent
        {
            get
            {
                Win32PnPSignedDriver result;
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
    }
}