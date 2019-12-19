using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class CIMManagedSystemElement : CIMManagedElement
    {
        protected CIMManagedSystemElement()
        {
        }

        protected CIMManagedSystemElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? CommunicationStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CommunicationStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("CommunicationStatus", value);
            }
        }

        public System.UInt16? DetailedStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DetailedStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("DetailedStatus", value);
            }
        }

        public System.UInt16? HealthState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HealthState", out result);
                return result;
            }

            set
            {
                this.SetProperty("HealthState", value);
            }
        }

        public System.DateTime? InstallDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("InstallDate", out result);
                return result;
            }

            set
            {
                this.SetProperty("InstallDate", value);
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

            set
            {
                this.SetProperty("Name", value);
            }
        }

        public System.UInt16? OperatingStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("OperatingStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("OperatingStatus", value);
            }
        }

        public System.UInt16[] OperationalStatus
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("OperationalStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("OperationalStatus", value);
            }
        }

        public System.UInt16? PrimaryStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PrimaryStatus", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrimaryStatus", value);
            }
        }

        public System.String Status
        {
            get
            {
                System.String result;
                this.GetProperty("Status", out result);
                return result;
            }

            set
            {
                this.SetProperty("Status", value);
            }
        }

        public System.String[] StatusDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("StatusDescriptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("StatusDescriptions", value);
            }
        }
    }
}