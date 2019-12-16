using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32FileSpecification : CIMFileSpecification
    {
        public Win32FileSpecification()
        {
        }

        public Win32FileSpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Attributes
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Attributes", out result);
                return result;
            }
        }

        public System.String FileID
        {
            get
            {
                System.String result;
                this.GetProperty("FileID", out result);
                return result;
            }
        }

        public System.String Language
        {
            get
            {
                System.String result;
                this.GetProperty("Language", out result);
                return result;
            }
        }

        public System.UInt16? Sequence
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Sequence", out result);
                return result;
            }
        }
    }
}