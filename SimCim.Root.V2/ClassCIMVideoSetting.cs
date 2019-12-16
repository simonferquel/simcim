using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMVideoSetting : CIMElementSetting
    {
        protected CIMVideoSetting()
        {
        }

        protected CIMVideoSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMVideoController Element
        {
            get
            {
                CIMVideoController result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new CIMVideoControllerResolution Setting
        {
            get
            {
                CIMVideoControllerResolution result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}