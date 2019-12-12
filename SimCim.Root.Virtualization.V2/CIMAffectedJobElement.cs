using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMAffectedJobElement : GenericInfrastructureObject
    {
        protected CIMAffectedJobElement()
        {
        }

        protected CIMAffectedJobElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMManagedElement AffectedElement
        {
            get
            {
                CIMManagedElement result;
                this.GetInfrastructureObjectProperty("AffectedElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("AffectedElement", value);
            }
        }

        public CIMJob AffectingElement
        {
            get
            {
                CIMJob result;
                this.GetInfrastructureObjectProperty("AffectingElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("AffectingElement", value);
            }
        }

        public System.UInt16[] ElementEffects
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("ElementEffects", out result);
                return result;
            }

            set
            {
                this.SetProperty("ElementEffects", value);
            }
        }

        public System.String[] OtherElementEffectsDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("OtherElementEffectsDescriptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherElementEffectsDescriptions", value);
            }
        }
    }
}