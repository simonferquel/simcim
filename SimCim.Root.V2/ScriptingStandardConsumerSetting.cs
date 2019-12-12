using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class ScriptingStandardConsumerSetting : CIMSetting
    {
        public ScriptingStandardConsumerSetting()
        {
        }

        public ScriptingStandardConsumerSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? MaximumScripts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumScripts", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaximumScripts", value);
            }
        }

        public System.UInt32? Timeout
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Timeout", out result);
                return result;
            }

            set
            {
                this.SetProperty("Timeout", value);
            }
        }
    }
}