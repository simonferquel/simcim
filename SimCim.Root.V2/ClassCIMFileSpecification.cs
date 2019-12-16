using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMFileSpecification : CIMCheck
    {
        protected CIMFileSpecification()
        {
        }

        protected CIMFileSpecification(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CheckSum
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CheckSum", out result);
                return result;
            }
        }

        public System.UInt32? CRC1
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CRC1", out result);
                return result;
            }
        }

        public System.UInt32? CRC2
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CRC2", out result);
                return result;
            }
        }

        public System.DateTime? CreateTimeStamp
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("CreateTimeStamp", out result);
                return result;
            }
        }

        public System.UInt64? FileSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FileSize", out result);
                return result;
            }
        }

        public System.String MD5Checksum
        {
            get
            {
                System.String result;
                this.GetProperty("MD5Checksum", out result);
                return result;
            }
        }
    }
}