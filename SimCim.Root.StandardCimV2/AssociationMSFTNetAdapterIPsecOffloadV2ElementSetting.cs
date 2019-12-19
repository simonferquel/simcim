using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetAdapterIPsecOffloadV2ElementSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetAdapterIPsecOffloadV2ElementSetting", "MSFT_NetAdapter", "MSFT_NetAdapterIPsecOffloadV2SettingData", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MSFTNetAdapterIPsecOffloadV2ElementSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetAdapterIPsecOffloadV2SettingData> SettingData(MSFTNetAdapter inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapterIPsecOffloadV2SettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetAdapter> ManagedElement(MSFTNetAdapterIPsecOffloadV2SettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapter)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetAdapterIPsecOffloadV2SettingData> SettingDataAsync(MSFTNetAdapter inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapterIPsecOffloadV2SettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetAdapter> ManagedElementAsync(MSFTNetAdapterIPsecOffloadV2SettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapter)scope.Mapper.Create(scope, i));
        }
    }
}