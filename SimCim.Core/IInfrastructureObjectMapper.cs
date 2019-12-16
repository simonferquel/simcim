using Microsoft.Management.Infrastructure;
using System;

namespace SimCim.Core
{
    /// <summary>
    /// Map cimInstance to Infrastructre Objects wrappers
    /// </summary>
    public interface IInfrastructureObjectMapper
    {
        /// <summary>
        /// Create a typed infrastructure object wrapper from a CimInstance
        /// </summary>
        /// <param name="cimInstance">CimInstance to wrap</param>
        /// <returns></returns>
        IInfrastructureObject Create(IInfrastructureObjectScope scope, CimInstance cimInstance);

        /// <summary>
        /// Returns the cim classname of an Infrastructure object type
        /// If the type is not resolved, returns null
        /// </summary>
        /// <param name="wrapperType"></param>
        /// <returns></returns>
        string TryResolveType(Type wrapperType);

        /// <summary>
        /// Get the CIM namespace associated with this mapper
        /// </summary>
        string CimNamespace { get; }
    }
}
