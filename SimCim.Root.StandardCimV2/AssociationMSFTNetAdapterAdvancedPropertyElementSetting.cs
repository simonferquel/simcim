﻿using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using SimCim.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace SimCim.Root.StandardCimV2
{
    public struct MSFTNetAdapterAdvancedPropertyElementSettingAssociation
    {
        private static AssociationResolver _resolver = new AssociationResolver("MSFT_NetAdapterAdvancedPropertyElementSetting", "MSFT_NetAdapter", "MSFT_NetAdapterAdvancedPropertySettingData", "ManagedElement", "SettingData");
        private IInfrastructureObjectScope _scope;
        public MSFTNetAdapterAdvancedPropertyElementSettingAssociation(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<MSFTNetAdapterAdvancedPropertySettingData> SettingData(MSFTNetAdapter inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTarget(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapterAdvancedPropertySettingData)scope.Mapper.Create(scope, i));
        }

        public IEnumerable<MSFTNetAdapter> ManagedElement(MSFTNetAdapterAdvancedPropertySettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSource(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapter)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetAdapterAdvancedPropertySettingData> SettingDataAsync(MSFTNetAdapter inManagedElement, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveTargetAsync(scope, inManagedElement.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapterAdvancedPropertySettingData)scope.Mapper.Create(scope, i));
        }

        public IObservable<MSFTNetAdapter> ManagedElementAsync(MSFTNetAdapterAdvancedPropertySettingData inSettingData, CimOperationOptions options = null)
        {
            var scope = _scope;
            var instances = _resolver.ResolveSourceAsync(scope, inSettingData.AsCimInstance(), options);
            return instances.Select(i => (MSFTNetAdapter)scope.Mapper.Create(scope, i));
        }
    }
}