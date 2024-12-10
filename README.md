# ConfigSetting

ConfigSetting is an ASP.NET Core Web API project designed to demonstrate how to use `IOptions<T>` and `IConfiguration` to manage and read custom configuration settings from `appsettings.json`.

## Features

1. **Custom Configuration Handling**:
   - The `CustomerConfig` class maps directly to the `CustomerConfig` section in the `appsettings.json` file.
   
2. **Configuration Access**:
   - Demonstrates three methods to access configuration values:
     - Using `IConfiguration.GetSection`
     - Using `IConfiguration.GetValue`
     - Using `IOptions<CustomerConfig>`

3. **Swagger Integration**:
   - Includes Swagger (via `Swashbuckle.AspNetCore`) for API documentation and testing.

# How to Run the Project

1. Prerequisites:
  .NET 8.0 SDK or higher
  An IDE or text editor like Visual Studio, VS Code, or JetBrains Rider
2. Steps to Build and Run:
```bash
# Clone the repository
git clone https://github.com/YuZhang326/ConfigSetting
cd ConfigSetting

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the project
dotnet run
```
3. Access the API:
  Swagger UI is available at: https://localhost:5001/swagger
4. 

## Example `appsettings.json`

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "CustomerConfig": {
    "EmailKey": "666666",
    "AdminEmail": "66@66.66",
    "API_URL": "https://666666.com"
  }
}
