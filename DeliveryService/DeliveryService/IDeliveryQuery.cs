namespace DeliveryService
{
    public interface IDeliveryQuery
    {
        string SenderAddress { get; set; }
        string RecipientAddress { get; set; }
    }
}
