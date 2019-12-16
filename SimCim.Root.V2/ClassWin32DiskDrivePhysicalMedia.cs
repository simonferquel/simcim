using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DiskDrivePhysicalMedia : CIMRealizes
    {
        public Win32DiskDrivePhysicalMedia()
        {
        }

        public Win32DiskDrivePhysicalMedia(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32PhysicalMedia Antecedent
        {
            get
            {
                Win32PhysicalMedia result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32DiskDrive Dependent
        {
            get
            {
                Win32DiskDrive result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}