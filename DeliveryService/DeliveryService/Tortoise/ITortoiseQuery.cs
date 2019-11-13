using System.Collections.Generic;

namespace DeliveryService.Tortoise
{
    public interface ITortoiseQuery : IDeliveryQuery
    {
        List<ITortoiseItem> Items { get; }
    }
}
