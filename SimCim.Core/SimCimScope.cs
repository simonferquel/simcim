using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Reactive.Linq;

namespace SimCim.Core
{
    public sealed class SimCimScope : IInfrastructureObjectScope
    {
        private readonly bool _ownsSession;

        /// <summary>
        /// Creates a scope from an existing session
        /// </summary>
        /// <param name="session"></param>
        /// <param name="ownsSession"></param>
        public SimCimScope(CimSession session, IInfrastructureObjectMapper mapper, bool ownsSession = true)
        {
            Mapper = mapper;
            CimSession = session;
            _ownsSession = ownsSession;
        }

        /// <summary>
        /// Creates a scope with a CimSession connecting to the local machine
        /// </summary>
        public SimCimScope(IInfrastructureObjectMapper mapper) : this(CimSession.Create(null), mapper)
        {

        }

        public IInfrastructureObjectMapper Mapper { get; }

        public CimSession CimSession { get; }

        private string ResolveClassName(Type t)
        {
            var cimClassname = Mapper.TryResolveType(t);
            if (cimClassname == null)
            {
                throw new KeyNotFoundException($"{t} is not registered in the mapper");
            }
            return cimClassname;
        }

        public IEnumerable<T> EnumerateInstances<T>() where T : class, IInfrastructureObject
        {
            var cimClassname = ResolveClassName(typeof(T));

            foreach (var instance in CimSession.EnumerateInstances(Mapper.CimNamespace, cimClassname))
            {
                yield return (T)Mapper.Create(this, instance);
            }
        }

        public IObservable<T> EnumerateInstancesAsync<T>(CimOperationOptions options = null) where T : class, IInfrastructureObject
        {
            var cimClassname = ResolveClassName(typeof(T));

            return CimSession.EnumerateInstancesAsync(Mapper.CimNamespace, cimClassname, options)
                .Select(i => (T)Mapper.Create(this, i));
        }

        public IEnumerable<T> QueryInstances<T>(string wqlFilter) where T : class, IInfrastructureObject
        {
            var cimClassname = ResolveClassName(typeof(T));

            foreach (var instance in CimSession.QueryInstances(Mapper.CimNamespace, "WQL", $"SELECT * FROM {cimClassname} WHERE {wqlFilter}"))
            {
                yield return (T)Mapper.Create(this, instance);
            }
        }

        public IObservable<T> QueryInstancesAsync<T>(string wqlFilter, CimOperationOptions options = null) where T : class, IInfrastructureObject
        {

            var cimClassname = ResolveClassName(typeof(T));

            return CimSession.QueryInstancesAsync(Mapper.CimNamespace, "WQL", $"SELECT * FROM {cimClassname} WHERE {wqlFilter}", options)
                .Select(i => (T)Mapper.Create(this, i));
        }

        public IObservable<BookmarkedEvent<T>> SubscribeToEvents<T>(double? pollingIntervalSeconds = null, string filter = null, CimOperationOptions options = null) where T : class, IInfrastructureObject
        {

            var cimClassname = ResolveClassName(typeof(T));

            var queryBuilder = new StringBuilder("SELECT * FROM ");
            queryBuilder.Append(cimClassname);
            if (pollingIntervalSeconds.HasValue)
            {
                queryBuilder.AppendFormat(CultureInfo.InvariantCulture, " WITHIN {0}", pollingIntervalSeconds);
            }

            if (filter != null)
            {
                queryBuilder.AppendFormat(CultureInfo.InvariantCulture, " WHERE {0}", filter);
            }

            return CimSession.SubscribeAsync(Mapper.CimNamespace, "WQL", queryBuilder.ToString(), options)
                .Select(i => new BookmarkedEvent<T>
                {
                    Bookmark = i.Bookmark,
                    Event = (T)Mapper.Create(this, i.Instance)
                });
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA1816:Dispose methods should call SuppressFinalize", Justification = "Only disposes managed resources")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1063:Implement IDisposable Correctly", Justification = "By design ownly wrapps the CimSession Disposable")]
        public void Dispose()
        {
            if (_ownsSession)
            {
                CimSession.Dispose();
            }
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1815:Override equals and operator equals on value types", Justification = "This wrapps a non equalable type")]
    public struct BookmarkedEvent<T>
    {
        public T Event { get; set; }
        public string Bookmark { get; set; }
    }
}
