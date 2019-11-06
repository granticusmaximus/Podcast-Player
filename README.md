# Podcast-Player
A podcast web app built with C#

I have a separate document that will cover a more in depth approach at what the application can do. This **README** file is
strictly a basic, and informative solution to get the application up and running in your environment.

Tech Stack of Application:

* ASP.NET Core 3 for basis of backend
* Razor Engine for frontend
* EF core Code First to build out models for database
* SQLite for database
* .NET Core environment for Mac

Software used to create and run this application:

* Visual Studio for Mac
* SQLite Browser
* Terminal 
* Adobe XD for building wireframe 

In _later_ iterations of the **README**, I will have displays of the typical look of the application once it starts successfully

For those who have not used the .NET Core SDK in a Apple product world, here are a _few_ commands that you will need to use:

**For Adding New/Updating Entities in the database**
```
dotnet ef migrations add SomeNameYouComeUpWith
```

The **previous** command adds a scripted file into your Migrations folder of the project, this does **not** immediately add/update the information currently in the database. It just tells the computer what to do when you run the following command

```
dotnet ef database update
```

This terminal command takes the scripted function from the previous command, and takes any updates from your models from you DbContext and runs a compare and override to the database.
