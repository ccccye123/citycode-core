using Microsoft.EntityFrameworkCore;
using org.ccccye.weather.citycode.core.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace org.ccccye.weather.citycode.core
{
    public class WeatherDbContext : DbContext
    {
        public virtual DbSet<CityCode> CityCode { get; set; } //创建实体类添加Context中

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(@"server=47.106.122.7;uid=root;pwd=@123456;
                    port=3306;database=weather;sslmode=Preferred;charset=gb2312");
            }
        }
    }
}
