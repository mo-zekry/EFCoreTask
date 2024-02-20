# EFCoreTask

## Database Schema

![Database Schema](img/database.png)

## Dependencies

The following packages are required to run EFCoreTask:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.Extensions.Logging

To install these packages, use the following NuGet commands:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-ef
```