using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMElementSettingData : GenericInfrastructureObject
    {
        public CIMElementSettingData()
        {
        }

        public CIMElementSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? IsCurrent
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IsCurrent", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsCurrent", value);
            }
        }

        public System.UInt16? IsDefault
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IsDefault", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsDefault", value);
            }
        }

        public System.UInt16? IsNext
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IsNext", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsNext", value);
            }
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