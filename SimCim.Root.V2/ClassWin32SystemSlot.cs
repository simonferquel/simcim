using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemSlot : CIMSlot
    {
        public Win32SystemSlot()
        {
        }

        public Win32SystemSlot(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BusNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BusNumber", out result);
                return result;
            }
        }

        public System.UInt16? CurrentUsage
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CurrentUsage", out result);
                return result;
            }
        }

        public System.UInt32? DeviceNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DeviceNumber", out result);
                return result;
            }
        }

        public System.UInt32? FunctionNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FunctionNumber", out result);
                return result;
            }
        }

        public System.Boolean? PMESignal
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PMESignal", out result);
                return result;
            }
        }

        public System.UInt32? SegmentGroupNumber
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SegmentGroupNumber", out result);
                return result;
            }
        }

        public System.Boolean? Shared
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Shared", out result);
                return result;
            }
        }

        public System.String SlotDesignation
        {
            get
            {
                System.String result;
                this.GetProperty("SlotDesignation", out result);
                return result;
            }
        }
    }
}