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
        IInfrastructureObject Create(CimInstance cimInstance);

        /// <summary>
        /// Returns the cim namespace and classname of an Infrastructure object type
        /// If the type is not resolved, returns (null, null)
        /// </summary>
        /// <param name="wrapperType"></param>
        /// <returns></returns>
        (string cimNamespace, string cimClassName) TryResolveType(Type wrapperType);
    }
}
