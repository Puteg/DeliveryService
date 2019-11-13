using System;
using System.Collections.Generic;

namespace DeliveryService
{
    public class DeliveryManager
    {
        private readonly Dictionary<Type, IDelivery> _services = new Dictionary<Type, IDelivery>();
        
        public void AddService(Type type, IDelivery delivery)
        {
            _services.Add(type, delivery);
        }

        public List<IDeliveryResult> GetAll(IDeliveryQuery query)
        {
            var result = new List<IDeliveryResult>();

            foreach (var delivery in _services)
            {
                result.Add(delivery.Value.Calculate(query));
            }

            return result;
        }

        public IDeliveryResult Get<TQ>(TQ query) where TQ: IDeliveryQuery
        {
            return _services[typeof(TQ)].Calculate(query);
        }
    }
}
