namespace Course.Entities.Enums
{
    //Derivação de tipos ":"
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
