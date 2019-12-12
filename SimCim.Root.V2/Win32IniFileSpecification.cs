using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32IniFileSpecification : CIMFileSpecification
    {
        public Win32IniFileSpecification()
        {
        }

        public Win32IniFileSpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Action
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Action", out result);
                return result;
            }
        }

        public System.String IniFile
        {
            get
            {
                System.String result;
                this.GetProperty("IniFile", out result);
                return result;
            }
        }

        public System.String Key
        {
            get
            {
                System.String result;
                this.GetProperty("key", out result);
                return result;
            }
        }

        public System.String Section
        {
            get
            {
                System.String result;
                this.GetProperty("Section", out result);
                return result;
            }
        }

        public System.String Value
        {
            get
            {
                System.String result;
                this.GetProperty("Value", out result);
                return result;
            }
        }
    }
}