using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ShadowContext : CIMSetting
    {
        public Win32ShadowContext()
        {
        }

        public Win32ShadowContext(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ClientAccessible
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ClientAccessible", out result);
                return result;
            }
        }

        public System.Boolean? Differential
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Differential", out result);
                return result;
            }
        }

        public System.Boolean? ExposedLocally
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ExposedLocally", out result);
                return result;
            }
        }

        public System.Boolean? ExposedRemotely
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ExposedRemotely", out result);
                return result;
            }
        }

        public System.Boolean? HardwareAssisted
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HardwareAssisted", out result);
                return result;
            }
        }

        public System.Boolean? Imported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Imported", out result);
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

        public System.Boolean? NoAutoRelease
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NoAutoRelease", out result);
                return result;
            }
        }

        public System.Boolean? NotSurfaced
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NotSurfaced", out result);
                return result;
            }
        }

        public System.Boolean? NoWriters
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("NoWriters", out result);
                return result;
            }
        }

        public System.Boolean? Persistent
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Persistent", out result);
                return result;
            }
        }

        public System.Boolean? Plex
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Plex", out result);
                return result;
            }
        }

        public System.Boolean? Transportable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Transportable", out result);
                return result;
            }
        }
    }
}