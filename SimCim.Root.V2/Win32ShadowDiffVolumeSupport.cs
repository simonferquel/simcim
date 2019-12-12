﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ShadowDiffVolumeSupport : CIMDependency
    {
        public Win32ShadowDiffVolumeSupport()
        {
        }

        public Win32ShadowDiffVolumeSupport(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32ShadowProvider Antecedent
        {
            get
            {
                Win32ShadowProvider result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32Volume Dependent
        {
            get
            {
                Win32Volume result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}