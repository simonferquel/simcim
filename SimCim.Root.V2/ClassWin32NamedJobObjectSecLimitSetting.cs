using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NamedJobObjectSecLimitSetting : CIMSetting
    {
        public Win32NamedJobObjectSecLimitSetting()
        {
        }

        public Win32NamedJobObjectSecLimitSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32TokenPrivileges PrivilegesToDelete
        {
            get
            {
                Win32TokenPrivileges result;
                this.GetInfrastructureObjectProperty("PrivilegesToDelete", out result);
                return result;
            }
        }

        public Win32TokenGroups RestrictedSIDs
        {
            get
            {
                Win32TokenGroups result;
                this.GetInfrastructureObjectProperty("RestrictedSIDs", out result);
                return result;
            }
        }

        public System.UInt32? SecurityLimitFlags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SecurityLimitFlags", out result);
                return result;
            }
        }

        public Win32TokenGroups SIDsToDisable
        {
            get
            {
                Win32TokenGroups result;
                this.GetInfrastructureObjectProperty("SIDsToDisable", out result);
                return result;
            }
        }
    }
}