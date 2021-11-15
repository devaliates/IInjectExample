namespace Service.WebAPI;

public static class UseServices
{
    public static IServiceCollection AddOpenApi_(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new() { Title = "Service.WebAPI", Version = "v1" });
        });

        return services;
    }
}