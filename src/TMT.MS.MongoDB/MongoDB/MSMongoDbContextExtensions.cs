using Volo.Abp;
using Volo.Abp.MongoDB;

namespace TMT.MS.MongoDB;

public static class MSMongoDbContextExtensions
{
    public static void ConfigureMS(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
