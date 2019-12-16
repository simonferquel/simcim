using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMMetricService : CIMService
    {
        protected CIMMetricService()
        {
        }

        protected CIMMetricService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, IEnumerable<CIMBaseMetricDefinition> outDefinitionList, IEnumerable<CIMManagedElement> outManagedElements, System.UInt16[] outMetricCollectionEnabled, System.String[] outMetricNames) ShowMetrics(CIMBaseMetricDefinition inDefinition, CIMManagedElement inSubject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDefinition != null)
                parameters.Add(CimMethodParameter.Create("Definition", inDefinition.AsCimInstance(), CimType.Reference, inDefinition == null ? CimFlags.NullValue : CimFlags.None));
            if (inSubject != null)
                parameters.Add(CimMethodParameter.Create("Subject", inSubject.AsCimInstance(), CimType.Reference, inSubject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ShowMetrics", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<CIMBaseMetricDefinition>)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["DefinitionList"].Value), (IEnumerable<CIMManagedElement>)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["ManagedElements"].Value), (System.UInt16[])result.OutParameters["MetricCollectionEnabled"].Value, (System.String[])result.OutParameters["MetricNames"].Value);
        }

        public (System.UInt32 retval, IEnumerable<CIMBaseMetricDefinition> outDefinitionList, System.UInt16[] outMetricCollectionEnabled, System.String[] outMetricNames) ShowMetricsByClass(CIMBaseMetricDefinition inDefinition, CIMManagedElement inSubject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDefinition != null)
                parameters.Add(CimMethodParameter.Create("Definition", inDefinition.AsCimInstance(), CimType.Reference, inDefinition == null ? CimFlags.NullValue : CimFlags.None));
            if (inSubject != null)
                parameters.Add(CimMethodParameter.Create("Subject", inSubject.AsCimInstance(), CimType.Reference, inSubject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ShowMetricsByClass", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<CIMBaseMetricDefinition>)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["DefinitionList"].Value), (System.UInt16[])result.OutParameters["MetricCollectionEnabled"].Value, (System.String[])result.OutParameters["MetricNames"].Value);
        }

        public System.UInt32 ControlMetrics(CIMBaseMetricDefinition inDefinition, System.UInt16? inMetricCollectionEnabled, CIMManagedElement inSubject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDefinition != null)
                parameters.Add(CimMethodParameter.Create("Definition", inDefinition.AsCimInstance(), CimType.Reference, inDefinition == null ? CimFlags.NullValue : CimFlags.None));
            if (inMetricCollectionEnabled.HasValue)
                parameters.Add(CimMethodParameter.Create("MetricCollectionEnabled", inMetricCollectionEnabled.Value, CimFlags.None));
            if (inSubject != null)
                parameters.Add(CimMethodParameter.Create("Subject", inSubject.AsCimInstance(), CimType.Reference, inSubject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ControlMetrics", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 ControlMetricsByClass(CIMBaseMetricDefinition inDefinition, System.UInt16? inMetricCollectionEnabled, CIMManagedElement inSubject)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDefinition != null)
                parameters.Add(CimMethodParameter.Create("Definition", inDefinition.AsCimInstance(), CimType.Reference, inDefinition == null ? CimFlags.NullValue : CimFlags.None));
            if (inMetricCollectionEnabled.HasValue)
                parameters.Add(CimMethodParameter.Create("MetricCollectionEnabled", inMetricCollectionEnabled.Value, CimFlags.None));
            if (inSubject != null)
                parameters.Add(CimMethodParameter.Create("Subject", inSubject.AsCimInstance(), CimType.Reference, inSubject == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ControlMetricsByClass", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, IEnumerable<CIMBaseMetricValue> outValues) GetMetricValues(System.UInt16? inCount, CIMBaseMetricDefinition inDefinition, System.UInt16? inRange)
        {
            var parameters = new CimMethodParametersCollection();
            if (inCount.HasValue)
                parameters.Add(CimMethodParameter.Create("Count", inCount.Value, CimFlags.None));
            if (inDefinition != null)
                parameters.Add(CimMethodParameter.Create("Definition", inDefinition.AsCimInstance(), CimType.Reference, inDefinition == null ? CimFlags.NullValue : CimFlags.None));
            if (inRange.HasValue)
                parameters.Add(CimMethodParameter.Create("Range", inRange.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetMetricValues", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (IEnumerable<CIMBaseMetricValue>)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Values"].Value));
        }

        public System.UInt32 ControlSampleTimes(System.DateTime? inPreferredSampleInterval, System.Boolean? inRestartGathering, System.DateTime? inStartSampleTime)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPreferredSampleInterval.HasValue)
                parameters.Add(CimMethodParameter.Create("PreferredSampleInterval", inPreferredSampleInterval.Value, CimFlags.None));
            if (inRestartGathering.HasValue)
                parameters.Add(CimMethodParameter.Create("RestartGathering", inRestartGathering.Value, CimFlags.None));
            if (inStartSampleTime.HasValue)
                parameters.Add(CimMethodParameter.Create("StartSampleTime", inStartSampleTime.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ControlSampleTimes", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}