using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSupportAccess : GenericInfrastructureObject
    {
        protected CIMSupportAccess()
        {
        }

        protected CIMSupportAccess(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CommunicationInfo
        {
            get
            {
                System.String result;
                this.GetProperty("CommunicationInfo", out result);
                return result;
            }
        }

        public System.UInt16? CommunicationMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CommunicationMode", out result);
                return result;
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
        }

        public System.String Locale
        {
            get
            {
                System.String result;
                this.GetProperty("Locale", out result);
                return result;
            }
        }

        public System.String SupportAccessId
        {
            get
            {
                System.String result;
                this.GetProperty("SupportAccessId", out result);
                return result;
            }
        }
    }
}