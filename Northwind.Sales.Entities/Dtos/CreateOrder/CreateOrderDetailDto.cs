namespace Northwind.Sales.Entities.Dtos.CreateOrder;
// Primary construcutores c#12

#region Primary contructors c#12
// esto srive solo para lectura
public class CreateOrderDetailDto(int productId, decimal unitPrice, short quantity)
{
    public int ProductId => productId;  // utilice solo la propiedad de escritura
    public decimal UnitPrice => unitPrice;
    public short Quantity => quantity;
}

#endregion


#region c# 2.0
//public class CreateDetailDto
//{
//    private int _productId;
//    private decimal _unitPrice;
//    private short _quantity;

//    public CreateDetailDto(int productoId, decimal unitPrice, short quantity)
//    {
//        _productId = productoId;
//        _unitPrice = unitPrice;
//        _quantity = quantity;
//    }

//    public int ProductId {
//        get { 
//            return _productId;
//        }    
//    }

//    public decimal UnitPrice
//    {
//        get {
//            return _unitPrice;
//        }
//    }

//    public short Quantity
//    {
//        get
//        {
//            return _quantity;
//        }
//    }
//}

#endregion

#region Propiedades automaticas c#3.0
//public class CreateOrderDetailDto
//{


//    public int ProductId { get; private set; }
//    public decimal UnitPrice { get; private set; }
//    public short Quantity { get; private set; }

//    public CreateOrderDetailDto(int productId, decimal unitPrice, short quantity)
//    {
//        ProductId = productId;
//        UnitPrice = unitPrice;
//        Quantity = quantity;
//    }
//}


#endregion