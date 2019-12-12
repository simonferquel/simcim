using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ClassInfoAction : CIMAction
    {
        public Win32ClassInfoAction()
        {
        }

        public Win32ClassInfoAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AppID
        {
            get
            {
                System.String result;
                this.GetProperty("AppID", out result);
                return result;
            }
        }

        public System.String Argument
        {
            get
            {
                System.String result;
                this.GetProperty("Argument", out result);
                return result;
            }
        }

        public System.String CLSID
        {
            get
            {
                System.String result;
                this.GetProperty("CLSID", out result);
                return result;
            }
        }

        public System.String Context
        {
            get
            {
                System.String result;
                this.GetProperty("Context", out result);
                return result;
            }
        }

        public System.String DefInprocHandler
        {
            get
            {
                System.String result;
                this.GetProperty("DefInprocHandler", out result);
                return result;
            }
        }

        public System.String FileTypeMask
        {
            get
            {
                System.String result;
                this.GetProperty("FileTypeMask", out result);
                return result;
            }
        }

        public System.UInt16? Insertable
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Insertable", out result);
                return result;
            }
        }

        public System.String ProgID
        {
            get
            {
                System.String result;
                this.GetProperty("ProgID", out result);
                return result;
            }
        }

        public System.String RemoteName
        {
            get
            {
                System.String result;
                this.GetProperty("RemoteName", out result);
                return result;
            }
        }

        public System.String VIProgID
        {
            get
            {
                System.String result;
                this.GetProperty("VIProgID", out result);
                return result;
            }
        }
    }
}