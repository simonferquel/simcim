using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public abstract class MSFTNetEventProviderBase : CIMLogicalElement
    {
        protected MSFTNetEventProviderBase()
        {
        }

        protected MSFTNetEventProviderBase(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Guid
        {
            get
            {
                System.String result;
                this.GetProperty("Guid", out result);
                return result;
            }

            set
            {
                this.SetProperty("Guid", value);
            }
        }

        public System.Byte? Level
        {
            get
            {
                System.Byte? result;
                this.GetProperty("Level", out result);
                return result;
            }

            set
            {
                this.SetProperty("Level", value);
            }
        }

        public System.UInt64? MatchAllKeyword
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MatchAllKeyword", out result);
                return result;
            }

            set
            {
                this.SetProperty("MatchAllKeyword", value);
            }
        }

        public System.UInt64? MatchAnyKeyword
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MatchAnyKeyword", out result);
                return result;
            }

            set
            {
                this.SetProperty("MatchAnyKeyword", value);
            }
        }

        public System.String SessionGuid
        {
            get
            {
                System.String result;
                this.GetProperty("SessionGuid", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionGuid", value);
            }
        }

        public System.String SessionName
        {
            get
            {
                System.String result;
                this.GetProperty("SessionName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SessionName", value);
            }
        }
    }
}