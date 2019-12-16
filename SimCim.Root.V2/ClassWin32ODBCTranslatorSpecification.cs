using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ODBCTranslatorSpecification : CIMCheck
    {
        public Win32ODBCTranslatorSpecification()
        {
        }

        public Win32ODBCTranslatorSpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String File
        {
            get
            {
                System.String result;
                this.GetProperty("File", out result);
                return result;
            }
        }

        public System.String SetupFile
        {
            get
            {
                System.String result;
                this.GetProperty("SetupFile", out result);
                return result;
            }
        }

        public System.String Translator
        {
            get
            {
                System.String result;
                this.GetProperty("Translator", out result);
                return result;
            }
        }
    }
}