using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32InstalledProgramFramework : GenericInfrastructureObject
    {
        public Win32InstalledProgramFramework()
        {
        }

        public Win32InstalledProgramFramework(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String FrameworkName
        {
            get
            {
                System.String result;
                this.GetProperty("FrameworkName", out result);
                return result;
            }
        }

        public System.String FrameworkPublisher
        {
            get
            {
                System.String result;
                this.GetProperty("FrameworkPublisher", out result);
                return result;
            }
        }

        public System.String FrameworkVersion
        {
            get
            {
                System.String result;
                this.GetProperty("FrameworkVersion", out result);
                return result;
            }
        }

        public System.String FrameworkVersionActual
        {
            get
            {
                System.String result;
                this.GetProperty("FrameworkVersionActual", out result);
                return result;
            }
        }

        public System.Boolean? IsPrivate
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsPrivate", out result);
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
    }
}