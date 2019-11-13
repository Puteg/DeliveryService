using System;
using System.Collections.Generic;
using System.Linq;
using DeliveryService;
using DeliveryService.Bird;
using DeliveryService.Tortoise;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private DeliveryManager _deliveryManager;

        [SetUp]
        public void Setup()
        {
            _deliveryManager = new DeliveryManager();
            _deliveryManager.AddService(typeof(BirdQuery), new BirdDelivery());
            _deliveryManager.AddService(typeof(TortoiseQuery), new TortoiseDelivery());
        }

        [Test]
        public void GetBirdCalculateSuccess()
        {
            var query = new BirdQuery
            {
                RecipientAddress = "г. Москва п. Московский, д. Румянцево, влад. № 17А, стр. 1",
                SenderAddress = @"Калужская обл., Жуковский р-н, c. Совхоз 'Победа', ул. Парк птиц, 3/1",
            };

            var result = _deliveryManager.Get(query);
            Console.WriteLine(result);

            Assert.IsTrue(result is BirdResult);
        }

        [Test]
        public void GetTortoiseCalculateSuccess()
        {
            var query = new TortoiseQuery()
            {
                RecipientAddress = "г. Москва п. Московский, д. Румянцево, влад. № 17А, стр. 1",
                SenderAddress = "Б. Грузинская ул., 1, Москва, 123242"
            };

            var result = _deliveryManager.Get(query);
            Console.WriteLine(result);

            Assert.IsTrue(result is TortoiseResult);
        }


        [Test]
        public void GetAllCalculateSuccess()
        {
            var query = new CommonQuery(new List<CommonItem>()
            {
                new CommonItem()
                {
                    Count = 1,
                    Dimensions = 1,
                    Weight = 1,
                }
            })

            {
                RecipientAddress = "г. Москва п. Московский, д. Румянцево, влад. № 17А, стр. 1",
                SenderAddress = "ул. Большая Лубянка, 2, Москва"
            };

            _deliveryManager.GetAll(query);
        }

        public class CommonQuery : IBirdQuery, ITortoiseQuery
        {
            /// <summary>
            /// Список элементов
            /// </summary>
            private readonly List<CommonItem> _items;
            
            public CommonQuery(List<CommonItem> items)
            {
                _items = items;
            }
            
            public string SenderAddress { get; set; }
            public string RecipientAddress { get; set; }

            
            List<IBirdItem> IBirdQuery.Items => _items.Select(c => (IBirdItem) c).ToList();
            List<ITortoiseItem> ITortoiseQuery.Items =>_items.Select(c => (ITortoiseItem) c).ToList();
        }

        public class CommonItem : IBirdItem, ITortoiseItem
        {
            public int Weight { get; set; }
            public int Dimensions { get; set; }
            public int Count { get; set; }
        }
    }
}