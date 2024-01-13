namespace User.API.Apis;

public static class UserApi
{
    public static IEndpointRouteBuilder MapOrderApi(this IEndpointRouteBuilder app)
    {
        app.MapPost("/orders", CreateOrder);
        app.MapGet("/orders", GetAllOrders);
        app.MapGet("/orders/{id}", GetOrder);
        app.MapDelete("/orders", DeleteOrder);

        return app;
    }
}