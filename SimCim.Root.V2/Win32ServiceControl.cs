using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ServiceControl : Win32MSIResource
    {
        public Win32ServiceControl()
        {
        }

        public Win32ServiceControl(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Arguments
        {
            get
            {
                System.String result;
                this.GetProperty("Arguments", out result);
                return result;
            }
        }

        public System.String Event
        {
            get
            {
                System.String result;
                this.GetProperty("Event", out result);
                return result;
            }
        }

        public System.String ID
        {
            get
            {
                System.String result;
                this.GetProperty("ID", out result);
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

        public System.String ProductCode
        {
            get
            {
                System.String result;
                this.GetProperty("ProductCode", out result);
                return result;
            }
        }

        public System.UInt16? Wait
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Wait", out result);
                return result;
            }
        }
    }
}