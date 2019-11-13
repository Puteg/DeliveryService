using System;

namespace DeliveryService.Bird
{
    public class BirdDelivery :  IDelivery
    {
        public IDeliveryResult Calculate(IDeliveryQuery query)
        {
            var birdQuery = query as IBirdQuery;
            if (birdQuery == null)
                throw new ArgumentException("BirdDelivery не может выполнить расчёт");

            return Execute(birdQuery);
        }

        private BirdResult Execute(IBirdQuery query)
        {
            Console.WriteLine("BirdDelivery Calculate");
            return new BirdResult();
        }
    }
}
