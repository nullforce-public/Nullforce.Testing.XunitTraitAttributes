using System;
using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Nullforce.Testing.XunitTraitAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    [TraitDiscoverer(TestingConstants.AssemblyName + "." + nameof(IsolatedDiscoverer), TestingConstants.AssemblyName)]
    public class IsolatedAttribute : Attribute, ITraitAttribute
    {
    }

    public class IsolatedDiscoverer : ITraitDiscoverer
    {
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            yield return new KeyValuePair<string, string>(TestingConstants.Category, TestCategory.IsolatedTest);
        }
    }
}
