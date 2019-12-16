using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ShadowProvider : CIMLogicalElement
    {
        public Win32ShadowProvider()
        {
        }

        public Win32ShadowProvider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.String ID
        {
            get
            {
                System.String result;
                this.GetProperty("ID", out result);
                return result;
            }
        }

        public System.UInt32? Type
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Type", out result);
                return result;
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }

        public System.String VersionID
        {
            get
            {
                System.String result;
                this.GetProperty("VersionID", out result);
                return result;
            }
        }
    }
}