using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SID : GenericInfrastructureObject
    {
        public Win32SID()
        {
        }

        public Win32SID(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AccountName
        {
            get
            {
                System.String result;
                this.GetProperty("AccountName", out result);
                return result;
            }
        }

        public System.Byte[] BinaryRepresentation
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("BinaryRepresentation", out result);
                return result;
            }
        }

        public System.String ReferencedDomainName
        {
            get
            {
                System.String result;
                this.GetProperty("ReferencedDomainName", out result);
                return result;
            }
        }

        public System.String SID
        {
            get
            {
                System.String result;
                this.GetProperty("SID", out result);
                return result;
            }
        }

        public System.UInt32? SidLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SidLength", out result);
                return result;
            }
        }
    }
}