Accounts for Authorization:

admin user Email = "admin@mail.ru", Password = "123456"   
admin user Email = tom@mail.ru", Password = "123456"      
user       Email = "bob@mail.ru", Password = "123456"user  Email = "sam@mail.ru", Password = "123456"




Simple Chat created on ASP.NET Core MVC with SignalR ( real time app with WebSockets and Javascript )

Thanks for viewing the Simple Chat, it was created for learning and practice. Simple Chat - a simple pet project ( realtime Web App )

Build Status

Simple Chat version 1.1

INSTALLATION

Please make sure the release file is unpacked under a Web-accessible directory. You shall see the following files and directories:

Controllers/  
Models/  
Properties/  
wwwroot/  
AuthOptions.cs  
ChatHub.cs    
CustomUserIdProvider.cs   
Program.cs   
Startup.cs     
package-lock.json   
package.json   
simple_chat.csproj

REQUIREMENTS

The minimum requirement by Simple Chat is that Your Web server supports ASP.NET Core 2.1 or above. The Simple Chat has been tested with the embedded IIS HTTP server in Windows 10. Please access the following URL to check if Your Web server reaches the requirements by Simple Chat:

http://localhost:44394/ ( If You have a different port for localhost, please open the file AuthOptions.cs and change the value of the string public const string AUDIENCE = "https: // localhost: 44394"; instead of 44394 write Your port number.  )

QUICK START

The Simple Chat starts from its root folder. When You first start, click F5. The server is started by the Visual Studio command F5

Kostyantyn Yachnytskyi yachnytskyi1992@gmail.com
