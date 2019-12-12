using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32MIMEInfoAction : CIMAction
    {
        public Win32MIMEInfoAction()
        {
        }

        public Win32MIMEInfoAction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String ContentType
        {
            get
            {
                System.String result;
                this.GetProperty("ContentType", out result);
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
    }
}