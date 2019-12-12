using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ExtensionInfoAction : CIMAction
    {
        public Win32ExtensionInfoAction()
        {
        }

        public Win32ExtensionInfoAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.String Command
        {
            get
            {
                System.String result;
                this.GetProperty("Command", out result);
                return result;
            }
        }

        public System.String Extension
        {
            get
            {
                System.String result;
                this.GetProperty("Extension", out result);
                return result;
            }
        }

        public System.String MIME
        {
            get
            {
                System.String result;
                this.GetProperty("MIME", out result);
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

        public System.String ShellNew
        {
            get
            {
                System.String result;
                this.GetProperty("ShellNew", out result);
                return result;
            }
        }

        public System.String ShellNewValue
        {
            get
            {
                System.String result;
                this.GetProperty("ShellNewValue", out result);
                return result;
            }
        }

        public System.String Verb
        {
            get
            {
                System.String result;
                this.GetProperty("Verb", out result);
                return result;
            }
        }
    }
}