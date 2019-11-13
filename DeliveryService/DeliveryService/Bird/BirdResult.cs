namespace DeliveryService.Bird
{
    public class BirdResult : IDeliveryResult
    {
        public decimal CostOfDelivery { get; set; }
        public int DayCountFromToday { get; set; }

        public override string ToString()
        {
            return $"CostOfDelivery - {CostOfDelivery}; DayCountFromToday - {DayCountFromToday}";
        }
    }
}
