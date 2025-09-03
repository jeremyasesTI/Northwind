namespace Northwind.Sales.Entities.Dtos.CreateOrder;
// Primary construcutores c#12
public class CreateOrderDetailDto(int productId, decimal unitPrice, short quantity)
{ 
    public int ProductId => productId;  // utilice solo la propiedad de escritura
    public decimal UnitPrice => unitPrice;
    public short Quantity => quantity;
}

public class CreateOrderDetailDto 
{
    private int productId;
    private decimal unitPrice;
    private short quantity;


    public int ProductId
    {
        get
        {
            return productId;
        }

    }

    public decimal UnitPrice 
    {
        get
        {
            return unitPrice;
        }

    }
    public short Quantity
    {
        get
        {
            return quantity;
        }

    }

}

