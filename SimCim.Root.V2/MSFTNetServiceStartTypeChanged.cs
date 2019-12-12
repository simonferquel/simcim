using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetServiceStartTypeChanged : MSFTSCMEventLogEvent
    {
        public MSFTNetServiceStartTypeChanged()
        {
        }

        public MSFTNetServiceStartTypeChanged(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String NewStartType
        {
            get
            {
                System.String result;
                this.GetProperty("NewStartType", out result);
                return result;
            }

            set
            {
                this.SetProperty("NewStartType", value);
            }
        }

        public System.String OldStartType
        {
            get
            {
                System.String result;
                this.GetProperty("OldStartType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OldStartType", value);
            }
        }

        public System.String Service
        {
            get
            {
                System.String result;
                this.GetProperty("Service", out result);
                return result;
            }

            set
            {
                this.SetProperty("Service", value);
            }
        }

        public System.String Sid
        {
            get
            {
                System.String result;
                this.GetProperty("sid", out result);
                return result;
            }

            set
            {
                this.SetProperty("sid", value);
            }
        }
    }
}