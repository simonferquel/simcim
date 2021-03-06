﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PageFileSetting : CIMSetting
    {
        public Win32PageFileSetting()
        {
        }

        public Win32PageFileSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? InitialSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InitialSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("InitialSize", value);
            }
        }

        public System.UInt32? MaximumSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaximumSize", value);
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

            set
            {
                this.SetProperty("Name", value);
            }
        }
    }
}