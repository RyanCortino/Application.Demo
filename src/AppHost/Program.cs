var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

builder.AddProject<Projects.Web>("web").WithReference(cache);

builder.Build().Run();
