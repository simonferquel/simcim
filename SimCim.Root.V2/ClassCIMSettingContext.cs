using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSettingContext : GenericInfrastructureObject
    {
        protected CIMSettingContext()
        {
        }

        protected CIMSettingContext(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMConfiguration Context
        {
            get
            {
                CIMConfiguration result;
                this.GetInfrastructureObjectProperty("Context", out result);
                return result;
            }
        }

        public CIMSetting Setting
        {
            get
            {
                CIMSetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}