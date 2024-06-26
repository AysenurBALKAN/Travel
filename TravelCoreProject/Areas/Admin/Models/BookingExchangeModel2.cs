﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.Areas.Admin.Models
{
    public class BookingExchangeModel2
    {
        public Exchange_Rates[] exchange_rates { get; set; }
        public string base_currency_date { get; set; }
        public string base_currency { get; set; }

        public class Exchange_Rates
        {
            public string currency { get; set; }
            public string exchange_rate_buy { get; set; }
        }

    }
}
