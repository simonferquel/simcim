using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32MoveFileAction : CIMFileAction
    {
        public Win32MoveFileAction()
        {
        }

        public Win32MoveFileAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DestFolder
        {
            get
            {
                System.String result;
                this.GetProperty("DestFolder", out result);
                return result;
            }
        }

        public System.String DestName
        {
            get
            {
                System.String result;
                this.GetProperty("DestName", out result);
                return result;
            }
        }

        public System.String FileKey
        {
            get
            {
                System.String result;
                this.GetProperty("FileKey", out result);
                return result;
            }
        }

        public System.UInt16? Options
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Options", out result);
                return result;
            }
        }

        public System.String SourceFolder
        {
            get
            {
                System.String result;
                this.GetProperty("SourceFolder", out result);
                return result;
            }
        }

        public System.String SourceName
        {
            get
            {
                System.String result;
                this.GetProperty("SourceName", out result);
                return result;
            }
        }
    }
}