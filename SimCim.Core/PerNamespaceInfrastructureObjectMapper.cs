using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;

namespace SimCim.Core
{
    /// <summary>
    /// Mapper aggregating namespace-specific mappers
    /// </summary>
    public class PerNamespaceInfrastructureObjectMapper : IInfrastructureObjectMapper
    {
        private readonly Dictionary<string, IInfrastructureObjectMapper> _namespaceFactories = new Dictionary<string, IInfrastructureObjectMapper>();
        private readonly IInfrastructureObjectScope _scope;

        public PerNamespaceInfrastructureObjectMapper(IInfrastructureObjectScope scope)
        {
            _scope = scope;
        }

        /// <summary>
        /// Adds a namespace-specific mapper
        /// </summary>
        /// <param name="cimNamespace"></param>
        /// <param name="mapper"></param>
        public void AddNamespaceMapper(string cimNamespace, IInfrastructureObjectMapper mapper) {
            if(cimNamespace == null)
            {
                throw new ArgumentNullException(nameof(cimNamespace));
            }
            _namespaceFactories[cimNamespace.ToUpperInvariant()] = mapper;
        }
        public IInfrastructureObject Create(CimInstance cimInstance)
        {
            if(cimInstance == null)
            {
                return null;
            }
            if(_namespaceFactories.TryGetValue(cimInstance.CimSystemProperties.Namespace.ToUpperInvariant(), out var factory))
            {
                return factory.Create(cimInstance);
            }
            return new GenericInfrastructureObject(_scope, cimInstance);
        }

        public IInfrastructureObject Create(CimInstance cimInstance, Type fallbackType)
        {
            if (cimInstance == null)
            {
                return null;
            }
            if (cimInstance.CimSystemProperties.ClassName == null || cimInstance.CimSystemProperties.Namespace == null)
            {
                // cant detect type, fallback
                var result = (IInfrastructureObject)Activator.CreateInstance(fallbackType);
                result.Connect(_scope, cimInstance);
                return result;
            }
            return Create(cimInstance);
        }

        public (string cimNamespace, string cimClassName) TryResolveType(Type wrapperType)
        {
            foreach(var f in _namespaceFactories.Values)
            {
                var (cimNamespace, cimClassName) = f.TryResolveType(wrapperType);
                if (cimClassName!= null)
                {
                    return (cimNamespace, cimClassName);
                }
            }
            return (null, null);
        }
    }
}
