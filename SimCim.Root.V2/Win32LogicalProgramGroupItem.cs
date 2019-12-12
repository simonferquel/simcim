﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalProgramGroupItem : Win32ProgramGroupOrItem
    {
        public Win32LogicalProgramGroupItem()
        {
        }

        public Win32LogicalProgramGroupItem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMDataFile ResolveWin32LogicalProgramGroupItemDataFileDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalProgramGroupItemDataFile", "CIM_DataFile", "Antecedent", "Dependent");
            return instances.Select(i => (CIMDataFile)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}