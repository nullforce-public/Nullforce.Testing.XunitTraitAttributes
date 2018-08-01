using System;
using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;


namespace Nullforce.Testing.XunitTraitAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    [TraitDiscoverer(TestingConstants.AssemblyName + "." + nameof(CategoryDiscoverer), TestingConstants.AssemblyName)]
    public class CategoryAttribute : Attribute, ITraitAttribute
    {
        internal readonly string _categoryName;

        public CategoryAttribute(string categoryName)
        {
            _categoryName = categoryName;
        }
    }

    public class CategoryDiscoverer : ITraitDiscoverer
    {
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            var categoryName = traitAttribute.GetNamedArgument<string>("_categoryName");

            yield return new KeyValuePair<string, string>(TestingConstants.Category, categoryName);
        }
    }
}
