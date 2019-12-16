using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmCollectedSnapshots : CIMCollectedMSEs
    {
        public MsvmCollectedSnapshots()
        {
        }

        public MsvmCollectedSnapshots(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmSnapshotCollection Collection
        {
            get
            {
                MsvmSnapshotCollection result;
                this.GetInfrastructureObjectProperty("Collection", out result);
                return result;
            }

            set
            {
                this.SetProperty("Collection", value);
            }
        }

        public new MsvmVirtualSystemSettingData Member
        {
            get
            {
                MsvmVirtualSystemSettingData result;
                this.GetInfrastructureObjectProperty("Member", out result);
                return result;
            }

            set
            {
                this.SetProperty("Member", value);
            }
        }
    }
}