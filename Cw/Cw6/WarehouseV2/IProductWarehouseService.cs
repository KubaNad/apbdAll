namespace Cw6.WarehouseV2;

public interface IProductWarehouseService
{
    Task<int> AddProductToWarehouseAsync(ProductWarehouse productWarehouse);    

}