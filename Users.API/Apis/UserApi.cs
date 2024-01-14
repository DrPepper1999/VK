namespace Users.API.Apis;

public static class UserApi
{
    public static IEndpointRouteBuilder MapUserApi(this IEndpointRouteBuilder app)
    {
        app.MapGet("/users", () => TypedResults.Ok("test"));

        return app;
    }
}