using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMElementSetting : GenericInfrastructureObject
    {
        protected CIMElementSetting()
        {
        }

        protected CIMElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMManagedSystemElement Element
        {
            get
            {
                CIMManagedSystemElement result;
                this.GetInfrastructureObjectProperty("Element", out result);
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