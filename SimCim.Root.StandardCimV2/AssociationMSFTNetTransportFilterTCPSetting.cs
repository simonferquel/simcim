using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.StandardCimV2
{
    public struct MSFTNetTransportFilterTCPSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetTransportFilterTCPSetting", "MSFT_NetTransportFilter", "MSFT_NetTCPSetting", "Antecedent", "Dependent");
        private IInfrastructureObjectScope _scope;
        public MSFTNetTransportFilterTCPSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetTCPSetting> Dependent(MSFTNetTransportFilter inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetTCPSetting)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetTransportFilter> Antecedent(MSFTNetTCPSetting inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetTransportFilter)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetTCPSetting> DependentAsync(MSFTNetTransportFilter inAntecedent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inAntecedent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetTCPSetting)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetTransportFilter> AntecedentAsync(MSFTNetTCPSetting inDependent, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inDependent.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetTransportFilter)scope.Mapper.Create(scope, i));
        }
    }
}