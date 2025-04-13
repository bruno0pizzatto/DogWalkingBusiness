# Dog Walking Business

Windows Forms application for managing clients and dogs in a dog walking business. Built with .NET 9, SQL Server, and Clean Architecture.

## How to Run

1. Ensure SQL Server is running.
2. Open SQL Server Management Studio, and run the following script: "\DogWalkingBusiness\DogWalkingBusiness.Infrastructure\DB_Script\DB_Script.sql"
3. Update `appsettings.json` with your SQL Server connection string.
4. Open solution in Visual Studio.
5. Set `DogWalkingBusiness.WinFormsUI` as startup project.
6. Build and run the application.

## Features

- Add, update, delete clients and their dogs.
- Record dog walks (date, duration).
- Search and view entries.
- Data persistence with SQL Server.
- Clean architecture separation (Domain, Application, Infrastructure, UI).
