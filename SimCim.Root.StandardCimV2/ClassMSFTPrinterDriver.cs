using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTPrinterDriver : CIMManagedSystemElement
    {
        public MSFTPrinterDriver()
        {
        }

        public MSFTPrinterDriver(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] ColorProfiles
        {
            get
            {
                System.String[] result;
                this.GetProperty("ColorProfiles", out result);
                return result;
            }
        }

        public System.String ComputerName
        {
            get
            {
                System.String result;
                this.GetProperty("ComputerName", out result);
                return result;
            }
        }

        public System.String ConfigFile
        {
            get
            {
                System.String result;
                this.GetProperty("ConfigFile", out result);
                return result;
            }
        }

        public System.String[] CoreDriverDependencies
        {
            get
            {
                System.String[] result;
                this.GetProperty("CoreDriverDependencies", out result);
                return result;
            }
        }

        public System.String DataFile
        {
            get
            {
                System.String result;
                this.GetProperty("DataFile", out result);
                return result;
            }
        }

        public System.DateTime? Date
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("Date", out result);
                return result;
            }
        }

        public System.String DefaultDatatype
        {
            get
            {
                System.String result;
                this.GetProperty("DefaultDatatype", out result);
                return result;
            }
        }

        public System.String[] DependentFiles
        {
            get
            {
                System.String[] result;
                this.GetProperty("DependentFiles", out result);
                return result;
            }
        }

        public System.UInt64? DriverVersion
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DriverVersion", out result);
                return result;
            }
        }

        public System.String HardwareID
        {
            get
            {
                System.String result;
                this.GetProperty("HardwareID", out result);
                return result;
            }
        }

        public System.String HelpFile
        {
            get
            {
                System.String result;
                this.GetProperty("HelpFile", out result);
                return result;
            }
        }

        public System.String InfPath
        {
            get
            {
                System.String result;
                this.GetProperty("InfPath", out result);
                return result;
            }
        }

        public System.Boolean? IsPackageAware
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsPackageAware", out result);
                return result;
            }
        }

        public System.UInt32? MajorVersion
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MajorVersion", out result);
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

        public System.String Monitor
        {
            get
            {
                System.String result;
                this.GetProperty("Monitor", out result);
                return result;
            }
        }

        public System.String OEMUrl
        {
            get
            {
                System.String result;
                this.GetProperty("OEMUrl", out result);
                return result;
            }
        }

        public System.String Path
        {
            get
            {
                System.String result;
                this.GetProperty("Path", out result);
                return result;
            }
        }

        public System.String[] PreviousCompatibleNames
        {
            get
            {
                System.String[] result;
                this.GetProperty("PreviousCompatibleNames", out result);
                return result;
            }
        }

        public System.String PrinterEnvironment
        {
            get
            {
                System.String result;
                this.GetProperty("PrinterEnvironment", out result);
                return result;
            }
        }

        public System.String PrintProcessor
        {
            get
            {
                System.String result;
                this.GetProperty("PrintProcessor", out result);
                return result;
            }
        }

        public System.String Provider
        {
            get
            {
                System.String result;
                this.GetProperty("provider", out result);
                return result;
            }
        }

        public System.String VendorSetup
        {
            get
            {
                System.String result;
                this.GetProperty("VendorSetup", out result);
                return result;
            }
        }

        public System.UInt32 Add(System.String inComputerName, System.String inInfPath, System.String inName, System.String inPrinterEnvironment)
        {
            var parameters = new CimMethodParametersCollection();
            if (inComputerName != null)
                parameters.Add(CimMethodParameter.Create("ComputerName", inComputerName, CimType.String, inComputerName == null ? CimFlags.NullValue : CimFlags.None));
            if (inInfPath != null)
                parameters.Add(CimMethodParameter.Create("InfPath", inInfPath, CimType.String, inInfPath == null ? CimFlags.NullValue : CimFlags.None));
            if (inName != null)
                parameters.Add(CimMethodParameter.Create("Name", inName, CimType.String, inName == null ? CimFlags.NullValue : CimFlags.None));
            if (inPrinterEnvironment != null)
                parameters.Add(CimMethodParameter.Create("PrinterEnvironment", inPrinterEnvironment, CimType.String, inPrinterEnvironment == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Add", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}