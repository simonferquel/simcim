using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetTeredoState : CIMElementSettingData
    {
        public MSFTNetTeredoState()
        {
        }

        public MSFTNetTeredoState(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new MSFTNetTeredoConfiguration SettingData
        {
            get
            {
                MSFTNetTeredoConfiguration result;
                this.GetInfrastructureObjectProperty("SettingData", out result);
                return result;
            }

            set
            {
                this.SetProperty("SettingData", value);
            }
        }

        public System.String Error
        {
            get
            {
                System.String result;
                this.GetProperty("Error", out result);
                return result;
            }
        }

        public System.String State
        {
            get
            {
                System.String result;
                this.GetProperty("State", out result);
                return result;
            }
        }
    }
}