using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTWmiError : CIMError
    {
        public MSFTWmiError()
        {
        }

        public MSFTWmiError(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? ErrorCategory
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("error_Category", out result);
                return result;
            }

            set
            {
                this.SetProperty("error_Category", value);
            }
        }

        public System.UInt32? ErrorCode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("error_Code", out result);
                return result;
            }

            set
            {
                this.SetProperty("error_Code", value);
            }
        }

        public new System.String ErrorType
        {
            get
            {
                System.String result;
                this.GetProperty("error_Type", out result);
                return result;
            }

            set
            {
                this.SetProperty("error_Type", value);
            }
        }

        public System.String ErrorWindowsErrorMessage
        {
            get
            {
                System.String result;
                this.GetProperty("error_WindowsErrorMessage", out result);
                return result;
            }

            set
            {
                this.SetProperty("error_WindowsErrorMessage", value);
            }
        }
    }
}