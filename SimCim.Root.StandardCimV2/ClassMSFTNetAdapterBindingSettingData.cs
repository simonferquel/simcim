using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterBindingSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterBindingSettingData()
        {
        }

        public MSFTNetAdapterBindingSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String BindName
        {
            get
            {
                System.String result;
                this.GetProperty("BindName", out result);
                return result;
            }
        }

        public System.UInt32? Characteristics
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Characteristics", out result);
                return result;
            }
        }

        public System.String ComponentClassGuid
        {
            get
            {
                System.String result;
                this.GetProperty("ComponentClassGuid", out result);
                return result;
            }
        }

        public System.String ComponentClassName
        {
            get
            {
                System.String result;
                this.GetProperty("ComponentClassName", out result);
                return result;
            }
        }

        public System.String ComponentID
        {
            get
            {
                System.String result;
                this.GetProperty("ComponentID", out result);
                return result;
            }
        }

        public System.String DisplayName
        {
            get
            {
                System.String result;
                this.GetProperty("DisplayName", out result);
                return result;
            }
        }

        public System.Boolean? Enabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("Enabled", value);
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterBindingSettingData outcmdletOutput) Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterBindingSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterBindingSettingData outcmdletOutput) Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterBindingSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}