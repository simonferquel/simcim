using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;

namespace SimCim.Core
{
    public static class InfrastructureObjectExtensions
    {
        /// <summary>
        /// Retrieve each source object's CimInstance
        /// </summary>
        /// <param name="source">can be null (in this case return value will be null)</param>
        /// <returns></returns>
        public static IEnumerable<CimInstance> AsCimInstance(this IEnumerable<IInfrastructureObject> source)
        {
            if (source == null)
            {
                return null;
            }
            return source.Select(s => s.InnerCimInstance).ToArray();
        }

        /// <summary>
        /// Retrieve each source object's CimInstance
        /// </summary>
        /// <param name="source">can be null (in this case return value will be null)</param>
        /// <returns></returns>
        public static IObservable<CimInstance> AsCimInstance(this IObservable<IInfrastructureObject> source)
        {
            if (source == null)
            {
                return null;
            }
            return source.Select(s => s.InnerCimInstance);
        }

        /// <summary>
        /// Retruns the CimInstance of a given Infrastructure object
        /// </summary>
        /// <param name="source">can be null (in this case return value will be null)</param>
        /// <returns></returns>
        public static CimInstance AsCimInstance(this IInfrastructureObject source)
        {
            if (source == null)
            {
                return null;
            }
            return source.InnerCimInstance;
        }

        /// <summary>
        /// Get a property value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <param name="name"></param>
        /// <param name="outval"></param>
        public static void GetProperty<T>(this IInfrastructureObject o, string name, out T outval)
        {
            if (o == null)
            {
                throw new ArgumentNullException(nameof(o));
            }

            outval = (T)o.InnerCimInstance.CimInstanceProperties[name].Value;
        }

        /// <summary>
        /// Set a property value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void SetProperty<T>(this IInfrastructureObject o, string name, T value)
        {
            if (o == null)
            {
                throw new ArgumentNullException(nameof(o));
            }

            o.InnerCimInstance.CimInstanceProperties[name].Value = value;
        }

        /// <summary>
        /// Get an instance property value as a wrapper
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <param name="name"></param>
        /// <param name="outval"></param>
        public static void GetInfrastructureObjectProperty<T>(this IInfrastructureObject o, string name, out T outval) where T : class, IInfrastructureObject
        {
            if (o == null)
            {
                throw new ArgumentNullException(nameof(o));
            }

            CimInstance val;
            GetProperty(o, name, out val);
            if (val == null)
            {
                outval = null;
                return;
            }
            outval = (T)o.InfrastuctureObjectScope.Mapper.Create(o.InfrastuctureObjectScope, val);
        }

        /// <summary>
        /// Get an instance collection property value as wrappers
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <param name="name"></param>
        /// <param name="outval"></param>
        public static void GetInfrastructureObjectProperty<T>(this IInfrastructureObject o, string name, out IEnumerable<T> outval) where T : class, IInfrastructureObject
        {
            IEnumerable<CimInstance> vals;
            GetProperty(o, name, out vals);

            if (vals == null)
            {
                outval = null;
                return;
            }
            outval = vals.Select(v => (T)o.InfrastuctureObjectScope.Mapper.Create(o.InfrastuctureObjectScope, v));
        }

        /// <summary>
        /// Set a property value
        /// </summary>
        /// <param name="o"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void SetProperty(this IInfrastructureObject o, string name, IInfrastructureObject value)
        {
            SetProperty(o, name, value?.InnerCimInstance);
        }

        /// <summary>
        /// Set a property value
        /// </summary>
        /// <param name="o"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void SetProperty(this IInfrastructureObject o, string name, IEnumerable<IInfrastructureObject> value)
        {
            if(value == null)
            {
                SetProperty<object>(o, name, null);
            }

            var instances = value.AsCimInstance().ToArray();
            SetProperty(o, name, instances);
        }

        public static IEnumerable<T> CreateMany<T>(this IInfrastructureObjectMapper mapper, IInfrastructureObjectScope scope, IEnumerable<CimInstance> cimInstances) where T : class, IInfrastructureObject
        {
            if(mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }
            if(cimInstances == null)
            {
                yield break;
            }

            foreach(var i in cimInstances)
            {
                yield return (T)mapper.Create(scope, i);
            }
        }

        public static CimOperationOptions KeysOnlyOption(this IInfrastructureObjectScope scope,  CancellationToken cancellationToken = default)
        {
            var options = new CimOperationOptions
            {
                KeysOnly = true,
            };
            if (cancellationToken.CanBeCanceled)
            {
                options.CancellationToken = cancellationToken;
            }

            return options;
        }
    }
}
