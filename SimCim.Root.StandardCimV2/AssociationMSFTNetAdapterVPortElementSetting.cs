﻿using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetAdapterVPortElementSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetAdapterVPortElementSetting", "MSFT_NetAdapter", "MSFT_NetAdapterVPortSettingData", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MSFTNetAdapterVPortElementSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetAdapterVPortSettingData> SettingData(MSFTNetAdapter inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapterVPortSettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetAdapter> ManagedElement(MSFTNetAdapterVPortSettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapter)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetAdapterVPortSettingData> SettingDataAsync(MSFTNetAdapter inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapterVPortSettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetAdapter> ManagedElementAsync(MSFTNetAdapterVPortSettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapter)scope.Mapper.Create(scope, i));
        }
    }
}