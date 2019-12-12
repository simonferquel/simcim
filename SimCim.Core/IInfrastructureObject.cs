using Microsoft.Management.Infrastructure;
using System;

namespace SimCim.Core
{
    /// <summary>
    /// Interface of an infrastructure object wrapping a CimInstance
    /// </summary>
    public interface IInfrastructureObject : IDisposable
    {
        /// <summary>
        /// Connect the wrapper to a given CimInstance.
        /// Can also be used to "refresh" an existing object
        /// </summary>
        /// <param name="scope">Scope owning the object</param>
        /// <param name="instance">CimInstance to wrap</param>
        void Connect(IInfrastructureObjectScope scope, CimInstance instance);

        /// <summary>
        /// Get the Scope owning this instance
        /// </summary>
        IInfrastructureObjectScope InfrastuctureObjectScope { get; }

        /// <summary>
        /// Get the underlying CimInstance
        /// </summary>
        CimInstance InnerCimInstance { get; }
    }
}
