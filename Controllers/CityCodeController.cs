using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using org.ccccye.weather.citycode.core.dto;

namespace org.ccccye.weather.citycode.core.Controllers
{
    [Route("/")]
    [ApiController]
    public class CityCodeController : ControllerBase
    {
        [HttpGet("list")]
        public ActionResult<List<CityCode>> list()
        {
            using (WeatherDbContext context = new WeatherDbContext())
            {
                return context.Set<CityCode>().ToList();
            }
        }
  
        [HttpGet("queryByName/{cityname}")]
        public ActionResult<CityCode> queryByName(string cityname)
        {
            using (WeatherDbContext context = new WeatherDbContext())
            {
                CityCode city =
                    (from c in context.CityCode
                     where c.city_CN == cityname
                     select c).FirstOrDefault();
                return city;
            }
        }

        [HttpGet("queryByAdcode/{adcode}")]
        public ActionResult<CityCode> queryByAdcode(string adcode)
        {
            using (WeatherDbContext context = new WeatherDbContext())
            {
                CityCode city =
                    (from c in context.CityCode
                     where c.ad_code == adcode
                     select c).FirstOrDefault();
                return city;
            }
        }
    }
}
