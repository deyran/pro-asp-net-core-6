# Chapter 2: Getting Started

## Running the ASP.NET Core Application

When the project is created, a file named **launchSettings.json** is created in the **Properties** folder, and it is this file that determinates which HTTP port ASP.NET Core will use to listen for HTTP requests. The content of the launchSettings.json file can be shown in the code bellow:

```
{
  "$schema": "http://json.schemastore.org/launchsettings.json",
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:5000",
      "sslPort": 0
    }
  },
  "profiles": {
    "http": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "applicationUrl": "http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
```

### Understanding Endpoints
### Understanding Routes
### Understanding HTML Rendering
### Putting the pieces together