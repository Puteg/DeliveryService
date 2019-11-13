using System.Collections.Generic;

namespace DeliveryService.Bird
{
    public class BirdQuery : IBirdQuery
    {
        public string SenderAddress { get; set; }
        public string RecipientAddress { get; set; }
        public List<IBirdItem> Items { get; set; }
    }
}
