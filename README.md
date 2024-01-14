Watch Party Website with ASP.NET Core MVC and Multi-Layer ASP.NET Core Web API
Overview
This repository contains the source code for a Watch Party Website developed using ASP.NET Core MVC and a multi-layer ASP.NET Core Web API. The application is designed to watch online watch parties, allowing users to synchronize their viewing experience and interact with each other in real-time.

Features
User Authentication: Secure user authentication using ASP.NET Core Identity.
Watch Party Creation: Users can create watch parties for various media content.
Real-Time Synchronization: Seamless synchronization of video playback across all participants.
Chat Functionality: Real-time chat functionality for participants to communicate during the watch party.
Multi-Layer Architecture: The application is structured with a multi-layer architecture, separating concerns for better maintainability and scalability.
Technologies Used
ASP.NET Core MVC: Framework for building modern, cloud-based, and internet-connected applications.
ASP.NET Core Web API: Building blocks for creating RESTful services.
Entity Framework Core: Object-relational mapper for database interaction.
SignalR: Library for real-time web functionality, enabling bi-directional communication between clients and the server.
ASP.NET Core Identity: Framework for managing user authentication and authorization.

Getting Started
Clone the Repository:

bash
Copy code
git clone https://github.com/your-username/watch-party-website.git
cd watch-party-website
Database Setup:

Update the connection string in appsettings.json of the WatchParty.Api project.
Run Entity Framework migrations:
bash
Copy code
cd WatchParty.Api
dotnet ef database update
Run the Application:

Open the solution in Visual Studio or your preferred IDE.
Set both WatchParty.Web and WatchParty.Api as startup projects.
Run the solution. 
