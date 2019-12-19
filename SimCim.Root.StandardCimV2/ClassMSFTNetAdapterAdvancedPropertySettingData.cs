using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterAdvancedPropertySettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterAdvancedPropertySettingData()
        {
        }

        public MSFTNetAdapterAdvancedPropertySettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DefaultDisplayValue
        {
            get
            {
                System.String result;
                this.GetProperty("DefaultDisplayValue", out result);
                return result;
            }
        }

        public System.String DefaultRegistryValue
        {
            get
            {
                System.String result;
                this.GetProperty("DefaultRegistryValue", out result);
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

        public System.UInt32? DisplayParameterType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DisplayParameterType", out result);
                return result;
            }
        }

        public System.String DisplayValue
        {
            get
            {
                System.String result;
                this.GetProperty("DisplayValue", out result);
                return result;
            }

            set
            {
                this.SetProperty("DisplayValue", value);
            }
        }

        public System.String NumericParameterBaseValue
        {
            get
            {
                System.String result;
                this.GetProperty("NumericParameterBaseValue", out result);
                return result;
            }
        }

        public System.String NumericParameterMaxValue
        {
            get
            {
                System.String result;
                this.GetProperty("NumericParameterMaxValue", out result);
                return result;
            }
        }

        public System.String NumericParameterMinValue
        {
            get
            {
                System.String result;
                this.GetProperty("NumericParameterMinValue", out result);
                return result;
            }
        }

        public System.String NumericParameterStepValue
        {
            get
            {
                System.String result;
                this.GetProperty("NumericParameterStepValue", out result);
                return result;
            }
        }

        public System.Boolean? Optional
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Optional", out result);
                return result;
            }
        }

        public System.UInt32? RegistryDataType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RegistryDataType", out result);
                return result;
            }

            set
            {
                this.SetProperty("RegistryDataType", value);
            }
        }

        public System.String RegistryKeyword
        {
            get
            {
                System.String result;
                this.GetProperty("RegistryKeyword", out result);
                return result;
            }

            set
            {
                this.SetProperty("RegistryKeyword", value);
            }
        }

        public System.String[] RegistryValue
        {
            get
            {
                System.String[] result;
                this.GetProperty("RegistryValue", out result);
                return result;
            }

            set
            {
                this.SetProperty("RegistryValue", value);
            }
        }

        public System.String[] ValidDisplayValues
        {
            get
            {
                System.String[] result;
                this.GetProperty("ValidDisplayValues", out result);
                return result;
            }
        }

        public System.String[] ValidRegistryValues
        {
            get
            {
                System.String[] result;
                this.GetProperty("ValidRegistryValues", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterAdvancedPropertySettingData outCmdletOutput) Reset()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Reset", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterAdvancedPropertySettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["CmdletOutput"].Value));
        }
    }
}