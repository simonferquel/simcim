using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPhysicalMedia : CIMPhysicalComponent
    {
        protected CIMPhysicalMedia()
        {
        }

        protected CIMPhysicalMedia(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? Capacity
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Capacity", out result);
                return result;
            }
        }

        public System.Boolean? CleanerMedia
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CleanerMedia", out result);
                return result;
            }
        }

        public System.String MediaDescription
        {
            get
            {
                System.String result;
                this.GetProperty("MediaDescription", out result);
                return result;
            }
        }

        public System.UInt16? MediaType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MediaType", out result);
                return result;
            }
        }

        public System.Boolean? WriteProtectOn
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("WriteProtectOn", out result);
                return result;
            }
        }
    }
}