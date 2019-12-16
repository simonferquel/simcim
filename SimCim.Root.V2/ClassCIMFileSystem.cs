using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMFileSystem : CIMLogicalElement
    {
        protected CIMFileSystem()
        {
        }

        protected CIMFileSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AvailableSpace
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvailableSpace", out result);
                return result;
            }
        }

        public System.UInt64? BlockSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BlockSize", out result);
                return result;
            }
        }

        public System.Boolean? CasePreserved
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CasePreserved", out result);
                return result;
            }
        }

        public System.Boolean? CaseSensitive
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("CaseSensitive", out result);
                return result;
            }
        }

        public System.UInt16[] CodeSet
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("CodeSet", out result);
                return result;
            }
        }

        public System.String CompressionMethod
        {
            get
            {
                System.String result;
                this.GetProperty("CompressionMethod", out result);
                return result;
            }
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }
        }

        public System.String CSCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CSCreationClassName", out result);
                return result;
            }
        }

        public System.String CSName
        {
            get
            {
                System.String result;
                this.GetProperty("CSName", out result);
                return result;
            }
        }

        public System.String EncryptionMethod
        {
            get
            {
                System.String result;
                this.GetProperty("EncryptionMethod", out result);
                return result;
            }
        }

        public System.UInt64? FileSystemSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FileSystemSize", out result);
                return result;
            }
        }

        public System.UInt32? MaxFileNameLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxFileNameLength", out result);
                return result;
            }
        }

        public System.Boolean? ReadOnly
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ReadOnly", out result);
                return result;
            }
        }

        public System.String Root
        {
            get
            {
                System.String result;
                this.GetProperty("Root", out result);
                return result;
            }
        }
    }
}