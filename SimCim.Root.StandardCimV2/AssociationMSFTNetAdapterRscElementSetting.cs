﻿using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetAdapterRscElementSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetAdapterRscElementSetting", "MSFT_NetAdapter", "MSFT_NetAdapterRscSettingData", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MSFTNetAdapterRscElementSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetAdapterRscSettingData> SettingData(MSFTNetAdapter inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapterRscSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetAdapter> ManagedElement(MSFTNetAdapterRscSettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapter)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetAdapterRscSettingData> SettingDataAsync(MSFTNetAdapter inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapterRscSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetAdapter> ManagedElementAsync(MSFTNetAdapterRscSettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapter)scope.Mapper.Create(scope, i));
        }
    }
}