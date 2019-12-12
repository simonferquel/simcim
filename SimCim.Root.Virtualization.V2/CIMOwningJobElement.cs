using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMOwningJobElement : GenericInfrastructureObject
    {
        protected CIMOwningJobElement()
        {
        }

        protected CIMOwningJobElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMJob OwnedElement
        {
            get
            {
                CIMJob result;
                this.GetInfrastructureObjectProperty("OwnedElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("OwnedElement", value);
            }
        }

        public CIMManagedElement OwningElement
        {
            get
            {
                CIMManagedElement result;
                this.GetInfrastructureObjectProperty("OwningElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("OwningElement", value);
            }
        }
    }
}