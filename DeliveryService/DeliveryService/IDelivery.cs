namespace DeliveryService
{
    public interface IDelivery
    {
        IDeliveryResult Calculate(IDeliveryQuery query);
    }
}
