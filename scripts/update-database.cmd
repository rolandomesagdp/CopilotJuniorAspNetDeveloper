@echo off
dotnet ef database update ^
  --project CopilotJuniorAspNetDeveloper.Infrastructure ^
  --startup-project CopilotJuniorAspNetDeveloper.Web