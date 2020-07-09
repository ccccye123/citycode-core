# 中国城市编码查询

提供一个方便查询中国城市编码的服务，数据源是从 [和风天气](https://dev.heweather.com/docs/refer/city) 公开渠道下载并转成mysql存储

# .Net Core版本

基于.Net Core3.1构建，原版本是 [Java](https://github.com/ccccye123/CityCode)，为什么要用.Net Core再实现一遍呢？因为Java版本使用了SpringBoot，Docker容器运行起来直接占用200M+的内存空间，对我的2G内存ECS来说占用太多了，因此使用.Net Core实现后占用降到65M，接口全部保持一致

# 接口

- /list  获取全部记录

- /queryByName/{cityname}  // 根据城市名称查询

- /queryByAdcode/{adcode}  // 根据城市adcode查询