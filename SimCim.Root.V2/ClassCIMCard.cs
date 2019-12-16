using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCard : CIMPhysicalPackage
    {
        protected CIMCard()
        {
        }

        protected CIMCard(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? HostingBoard
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("HostingBoard", out result);
                return result;
            }
        }

        public System.String RequirementsDescription
        {
            get
            {
                System.String result;
                this.GetProperty("RequirementsDescription", out result);
                return result;
            }
        }

        public System.Boolean? RequiresDaughterBoard
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RequiresDaughterBoard", out result);
                return result;
            }
        }

        public System.String SlotLayout
        {
            get
            {
                System.String result;
                this.GetProperty("SlotLayout", out result);
                return result;
            }
        }

        public System.Boolean? SpecialRequirements
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SpecialRequirements", out result);
                return result;
            }
        }
    }
}