

Simple Chat created on ASP.NET Core MVC with SignalR ( real time app)

Thanks for viewing the Simple Chat, it was created for learning and practice. Simple Chat - a simple pet project ( realtime Web App 

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

The minimum requirement by Simple Chat is that your Web server supports ASP.NET Core 2.1 or above. The Simple Chat has been tested with the embedded IIS HTTP server in Windows 10. Please access the following URL to check if your Web server reaches the requirements by Simple Chat:

http://localhost:44394/ ( If you have a different port for localhost, please change the value of the string public const string AUDIENCE = "https: // localhost: 44394"; // token customer, instead of 44394 write your port number  )

QUICK START

The Simple Chat starts from its root folder. When you first start, click F5. The server is started by the Visual Studio command F5

Kostyantyn Yachnytskyi yachnytskyi1992@gmail.com