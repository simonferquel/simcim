using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class CIMAlertIndication : CIMProcessIndication
    {
        public CIMAlertIndication()
        {
        }

        public CIMAlertIndication(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AlertingElementFormat
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AlertingElementFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("AlertingElementFormat", value);
            }
        }

        public System.String AlertingManagedElement
        {
            get
            {
                System.String result;
                this.GetProperty("AlertingManagedElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("AlertingManagedElement", value);
            }
        }

        public System.UInt16? AlertType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AlertType", out result);
                return result;
            }

            set
            {
                this.SetProperty("AlertType", value);
            }
        }

        public System.String Description
        {
            get
            {
                System.String result;
                this.GetProperty("Description", out result);
                return result;
            }

            set
            {
                this.SetProperty("Description", value);
            }
        }

        public System.String EventID
        {
            get
            {
                System.String result;
                this.GetProperty("EventID", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventID", value);
            }
        }

        public System.DateTime? EventTime
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("EventTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventTime", value);
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

        public System.String OtherAlertingElementFormat
        {
            get
            {
                System.String result;
                this.GetProperty("OtherAlertingElementFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherAlertingElementFormat", value);
            }
        }

        public System.String OtherAlertType
        {
            get
            {
                System.String result;
                this.GetProperty("OtherAlertType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherAlertType", value);
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

        public System.String ProviderName
        {
            get
            {
                System.String result;
                this.GetProperty("ProviderName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderName", value);
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

        public System.String SystemCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemCreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemCreationClassName", value);
            }
        }

        public System.String SystemName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemName", value);
            }
        }

        public System.UInt16? Trending
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Trending", out result);
                return result;
            }

            set
            {
                this.SetProperty("Trending", value);
            }
        }
    }
}