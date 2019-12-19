using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterQosSettings : GenericInfrastructureObject
    {
        public MSFTNetAdapterQosSettings()
        {
        }

        public MSFTNetAdapterQosSettings(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte[] BandwidthAssignmentTable
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("BandwidthAssignmentTable", out result);
                return result;
            }
        }

        public System.Boolean? ClassificationEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ClassificationEnabled", out result);
                return result;
            }
        }

        public IEnumerable<MSFTNetAdapterQosClassificationElement> ClassificationTable
        {
            get
            {
                IEnumerable<MSFTNetAdapterQosClassificationElement> result;
                this.GetInfrastructureObjectProperty("ClassificationTable", out result);
                return result;
            }
        }

        public System.Boolean? FlowControlEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("FlowControlEnabled", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfClassificationElements
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfClassificationElements", out result);
                return result;
            }
        }

        public System.Byte[] PriorityAssignmentTable
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("PriorityAssignmentTable", out result);
                return result;
            }
        }

        public System.Boolean[] PriorityFlowControlEnableArray
        {
            get
            {
                System.Boolean[] result;
                this.GetProperty("PriorityFlowControlEnableArray", out result);
                return result;
            }
        }

        public System.Boolean? TransmissionSelectionEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TransmissionSelectionEnabled", out result);
                return result;
            }
        }

        public System.Byte[] TsaAssignmentTable
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("TsaAssignmentTable", out result);
                return result;
            }
        }
    }
}