using System.Collections.Generic;

namespace DeliveryService.Tortoise
{
    public class TortoiseQuery : ITortoiseQuery
    {
        public string SenderAddress { get; set; }
        public string RecipientAddress { get; set; }
        public List<ITortoiseItem> Items { get; set; }

        public override string ToString()
        {
            return $"SenderAddress - {SenderAddress}\n RecipientAddress - {RecipientAddress}\n Items - {Items}";
        }
    }
}
