using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterSettingData : MSFTNetSettingData
    {
        public MSFTNetAdapterSettingData()
        {
        }

        public MSFTNetAdapterSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String InterfaceDescription
        {
            get
            {
                System.String result;
                this.GetProperty("InterfaceDescription", out result);
                return result;
            }
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }
        }

        public System.UInt32? Source
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Source", out result);
                return result;
            }
        }

        public System.String SystemName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemName", out result);
                return result;
            }
        }
    }
}