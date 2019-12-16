using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ReliabilityRecords : Win32Reliability
    {
        public Win32ReliabilityRecords()
        {
        }

        public Win32ReliabilityRecords(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ComputerName
        {
            get
            {
                System.String result;
                this.GetProperty("ComputerName", out result);
                return result;
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
        }

        public System.String[] InsertionStrings
        {
            get
            {
                System.String[] result;
                this.GetProperty("InsertionStrings", out result);
                return result;
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
        }

        public System.String Message
        {
            get
            {
                System.String result;
                this.GetProperty("Message", out result);
                return result;
            }
        }

        public System.String ProductName
        {
            get
            {
                System.String result;
                this.GetProperty("ProductName", out result);
                return result;
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
        }

        public System.String SourceName
        {
            get
            {
                System.String result;
                this.GetProperty("SourceName", out result);
                return result;
            }
        }

        public System.DateTime TimeGenerated
        {
            get
            {
                System.DateTime result;
                this.GetProperty("TimeGenerated", out result);
                return result;
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
        }

        public (System.UInt32 retval, System.UInt32? outRecordCount) GetRecordCount()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetRecordCount", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt32? )result.OutParameters["RecordCount"].Value);
        }
    }
}