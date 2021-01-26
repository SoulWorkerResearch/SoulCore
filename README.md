#### Project setup
Add a nuget.config file to your project, in the same folder as your .csproj or .sln file

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="SoulCore@Local" value="https://pkgs.dev.azure.com/sawich0914/SoulCore/_packaging/SoulCore%40Local/nuget/v3/index.json" />
  </packageSources>
</configuration>
```
