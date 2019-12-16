using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class ExtendedStatus : NotifyStatus
    {
        public ExtendedStatus()
        {
        }

        public ExtendedStatus(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Description
        {
            get
            {
                System.String result;
                this.GetProperty("Description", out result);
                return result;
            }

            set
            {
                this.SetProperty("Description", value);
            }
        }

        public System.String Operation
        {
            get
            {
                System.String result;
                this.GetProperty("Operation", out result);
                return result;
            }

            set
            {
                this.SetProperty("Operation", value);
            }
        }

        public System.String ParameterInfo
        {
            get
            {
                System.String result;
                this.GetProperty("ParameterInfo", out result);
                return result;
            }

            set
            {
                this.SetProperty("ParameterInfo", value);
            }
        }

        public System.String ProviderName
        {
            get
            {
                System.String result;
                this.GetProperty("ProviderName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderName", value);
            }
        }
    }
}