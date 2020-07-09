using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace org.ccccye.weather.citycode.core.dto
{
    public class CityCode
    {
        [Key]
        public string city_ID { get; set; }
        public string city_EN { get; set; }
        public string city_CN { get; set; }
        public string ad_code { get; set; }

    }
}
