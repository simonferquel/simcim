using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ClassicCOMClassSetting : Win32COMSetting
    {
        public Win32ClassicCOMClassSetting()
        {
        }

        public Win32ClassicCOMClassSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AppID
        {
            get
            {
                System.String result;
                this.GetProperty("AppID", out result);
                return result;
            }
        }

        public System.String AutoConvertToClsid
        {
            get
            {
                System.String result;
                this.GetProperty("AutoConvertToClsid", out result);
                return result;
            }
        }

        public System.String AutoTreatAsClsid
        {
            get
            {
                System.String result;
                this.GetProperty("AutoTreatAsClsid", out result);
                return result;
            }
        }

        public System.String ComponentId
        {
            get
            {
                System.String result;
                this.GetProperty("ComponentId", out result);
                return result;
            }
        }

        public System.Boolean? Control
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Control", out result);
                return result;
            }
        }

        public System.String DefaultIcon
        {
            get
            {
                System.String result;
                this.GetProperty("DefaultIcon", out result);
                return result;
            }
        }

        public System.String InprocHandler
        {
            get
            {
                System.String result;
                this.GetProperty("InprocHandler", out result);
                return result;
            }
        }

        public System.String InprocHandler32
        {
            get
            {
                System.String result;
                this.GetProperty("InprocHandler32", out result);
                return result;
            }
        }

        public System.String InprocServer
        {
            get
            {
                System.String result;
                this.GetProperty("InprocServer", out result);
                return result;
            }
        }

        public System.String InprocServer32
        {
            get
            {
                System.String result;
                this.GetProperty("InprocServer32", out result);
                return result;
            }
        }

        public System.Boolean? Insertable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Insertable", out result);
                return result;
            }
        }

        public System.Boolean? JavaClass
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("JavaClass", out result);
                return result;
            }
        }

        public System.String LocalServer
        {
            get
            {
                System.String result;
                this.GetProperty("LocalServer", out result);
                return result;
            }
        }

        public System.String LocalServer32
        {
            get
            {
                System.String result;
                this.GetProperty("LocalServer32", out result);
                return result;
            }
        }

        public System.String LongDisplayName
        {
            get
            {
                System.String result;
                this.GetProperty("LongDisplayName", out result);
                return result;
            }
        }

        public System.String ProgId
        {
            get
            {
                System.String result;
                this.GetProperty("ProgId", out result);
                return result;
            }
        }

        public System.String ShortDisplayName
        {
            get
            {
                System.String result;
                this.GetProperty("ShortDisplayName", out result);
                return result;
            }
        }

        public System.String ThreadingModel
        {
            get
            {
                System.String result;
                this.GetProperty("ThreadingModel", out result);
                return result;
            }
        }

        public System.String ToolBoxBitmap32
        {
            get
            {
                System.String result;
                this.GetProperty("ToolBoxBitmap32", out result);
                return result;
            }
        }

        public System.String TreatAsClsid
        {
            get
            {
                System.String result;
                this.GetProperty("TreatAsClsid", out result);
                return result;
            }
        }

        public System.String TypeLibraryId
        {
            get
            {
                System.String result;
                this.GetProperty("TypeLibraryId", out result);
                return result;
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }

        public System.String VersionIndependentProgId
        {
            get
            {
                System.String result;
                this.GetProperty("VersionIndependentProgId", out result);
                return result;
            }
        }

        public Win32ClassicCOMClass ResolveWin32ClassicCOMClassSettingsElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ClassicCOMClassSettings", "Win32_ClassicCOMClass", "Setting", "Element");
            return instances.Select(i => (Win32ClassicCOMClass)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}