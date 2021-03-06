﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PrinterDriver : CIMService
    {
        public Win32PrinterDriver()
        {
        }

        public Win32PrinterDriver(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.String DataFile
        {
            get
            {
                System.String result;
                this.GetProperty("DataFile", out result);
                return result;
            }
        }

        public System.String DefaultDataType
        {
            get
            {
                System.String result;
                this.GetProperty("DefaultDataType", out result);
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

        public System.String DriverPath
        {
            get
            {
                System.String result;
                this.GetProperty("DriverPath", out result);
                return result;
            }
        }

        public System.String FilePath
        {
            get
            {
                System.String result;
                this.GetProperty("FilePath", out result);
                return result;
            }

            set
            {
                this.SetProperty("FilePath", value);
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

        public System.String InfName
        {
            get
            {
                System.String result;
                this.GetProperty("InfName", out result);
                return result;
            }

            set
            {
                this.SetProperty("InfName", value);
            }
        }

        public System.String MonitorName
        {
            get
            {
                System.String result;
                this.GetProperty("MonitorName", out result);
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

        public System.String SupportedPlatform
        {
            get
            {
                System.String result;
                this.GetProperty("SupportedPlatform", out result);
                return result;
            }

            set
            {
                this.SetProperty("SupportedPlatform", value);
            }
        }

        public System.UInt16? Version
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Version", out result);
                return result;
            }

            set
            {
                this.SetProperty("Version", value);
            }
        }

        public System.UInt32 AddPrinterDriver(Win32PrinterDriver inDriverInfo)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDriverInfo != null)
                parameters.Add(CimMethodParameter.Create("DriverInfo", inDriverInfo.AsCimInstance(), CimType.Instance, inDriverInfo == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddPrinterDriver", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}