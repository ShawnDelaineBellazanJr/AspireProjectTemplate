var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ProjectName_ApiService>("projectname-apiservice");

builder.Build().Run();
