namespace DeliveryService.Tortoise
{
    public class TortoiseItem : ITortoiseItem
    {
        public int Weight { get; set; }
        public int Dimensions { get; set; }
        public int Count { get; set; }
    }
}
