@echo off
set /p name="Migration name: "
dotnet ef migrations add %name% ^
  --project CopilotJuniorAspNetDeveloper.Infrastructure ^
  --startup-project CopilotJuniorAspNetDeveloper.Web