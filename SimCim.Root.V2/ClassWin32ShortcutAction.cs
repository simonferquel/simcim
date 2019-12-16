using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ShortcutAction : CIMAction
    {
        public Win32ShortcutAction()
        {
        }

        public Win32ShortcutAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Arguments
        {
            get
            {
                System.String result;
                this.GetProperty("Arguments", out result);
                return result;
            }
        }

        public System.UInt16? HotKey
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HotKey", out result);
                return result;
            }
        }

        public System.String IconIndex
        {
            get
            {
                System.String result;
                this.GetProperty("IconIndex", out result);
                return result;
            }

            set
            {
                this.SetProperty("IconIndex", value);
            }
        }

        public System.String Shortcut
        {
            get
            {
                System.String result;
                this.GetProperty("Shortcut", out result);
                return result;
            }
        }

        public System.UInt16? ShowCmd
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ShowCmd", out result);
                return result;
            }
        }

        public System.String Target
        {
            get
            {
                System.String result;
                this.GetProperty("Target", out result);
                return result;
            }
        }

        public System.String WkDir
        {
            get
            {
                System.String result;
                this.GetProperty("WkDir", out result);
                return result;
            }
        }
    }
}