using System;
using System.Collections.Generic;
using System.Text;

namespace ADOP_Project_Part_B_Weather.Models
{
    public class Forecast
    {
        public string City { get; set; }
        public List<ForecastItem> Items { get; set; }
    }
}
