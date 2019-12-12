using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetServiceStopControlSuccess : MSFTSCMEventLogEvent
    {
        public MSFTNetServiceStopControlSuccess()
        {
        }

        public MSFTNetServiceStopControlSuccess(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Comment
        {
            get
            {
                System.String result;
                this.GetProperty("Comment", out result);
                return result;
            }

            set
            {
                this.SetProperty("Comment", value);
            }
        }

        public System.String Control
        {
            get
            {
                System.String result;
                this.GetProperty("Control", out result);
                return result;
            }

            set
            {
                this.SetProperty("Control", value);
            }
        }

        public System.String Reason
        {
            get
            {
                System.String result;
                this.GetProperty("Reason", out result);
                return result;
            }

            set
            {
                this.SetProperty("Reason", value);
            }
        }

        public System.String ReasonText
        {
            get
            {
                System.String result;
                this.GetProperty("ReasonText", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReasonText", value);
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