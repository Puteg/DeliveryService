using DeliveryService.Bird;

namespace DeliveryService.Tortoise
{
    public interface ITortoiseItem : IItem
    {
        int Count { get; }
    }
}
