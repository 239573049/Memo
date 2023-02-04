namespace Microsoft.Extensions.DependencyInjection;

public static class MemoComponentExtension
{
    public static IServiceCollection AddMemoComponent(this IServiceCollection services,string connectionString)
    {
        services.AddMemoService(connectionString);
        services.AddMasaBlazor();

        return services;
    }
}