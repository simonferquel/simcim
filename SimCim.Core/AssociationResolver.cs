using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimCim.Core
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1815:Override equals and operator equals on value types", Justification = "Not applicable")]
    public struct AssociationResolver
    {
        public string AssociationClassName { get; set; }
        public string SourceClassName { get; set; }
        public string TargetClassName { get; set; }
        public string SourceRole { get; set; }
        public string TargetRole { get; set; }

        public AssociationResolver(
            string associationClassName,
            string sourceClassName,
            string targetClassName,
            string sourceRole,
            string targetRole)
        {
            AssociationClassName = associationClassName;
            SourceClassName = sourceClassName;
            TargetClassName = targetClassName;
            SourceRole = sourceRole;
            TargetRole = targetRole;
        }
        public IEnumerable<CimInstance> ResolveTarget(IInfrastructureObjectScope scope, CimInstance source)
        {
            if(scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            return scope.CimSession.EnumerateAssociatedInstances(scope.Mapper.CimNamespace, source, AssociationClassName, TargetClassName, SourceRole, TargetRole);
        }
        public IEnumerable<CimInstance> ResolveSource(IInfrastructureObjectScope scope, CimInstance target)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            return scope.CimSession.EnumerateAssociatedInstances(scope.Mapper.CimNamespace, target, AssociationClassName, SourceClassName, TargetRole, SourceRole);
        }
        public IObservable<CimInstance> ResolveTargetAsync(IInfrastructureObjectScope scope, CimInstance source, CimOperationOptions options = null)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            return scope.CimSession.EnumerateAssociatedInstancesAsync(scope.Mapper.CimNamespace, source, AssociationClassName, TargetClassName, SourceRole, TargetRole, options);
        }
        public IObservable<CimInstance> ResolveSourceAsync(IInfrastructureObjectScope scope, CimInstance target, CimOperationOptions options = null)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            return scope.CimSession.EnumerateAssociatedInstancesAsync(scope.Mapper.CimNamespace, target, AssociationClassName, SourceClassName, TargetRole, SourceRole, options);
        }
    }
}
