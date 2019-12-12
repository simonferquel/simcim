using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PnPSignedDriver : CIMService
    {
        public Win32PnPSignedDriver()
        {
        }

        public Win32PnPSignedDriver(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ClassGuid
        {
            get
            {
                System.String result;
                this.GetProperty("ClassGuid", out result);
                return result;
            }
        }

        public System.String CompatID
        {
            get
            {
                System.String result;
                this.GetProperty("CompatID", out result);
                return result;
            }
        }

        public System.String DeviceClass
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceClass", out result);
                return result;
            }
        }

        public System.String DeviceID
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceID", out result);
                return result;
            }
        }

        public System.String DeviceName
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceName", out result);
                return result;
            }
        }

        public System.String DevLoader
        {
            get
            {
                System.String result;
                this.GetProperty("DevLoader", out result);
                return result;
            }
        }

        public System.DateTime? DriverDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("DriverDate", out result);
                return result;
            }
        }

        public System.String DriverName
        {
            get
            {
                System.String result;
                this.GetProperty("DriverName", out result);
                return result;
            }
        }

        public System.String DriverProviderName
        {
            get
            {
                System.String result;
                this.GetProperty("DriverProviderName", out result);
                return result;
            }
        }

        public System.String DriverVersion
        {
            get
            {
                System.String result;
                this.GetProperty("DriverVersion", out result);
                return result;
            }
        }

        public System.String FriendlyName
        {
            get
            {
                System.String result;
                this.GetProperty("FriendlyName", out result);
                return result;
            }
        }

        public System.String HardWareID
        {
            get
            {
                System.String result;
                this.GetProperty("HardWareID", out result);
                return result;
            }
        }

        public System.String InfName
        {
            get
            {
                System.String result;
                this.GetProperty("InfName", out result);
                return result;
            }
        }

        public System.Boolean? IsSigned
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsSigned", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsSigned", value);
            }
        }

        public System.String Location
        {
            get
            {
                System.String result;
                this.GetProperty("Location", out result);
                return result;
            }
        }

        public System.String Manufacturer
        {
            get
            {
                System.String result;
                this.GetProperty("Manufacturer", out result);
                return result;
            }
        }

        public System.String PDO
        {
            get
            {
                System.String result;
                this.GetProperty("PDO", out result);
                return result;
            }
        }

        public System.String Signer
        {
            get
            {
                System.String result;
                this.GetProperty("Signer", out result);
                return result;
            }
        }

        public CIMDataFile ResolveWin32PnPSignedDriverCIMDataFileDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_PnPSignedDriverCIMDataFile", "CIM_DataFile", "Antecedent", "Dependent");
            return instances.Select(i => (CIMDataFile)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}