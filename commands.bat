dotnet new tool-manifest
dotnet tool install --local dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add Initial
dotnet ef database update --connection "User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=test;"
