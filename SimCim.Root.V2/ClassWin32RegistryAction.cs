using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32RegistryAction : CIMAction
    {
        public Win32RegistryAction()
        {
        }

        public Win32RegistryAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String EntryName
        {
            get
            {
                System.String result;
                this.GetProperty("EntryName", out result);
                return result;
            }
        }

        public System.String EntryValue
        {
            get
            {
                System.String result;
                this.GetProperty("EntryValue", out result);
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

        public System.String Registry
        {
            get
            {
                System.String result;
                this.GetProperty("Registry", out result);
                return result;
            }
        }

        public System.Int16? Root
        {
            get
            {
                System.Int16? result;
                this.GetProperty("Root", out result);
                return result;
            }
        }
    }
}