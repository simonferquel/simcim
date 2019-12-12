using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ClientApplicationSetting : GenericInfrastructureObject
    {
        public Win32ClientApplicationSetting()
        {
        }

        public Win32ClientApplicationSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32DCOMApplication Application
        {
            get
            {
                Win32DCOMApplication result;
                this.GetInfrastructureObjectProperty("Application", out result);
                return result;
            }
        }

        public CIMDataFile Client
        {
            get
            {
                CIMDataFile result;
                this.GetInfrastructureObjectProperty("Client", out result);
                return result;
            }
        }
    }
}