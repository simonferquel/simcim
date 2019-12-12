using CaseExtensions;
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCim.Generator
{
    internal class CimTypeDeclaration
    {
        private readonly CimClass _cimClass;
        private readonly List<AssociationToResolve> _associations = new List<AssociationToResolve>();

        public CimTypeDeclaration(CimClass cimClass)
        {
            _cimClass = cimClass;
        }

        public string Name => _cimClass.CimSystemProperties.ClassName;

        public string CSharpName => Name.ToPascalCase();
        public CimTypeDeclaration GetParent(IDictionary<string, CimTypeDeclaration> map) => _cimClass.CimSuperClassName == null ? null : map[_cimClass.CimSuperClassName];
        public bool HasPropertyWithSameType(CimPropertyDeclaration prop, IDictionary<string,CimTypeDeclaration> typeRepo)
        {
            var candidate = _cimClass.CimClassProperties[prop.Name];
            if (candidate == null)
            {
                var parent = GetParent(typeRepo);
                if (parent == null)
                {
                    return false;
                }
                return parent.HasPropertyWithSameType(prop, typeRepo);
            }
            return candidate.ResolveType(typeRepo, out var _).ToString() == prop.ResolveType(typeRepo, out var __).ToString();
        }

        public IEnumerable<string> SymbolNames(IDictionary<string, CimTypeDeclaration> typeRepo)
        {
            foreach (var p in Properties)
            {
                yield return p.Name.ToPascalCase();
            }
            foreach (var m in Methods)
            {
                yield return m.Name.ToPascalCase();
            }
            if(typeRepo == null)
            {
                yield break;
            }
            var parent = GetParent(typeRepo);
            if(parent == null)
            {
                yield break;
            }
            foreach(var name in parent.SymbolNames(typeRepo))
            {
                yield return name;
            }
        }
        private bool HasBooleanQualifierSet(string name) => _cimClass.CimClassQualifiers.Where(q => q.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && q.Value is bool == true).Any();
        public bool IsAbstract => HasBooleanQualifierSet("Abstract");
        public bool IsAssociation => HasBooleanQualifierSet("Association");

        internal void AddAssociation(CimTypeDeclaration association, CimPropertyDeclaration thisSide)
        {
            _associations.Add(new AssociationToResolve
            {
                AssociationType = association,
                ThisSideOfAssociation = thisSide
            });
        }

        public bool IsAggregation => HasBooleanQualifierSet("Aggregation");
        public bool IsSingleton => HasBooleanQualifierSet("Singleton");

        public IEnumerable<string> GetAncestorCimTypeNames(IDictionary<string, CimTypeDeclaration> typeRepo)
        {
            var p = GetParent(typeRepo);
            if(p == null)
            {
                yield break;
            }
            foreach(var n in p.GetAncestorCimTypeNames(typeRepo))
            {
                yield return n;
            }
            yield return p.Name;
        }
        public bool IsEvent(IDictionary<string, CimTypeDeclaration> typeRepo) => GetAncestorCimTypeNames(typeRepo).Contains("__Event");

        public IEnumerable<CimPropertyDeclaration> Properties => _cimClass.CimClassProperties;

        public IEnumerable<CimMethodDeclaration> Methods => _cimClass.CimClassMethods;

        public IEnumerable<AssociationToResolve> Associations => _associations;
    }

    internal struct AssociationToResolve
    {
        public CimTypeDeclaration AssociationType { get; set; }
        public CimPropertyDeclaration ThisSideOfAssociation { get; set; }
    }
}
