using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32VolumeChangeEvent : Win32DeviceChangeEvent
    {
        public Win32VolumeChangeEvent()
        {
        }

        public Win32VolumeChangeEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DriveName
        {
            get
            {
                System.String result;
                this.GetProperty("DriveName", out result);
                return result;
            }
        }
    }
}