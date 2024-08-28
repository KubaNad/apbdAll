namespace Cw6.WarehouseV2;

public static class ConfigurationsForProductWarehouse
{
    public static void RegisterEndpointsForProductWarehouse(this IEndpointRouteBuilder app)
    {
        
        
        app.MapPost("/api/products", async (ProductWarehouse productWarehouse, IProductWarehouseService service) => 
        {
            try
            {
                var productWarehouseId = await service.AddProductToWarehouseAsync(productWarehouse);
                return Results.Ok(productWarehouseId);
                // return Results.Ok(new { IdProductWarehouse = productWarehouseId });
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        });
        
    }
}