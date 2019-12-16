using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSettingCheck : CIMCheck
    {
        protected CIMSettingCheck()
        {
        }

        protected CIMSettingCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? CheckType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("CheckType", out result);
                return result;
            }
        }

        public System.String EntryName
        {
            get
            {
                System.String result;
                this.GetProperty("EntryName", out result);
                return result;
            }
        }

        public System.String EntryValue
        {
            get
            {
                System.String result;
                this.GetProperty("EntryValue", out result);
                return result;
            }
        }

        public System.String FileName
        {
            get
            {
                System.String result;
                this.GetProperty("FileName", out result);
                return result;
            }
        }

        public System.String SectionKey
        {
            get
            {
                System.String result;
                this.GetProperty("SectionKey", out result);
                return result;
            }
        }
    }
}