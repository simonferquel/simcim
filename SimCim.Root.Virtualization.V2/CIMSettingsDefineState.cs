using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSettingsDefineState : GenericInfrastructureObject
    {
        protected CIMSettingsDefineState()
        {
        }

        protected CIMSettingsDefineState(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMManagedElement ManagedElement
        {
            get
            {
                CIMManagedElement result;
                this.GetInfrastructureObjectProperty("ManagedElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManagedElement", value);
            }
        }

        public CIMSettingData SettingData
        {
            get
            {
                CIMSettingData result;
                this.GetInfrastructureObjectProperty("SettingData", out result);
                return result;
            }

            set
            {
                this.SetProperty("SettingData", value);
            }
        }
    }
}