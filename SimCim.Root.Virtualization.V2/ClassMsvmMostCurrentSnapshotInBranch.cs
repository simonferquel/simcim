using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmMostCurrentSnapshotInBranch : CIMMostCurrentSnapshotInBranch
    {
        public MsvmMostCurrentSnapshotInBranch()
        {
        }

        public MsvmMostCurrentSnapshotInBranch(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmVirtualSystemSettingData Dependent
        {
            get
            {
                MsvmVirtualSystemSettingData result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dependent", value);
            }
        }
    }
}