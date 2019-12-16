using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32InstalledWin32Program : GenericInfrastructureObject
    {
        public Win32InstalledWin32Program()
        {
        }

        public Win32InstalledWin32Program(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Language
        {
            get
            {
                System.String result;
                this.GetProperty("Language", out result);
                return result;
            }
        }

        public System.String MsiPackageCode
        {
            get
            {
                System.String result;
                this.GetProperty("MsiPackageCode", out result);
                return result;
            }
        }

        public System.String MsiProductCode
        {
            get
            {
                System.String result;
                this.GetProperty("MsiProductCode", out result);
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

        public System.String ProgramId
        {
            get
            {
                System.String result;
                this.GetProperty("ProgramId", out result);
                return result;
            }
        }

        public System.String Vendor
        {
            get
            {
                System.String result;
                this.GetProperty("Vendor", out result);
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
    }
}