using Xunit;

namespace Nullforce.Testing.XunitTraitAttributes.Tests
{
    public class AttributeTests
    {
        [Category("CategoryOne")]
        [Category("CategoryTwo")]
        [Fact]
        public void CategoryAttributeTest()
        {
        }

        [IntegrationTest]
        [Fact]
        public void IntegrationTestAttributeTest()
        {
        }

        [Isolated]
        [Fact]
        public void IsolatedAttributeTest()
        {
        }

        [Category(TestCategory.IsolatedTest)]
        [Fact]
        public void CategoryAttribute_WithIsolatedConstant_Test()
        {
        }

        [UnitTest]
        [Fact]
        public void UnitTestAttributeTest()
        {
        }
    }
}
