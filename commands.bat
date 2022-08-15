dotnet new tool-manifest
dotnet tool install --local dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add Initial
