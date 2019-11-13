using System.Collections.Generic;

namespace DeliveryService.Bird
{
    public interface IBirdQuery : IDeliveryQuery
    {
        List<IBirdItem> Items { get; }
    }
}
