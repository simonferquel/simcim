using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32OfflineFilesAssociatedItems : GenericInfrastructureObject
    {
        public Win32OfflineFilesAssociatedItems()
        {
        }

        public Win32OfflineFilesAssociatedItems(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32OfflineFilesCache Antecedent
        {
            get
            {
                Win32OfflineFilesCache result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public Win32OfflineFilesItem Dependent
        {
            get
            {
                Win32OfflineFilesItem result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}