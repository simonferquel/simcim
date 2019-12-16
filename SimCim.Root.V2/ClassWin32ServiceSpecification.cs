using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ServiceSpecification : CIMCheck
    {
        public Win32ServiceSpecification()
        {
        }

        public Win32ServiceSpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Dependencies
        {
            get
            {
                System.String result;
                this.GetProperty("Dependencies", out result);
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

        public System.Int32? ErrorControl
        {
            get
            {
                System.Int32? result;
                this.GetProperty("ErrorControl", out result);
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

        public System.String LoadOrderGroup
        {
            get
            {
                System.String result;
                this.GetProperty("LoadOrderGroup", out result);
                return result;
            }
        }

        public System.String Password
        {
            get
            {
                System.String result;
                this.GetProperty("Password", out result);
                return result;
            }
        }

        public System.Int32? ServiceType
        {
            get
            {
                System.Int32? result;
                this.GetProperty("ServiceType", out result);
                return result;
            }
        }

        public System.String StartName
        {
            get
            {
                System.String result;
                this.GetProperty("StartName", out result);
                return result;
            }
        }

        public System.Int32? StartType
        {
            get
            {
                System.Int32? result;
                this.GetProperty("StartType", out result);
                return result;
            }
        }
    }
}