using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32ProcessStartup : Win32MethodParameterClass
    {
        protected Win32ProcessStartup()
        {
        }

        protected Win32ProcessStartup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CreateFlags
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CreateFlags", out result);
                return result;
            }

            set
            {
                this.SetProperty("CreateFlags", value);
            }
        }

        public System.String[] EnvironmentVariables
        {
            get
            {
                System.String[] result;
                this.GetProperty("EnvironmentVariables", out result);
                return result;
            }

            set
            {
                this.SetProperty("EnvironmentVariables", value);
            }
        }

        public System.UInt16? ErrorMode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ErrorMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorMode", value);
            }
        }

        public System.UInt32? FillAttribute
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FillAttribute", out result);
                return result;
            }

            set
            {
                this.SetProperty("FillAttribute", value);
            }
        }

        public System.UInt32? PriorityClass
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PriorityClass", out result);
                return result;
            }

            set
            {
                this.SetProperty("PriorityClass", value);
            }
        }

        public System.UInt16? ShowWindow
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ShowWindow", out result);
                return result;
            }

            set
            {
                this.SetProperty("ShowWindow", value);
            }
        }

        public System.String Title
        {
            get
            {
                System.String result;
                this.GetProperty("Title", out result);
                return result;
            }

            set
            {
                this.SetProperty("Title", value);
            }
        }

        public System.String WinstationDesktop
        {
            get
            {
                System.String result;
                this.GetProperty("WinstationDesktop", out result);
                return result;
            }

            set
            {
                this.SetProperty("WinstationDesktop", value);
            }
        }

        public System.UInt32? X
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("X", out result);
                return result;
            }

            set
            {
                this.SetProperty("X", value);
            }
        }

        public System.UInt32? XCountChars
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("XCountChars", out result);
                return result;
            }

            set
            {
                this.SetProperty("XCountChars", value);
            }
        }

        public System.UInt32? XSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("XSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("XSize", value);
            }
        }

        public System.UInt32? Y
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Y", out result);
                return result;
            }

            set
            {
                this.SetProperty("Y", value);
            }
        }

        public System.UInt32? YCountChars
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("YCountChars", out result);
                return result;
            }

            set
            {
                this.SetProperty("YCountChars", value);
            }
        }

        public System.UInt32? YSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("YSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("YSize", value);
            }
        }
    }
}