using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NTLogEvent : GenericInfrastructureObject
    {
        public Win32NTLogEvent()
        {
        }

        public Win32NTLogEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Category
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Category", out result);
                return result;
            }

            set
            {
                this.SetProperty("Category", value);
            }
        }

        public System.String CategoryString
        {
            get
            {
                System.String result;
                this.GetProperty("CategoryString", out result);
                return result;
            }

            set
            {
                this.SetProperty("CategoryString", value);
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

        public System.Byte[] Data
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("Data", out result);
                return result;
            }

            set
            {
                this.SetProperty("Data", value);
            }
        }

        public System.UInt16? EventCode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EventCode", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventCode", value);
            }
        }

        public System.UInt32? EventIdentifier
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EventIdentifier", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventIdentifier", value);
            }
        }

        public System.Byte? EventType
        {
            get
            {
                System.Byte? result;
                this.GetProperty("EventType", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventType", value);
            }
        }

        public System.String[] InsertionStrings
        {
            get
            {
                System.String[] result;
                this.GetProperty("InsertionStrings", out result);
                return result;
            }

            set
            {
                this.SetProperty("InsertionStrings", value);
            }
        }

        public System.String Logfile
        {
            get
            {
                System.String result;
                this.GetProperty("Logfile", out result);
                return result;
            }

            set
            {
                this.SetProperty("Logfile", value);
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

        public System.UInt32 RecordNumber
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("RecordNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("RecordNumber", value);
            }
        }

        public System.String SourceName
        {
            get
            {
                System.String result;
                this.GetProperty("SourceName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SourceName", value);
            }
        }

        public System.DateTime? TimeGenerated
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeGenerated", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeGenerated", value);
            }
        }

        public System.DateTime? TimeWritten
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeWritten", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeWritten", value);
            }
        }

        public System.String Type
        {
            get
            {
                System.String result;
                this.GetProperty("Type", out result);
                return result;
            }

            set
            {
                this.SetProperty("Type", value);
            }
        }

        public System.String User
        {
            get
            {
                System.String result;
                this.GetProperty("User", out result);
                return result;
            }

            set
            {
                this.SetProperty("User", value);
            }
        }
    }
}