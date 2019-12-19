using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetApplicationFilter : CIMFilterEntryBase
    {
        public MSFTNetApplicationFilter()
        {
        }

        public MSFTNetApplicationFilter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AppPath
        {
            get
            {
                System.String result;
                this.GetProperty("AppPath", out result);
                return result;
            }

            set
            {
                this.SetProperty("AppPath", value);
            }
        }

        public System.String Package
        {
            get
            {
                System.String result;
                this.GetProperty("Package", out result);
                return result;
            }

            set
            {
                this.SetProperty("Package", value);
            }
        }
    }
}