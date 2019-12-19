using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetIPHttpsState : CIMElementSettingData
    {
        public MSFTNetIPHttpsState()
        {
        }

        public MSFTNetIPHttpsState(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLANEndpoint ManagedElement
        {
            get
            {
                CIMLANEndpoint result;
                this.GetInfrastructureObjectProperty("ManagedElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManagedElement", value);
            }
        }

        public new MSFTNetIPHttpsConfiguration SettingData
        {
            get
            {
                MSFTNetIPHttpsConfiguration result;
                this.GetInfrastructureObjectProperty("SettingData", out result);
                return result;
            }

            set
            {
                this.SetProperty("SettingData", value);
            }
        }

        public System.String InterfaceStatus
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterfaceStatus", value);
            }
        }

        public System.UInt32? LastErrorCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LastErrorCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("LastErrorCode", value);
            }
        }
    }
}