using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMExport : GenericInfrastructureObject
    {
        protected CIMExport()
        {
        }

        protected CIMExport(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMDirectory Directory
        {
            get
            {
                CIMDirectory result;
                this.GetInfrastructureObjectProperty("Directory", out result);
                return result;
            }
        }

        public System.String ExportedDirectoryName
        {
            get
            {
                System.String result;
                this.GetProperty("ExportedDirectoryName", out result);
                return result;
            }
        }

        public CIMLocalFileSystem LocalFS
        {
            get
            {
                CIMLocalFileSystem result;
                this.GetInfrastructureObjectProperty("LocalFS", out result);
                return result;
            }
        }
    }
}