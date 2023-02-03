namespace Microsoft.Extensions.DependencyInjection;

public static class MemoComponentExtension
{
    public static IServiceCollection AddMemoComponent(this IServiceCollection services)
    {
        services.AddMasaBlazor();
        return services;
    }
}