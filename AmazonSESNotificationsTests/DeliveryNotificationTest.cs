﻿using AmazonSESNotifications.Models;
using NUnit.Framework;

namespace AmazonSESNotificationsTests
{
    [TestFixture]
    public class DeliveryNotificationTest
    {
        [Test(Description = "Should serialize a delivery notification (formatted as JSON) in an object")]
        public void SerializeDeliveryNotification()
        {
            AmazonSESDeliveryNotification deliveryNotification = null;
            var resource = ResourceManager.RetrieveEmbeddedResource("delivery-notification-content.json");
            if (null != resource)
            {
                deliveryNotification = Newtonsoft.Json.JsonConvert.DeserializeObject<AmazonSESDeliveryNotification>(resource);
            }
            
            Assert.IsTrue(null != deliveryNotification);
        }
    }
}