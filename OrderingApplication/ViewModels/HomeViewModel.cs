using OrderingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<OrderSummary> Orders { get; set; }
    }
}
