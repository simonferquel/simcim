using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32Registry : CIMLogicalElement
    {
        public Win32Registry()
        {
        }

        public Win32Registry(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CurrentSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentSize", out result);
                return result;
            }
        }

        public System.UInt32? MaximumSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumSize", out result);
                return result;
            }
        }

        public System.UInt32? ProposedSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProposedSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProposedSize", value);
            }
        }
    }
}