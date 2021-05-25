# Dotnet RPG

Project from this blog post [here](https://dev.to/_patrickgod/more-than-just-crud-with-net-core-3-1-part-2-32na)

### Prerequisites
-  [.NET Core SDK](https://dotnet.microsoft.com/download)
-  [Entity Framework Core SDK](https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli)

### Description
This is an API for a Role Playing Game.

## SQLServer Setup with Docker
Open a Terminal window and run the following command to Download SQL Server
```
sudo docker pull mcr.microsoft.com/mssql/server:2019-latest
```

Run the following command to launch an instance of the Docker image you just downloaded:
```
docker run -d --name sql_server_demo -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=reallyStrongPwd123' -p 1433:1433 mcr.microsoft.com/mssql/server:2019-latest
```
But of course, use your own name and password. Also, if you downloaded a different Docker image, replace mcr.microsoft.com/mssql/server:2019-latest with the one you downloaded

If you get the following error at this step, try again, but with a stronger password.
```
Microsoft(R) SQL Server(R) setup failed with error code 1. Please check the setup log in /var/opt/mssql/log for more information.
```

Run the following command to install the sql-cli command line tool. This tool allows you to run queries and other commands against your SQL Server instance.
```
sudo npm install -g sql-cli
```

Connect to SQL Server using the mssql command, followed by the username and password parameters.
```
mssql -u sa -p reallyStrongPwd123
```

You should see something like this:
```
Connecting to localhost...done

      sql-cli version 0.6.0
      Enter ".help" for usage hints.
      mssql>
```
## Restore dependencies specified in the project
```
dotnet restore
```

## Build project
```
dotnet build
```

## Run migrations
```
dotnet ef database update
```

## Run project
```
dotnet run
```

### Run the project in development
```bash
dotnet watch run
```

## Author

*   **Ryan Wire** 

## Notes
### Create the database
Run the following commands:
```
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Create a migration
```
dotnet ef migrations add initialMigration
```
### Undo migrations
```
dotnet ef migrations remove
```

## Set user secrets
```
dotnet user-secrets set "InitialCatalog" ""
dotnet user-secrets set "UserID" "" 
dotnet user-secrets set "Password" "" 
```

## List user secrets
````
dotnet user-secrets list  
```
