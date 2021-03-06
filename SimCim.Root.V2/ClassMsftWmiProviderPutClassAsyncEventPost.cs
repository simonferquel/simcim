﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderPutClassAsyncEventPost : MsftWmiProviderOperationEventPost
    {
        public MsftWmiProviderPutClassAsyncEventPost()
        {
        }

        public MsftWmiProviderPutClassAsyncEventPost(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CimInstance ClassObject
        {
            get
            {
                CimInstance result;
                this.GetProperty("ClassObject", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClassObject", value);
            }
        }

        public System.UInt32? Flags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Flags", out result);
                return result;
            }

            set
            {
                this.SetProperty("Flags", value);
            }
        }

        public CimInstance ObjectParameter
        {
            get
            {
                CimInstance result;
                this.GetProperty("ObjectParameter", out result);
                return result;
            }

            set
            {
                this.SetProperty("ObjectParameter", value);
            }
        }

        public System.UInt32? ResultCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ResultCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResultCode", value);
            }
        }

        public System.String StringParameter
        {
            get
            {
                System.String result;
                this.GetProperty("StringParameter", out result);
                return result;
            }

            set
            {
                this.SetProperty("StringParameter", value);
            }
        }
    }
}