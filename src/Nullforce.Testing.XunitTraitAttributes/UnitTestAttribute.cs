using System;
using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Nullforce.Testing.XunitTraitAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    [TraitDiscoverer(TestingConstants.AssemblyName + "." + nameof(UnitTestDiscoverer), TestingConstants.AssemblyName)]
    public class UnitTestAttribute : Attribute, ITraitAttribute
    {
        public UnitTestAttribute()
        {
        }
    }

    public class UnitTestDiscoverer : ITraitDiscoverer
    {
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            yield return new KeyValuePair<string, string>(TestingConstants.Category, TestCategory.UnitTest);
        }
    }
}
