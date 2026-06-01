# Nullforce.Testing.XunitTraitAttributes

A collection of Attributes to use with xUnit.net v2.

## Attribute Examples

### CategoryAttribute
The `CategoryAttribute` allows you to assign custom categories to your tests. This attribute can be applied to classes or methods and supports multiple categories per test.

**Usage:**
```csharp
[Category("MyCustomCategory")]
[Fact]
public void MyTest()
{
}
```

### IntegrationTestAttribute
The `IntegrationTestAttribute` is used to mark tests that perform integration testing. These tests typically involve external dependencies like databases, web services, or file systems.

**Usage:**
```csharp
[IntegrationTest]
[Fact]
public void MyIntegrationTest()
{
}
```

### IsolatedAttribute
The `IsolatedAttribute` marks tests that should run in isolation, meaning they should not share state with other tests. This is useful for tests that might modify global state or have side effects.

**Usage:**
```csharp
[Isolated]
[Fact]
public void MyIsolatedTest()
{
}
```

### UnitTestAttribute
The `UnitTestAttribute` is used to mark tests that perform unit testing. These tests are typically fast, isolated, and test individual units of code without external dependencies.

**Usage:**
```csharp
[UnitTest]
[Fact]
public void MyUnitTest()
{
}
```
