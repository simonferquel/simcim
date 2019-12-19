using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMError : GenericInfrastructureObject
    {
        public CIMError()
        {
        }

        public CIMError(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CIMStatusCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CIMStatusCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("CIMStatusCode", value);
            }
        }

        public System.String CIMStatusCodeDescription
        {
            get
            {
                System.String result;
                this.GetProperty("CIMStatusCodeDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("CIMStatusCodeDescription", value);
            }
        }

        public System.String ErrorSource
        {
            get
            {
                System.String result;
                this.GetProperty("ErrorSource", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorSource", value);
            }
        }

        public System.UInt16? ErrorSourceFormat
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ErrorSourceFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorSourceFormat", value);
            }
        }

        public System.UInt16? ErrorType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ErrorType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorType", value);
            }
        }

        public System.String Message
        {
            get
            {
                System.String result;
                this.GetProperty("Message", out result);
                return result;
            }

            set
            {
                this.SetProperty("Message", value);
            }
        }

        public System.String[] MessageArguments
        {
            get
            {
                System.String[] result;
                this.GetProperty("MessageArguments", out result);
                return result;
            }

            set
            {
                this.SetProperty("MessageArguments", value);
            }
        }

        public System.String MessageID
        {
            get
            {
                System.String result;
                this.GetProperty("MessageID", out result);
                return result;
            }

            set
            {
                this.SetProperty("MessageID", value);
            }
        }

        public System.String OtherErrorSourceFormat
        {
            get
            {
                System.String result;
                this.GetProperty("OtherErrorSourceFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherErrorSourceFormat", value);
            }
        }

        public System.String OtherErrorType
        {
            get
            {
                System.String result;
                this.GetProperty("OtherErrorType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherErrorType", value);
            }
        }

        public System.String OwningEntity
        {
            get
            {
                System.String result;
                this.GetProperty("OwningEntity", out result);
                return result;
            }

            set
            {
                this.SetProperty("OwningEntity", value);
            }
        }

        public System.UInt16? PerceivedSeverity
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PerceivedSeverity", out result);
                return result;
            }

            set
            {
                this.SetProperty("PerceivedSeverity", value);
            }
        }

        public System.UInt16? ProbableCause
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProbableCause", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProbableCause", value);
            }
        }

        public System.String ProbableCauseDescription
        {
            get
            {
                System.String result;
                this.GetProperty("ProbableCauseDescription", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProbableCauseDescription", value);
            }
        }

        public System.String[] RecommendedActions
        {
            get
            {
                System.String[] result;
                this.GetProperty("RecommendedActions", out result);
                return result;
            }

            set
            {
                this.SetProperty("RecommendedActions", value);
            }
        }
    }
}