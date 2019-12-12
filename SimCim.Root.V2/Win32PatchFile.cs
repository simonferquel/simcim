using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PatchFile : Win32SettingCheck
    {
        public Win32PatchFile()
        {
        }

        public Win32PatchFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32FileSpecification Check
        {
            get
            {
                Win32FileSpecification result;
                this.GetInfrastructureObjectProperty("Check", out result);
                return result;
            }
        }

        public new Win32Patch Setting
        {
            get
            {
                Win32Patch result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}