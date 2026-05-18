using Outputs.Documents.Domain;

namespace Outputs.Documents.Domain.UnitTests;

public sealed class DomainSearchAttributeTests
{
    [Fact]
    public void DomainSearchAttribute_CarriesSemanticMetadata()
    {
        var attribute = new DomainSearchAttribute(
            "User name",
            "Login or display identifier for a user.")
        {
            Aliases = ["username", "login"],
            Tags = ["identity", "user"]
        };

        Assert.Equal("User name", attribute.Name);
        Assert.Equal("Login or display identifier for a user.", attribute.Description);
        Assert.Equal(["username", "login"], attribute.Aliases);
        Assert.Equal(["identity", "user"], attribute.Tags);
    }
}
