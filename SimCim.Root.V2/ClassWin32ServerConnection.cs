using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ServerConnection : CIMLogicalElement
    {
        public Win32ServerConnection()
        {
        }

        public Win32ServerConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveTime", value);
            }
        }

        public System.String ComputerName
        {
            get
            {
                System.String result;
                this.GetProperty("ComputerName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ComputerName", value);
            }
        }

        public System.UInt32? ConnectionID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionID", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionID", value);
            }
        }

        public System.UInt32? NumberOfFiles
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfFiles", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfFiles", value);
            }
        }

        public System.UInt32? NumberOfUsers
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfUsers", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfUsers", value);
            }
        }

        public System.String ShareName
        {
            get
            {
                System.String result;
                this.GetProperty("ShareName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ShareName", value);
            }
        }

        public System.String UserName
        {
            get
            {
                System.String result;
                this.GetProperty("UserName", out result);
                return result;
            }

            set
            {
                this.SetProperty("UserName", value);
            }
        }
    }
}