using System;

namespace DeliveryService.Tortoise
{
    public class TortoiseResult : IDeliveryResult
    {
        public int CostFactor { get; set; }
        public DateTime DeliveryDate { get; set; }

        public override string ToString()
        {
            return $"CostFactor - {CostFactor}, DeliveryDate - {DeliveryDate}";
        }
    }
}
