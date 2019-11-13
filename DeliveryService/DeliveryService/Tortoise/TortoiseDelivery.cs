using System;

namespace DeliveryService.Tortoise
{
    public class TortoiseDelivery : IDelivery
    {
        /// <summary>
        /// Базовую стоимость
        /// </summary>
        private decimal _basePrice = 150;

        public IDeliveryResult Calculate(IDeliveryQuery query)
        {
            var tortoiseQuery = query as ITortoiseQuery;
            if (tortoiseQuery == null)
                throw new ArgumentException("BirdDelivery не может выполнить расчёт");

            return Calc(tortoiseQuery);
        }

        private TortoiseResult Calc(ITortoiseQuery query)
        {
            Console.WriteLine("TortoiseDelivery Calculate");
            return new TortoiseResult();
        }
    }
}
