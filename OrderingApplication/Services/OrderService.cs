﻿using OrderingApplication.Models;
using System;
using System.Collections.Generic;

namespace OrderingApplication.Services
{
    public class OrderService : IOrderService
    {
        public List<OrderSummary> GetOrders()
        {
            return new List<OrderSummary>()
            {
                 new OrderSummary() { Stage = "Intake", Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-2), Description = "Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new OrderSummary() { Stage = "Billing", Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-3), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new OrderSummary() { Stage = "Shipped", Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-8), Description = "Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new OrderSummary() { Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-2), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new OrderSummary() { Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-5), Description = "Maecenas sed diam eget risus varius blandit. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new OrderSummary() { Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-15), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." }
            };
        }
    }


}
