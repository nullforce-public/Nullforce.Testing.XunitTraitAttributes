using System;
using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Nullforce.Testing.XunitTraitAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    [TraitDiscoverer(TestingConstants.AssemblyName + "." + nameof(IntegrationTestDiscoverer), TestingConstants.AssemblyName)]
    public class IntegrationTestAttribute : Attribute, ITraitAttribute
    {
        public IntegrationTestAttribute()
        {
        }
    }

    public class IntegrationTestDiscoverer : ITraitDiscoverer
    {
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            yield return new KeyValuePair<string, string>(TestingConstants.Category, TestCategory.IntegrationTest);
        }
    }
}
