using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32BIOS : CIMBIOSElement
    {
        public Win32BIOS()
        {
        }

        public Win32BIOS(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] BiosCharacteristics
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("BiosCharacteristics", out result);
                return result;
            }
        }

        public System.String[] BIOSVersion
        {
            get
            {
                System.String[] result;
                this.GetProperty("BIOSVersion", out result);
                return result;
            }
        }

        public System.String CurrentLanguage
        {
            get
            {
                System.String result;
                this.GetProperty("CurrentLanguage", out result);
                return result;
            }
        }

        public System.Byte? EmbeddedControllerMajorVersion
        {
            get
            {
                System.Byte? result;
                this.GetProperty("EmbeddedControllerMajorVersion", out result);
                return result;
            }
        }

        public System.Byte? EmbeddedControllerMinorVersion
        {
            get
            {
                System.Byte? result;
                this.GetProperty("EmbeddedControllerMinorVersion", out result);
                return result;
            }
        }

        public System.UInt16? InstallableLanguages
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("InstallableLanguages", out result);
                return result;
            }
        }

        public System.String[] ListOfLanguages
        {
            get
            {
                System.String[] result;
                this.GetProperty("ListOfLanguages", out result);
                return result;
            }
        }

        public System.DateTime? ReleaseDate
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("ReleaseDate", out result);
                return result;
            }
        }

        public System.String SMBIOSBIOSVersion
        {
            get
            {
                System.String result;
                this.GetProperty("SMBIOSBIOSVersion", out result);
                return result;
            }
        }

        public System.UInt16? SMBIOSMajorVersion
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SMBIOSMajorVersion", out result);
                return result;
            }
        }

        public System.UInt16? SMBIOSMinorVersion
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SMBIOSMinorVersion", out result);
                return result;
            }
        }

        public System.Boolean? SMBIOSPresent
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SMBIOSPresent", out result);
                return result;
            }
        }

        public System.Byte? SystemBiosMajorVersion
        {
            get
            {
                System.Byte? result;
                this.GetProperty("SystemBiosMajorVersion", out result);
                return result;
            }
        }

        public System.Byte? SystemBiosMinorVersion
        {
            get
            {
                System.Byte? result;
                this.GetProperty("SystemBiosMinorVersion", out result);
                return result;
            }
        }
    }
}