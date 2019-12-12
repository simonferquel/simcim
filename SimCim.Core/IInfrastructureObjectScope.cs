using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using System;
using System.Collections.Generic;

namespace SimCim.Core
{
    /// <summary>
    /// Scope allowing to interact with infrastructure objects
    /// </summary>
    public interface IInfrastructureObjectScope : IDisposable
    {
        /// <summary>
        /// Get the mapper used to generate typed wrappers around a cim instance
        /// </summary>
        PerNamespaceInfrastructureObjectMapper Mapper { get; }

        /// <summary>
        /// Get the cim session on which the scope operates
        /// </summary>
        CimSession CimSession { get; }

        /// <summary>
        /// Enumerate all instances of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IEnumerable<T> EnumerateInstances<T>() where T : class, IInfrastructureObject;

        /// <summary>
        /// Enumerate all instances of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="options">options used to customize the query</param>
        /// <returns></returns>
        IObservable<T> EnumerateInstancesAsync<T>(CimOperationOptions options = null) where T : class, IInfrastructureObject;

        /// <summary>
        /// Query instances of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="wqlFilter"></param>
        /// <returns></returns>
        IEnumerable<T> QueryInstances<T>(string wqlFilter) where T : class, IInfrastructureObject;

        /// <summary>
        /// Query instances of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="wqlFilter"></param>
        /// <param name="options">options used to customize the query</param>
        /// <returns></returns>
        IObservable<T> QueryInstancesAsync<T>(string wqlFilter, CimOperationOptions options = null) where T : class, IInfrastructureObject;

        /// <summary>
        /// Subscribe to events of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pollingIntervalSeconds"></param>
        /// <param name="wqlFilter"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        IObservable<BookmarkedEvent<T>> SubscribeToEvents<T>(double? pollingIntervalSeconds = null, string wqlFilter = null, CimOperationOptions options = null) where T : class, IInfrastructureObject;
    }
}
