# Employee Relations Web App
This is the third week assignment project on ASP .NET Web API in which I designed a Employee Relations App.

- Tech: ASP .NET Web API, JavaScript, AJAX, jQuery, HTML, CSS.

 ## Reuirements:
 - VS Code -> Updated version (newer).
 - dotnet -> New version.
 - VS Code Extensions -> C#, c#-extension tool, and code runner.
 - Server -> SQL Server Management Studio
 
 ## Process to run app
 - Create a 2-tables(Empharshit.cs | HarshitAuth.cs) as show in Models folder.
 - Create a new asp.net web api project -> dotnet new webapi --name ProjectName
 - cd ProjectName, code . (to open that project in VS Code).
 - Scaffold your database in your Models folder.
 - Install all dotnet packages by Microsoft.EntityFrameworkCore.Mvc like SqlServer, tools, Design, code-generator
 - Use your dbContext.cs in your controllers.
 - Controllers like LoginController.cs and EmpController.cs are mentioned in Controller folder.
 - HTTP request methods are metioned there.
 - dotnet build
 - dotnet run --launch-profile https (run to https url link)
 - Goto Web API Swagger -> https://localhost:portNo/swagger/index.html 
 - Test your APIs here on swagger like Postman(API Testing tool).
 - Now open your Reguster.html file from UserInterface folder in your browser.
 - Register and Login using your Username and Password, then Logout successfully.
