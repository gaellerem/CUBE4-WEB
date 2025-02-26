# JamaisASec-Site
Une interface web e-commerce développée par Razor utilisant Blazor (ASP.NET Core).

## À propos du projet
JamaisASec-Site est une plateforme e-commerce permettant aux utilisateurs de parcourir des articles, de créer un compte, de se connecter et d'effectuer des achats en ligne.
L'application est construite avec Blazor (ASP.NET Core).

## Technologies utilisées

- Blazor WebAssembly : Framework front-end
- ASP.NET Core : Framework back-end
- Entity Framework Core : ORM pour l'accès aux données
- Identity : Système d'authentification et d'autorisation
- Bootstrap : Framework CSS pour le design responsive

## Mise en route
Prérequis

- .NET 7.0 SDK ou supérieur
- Un IDE comme Visual Studio 2022 ou VS Code avec les extensions C#
- SQL Server (ou autre base de données compatible avec EF Core)

## Installation

Clonez le dépôt
`git clone https://github.com/votre-utilisateur/JamaisASec-Site.git`
cd JamaisASec-Site

Restaurez les packages NuGet
`dotnet restore`

Appliquez les migrations pour créer la base de données
`dotnet ef database update`

Exécutez l'application
`dotnet run`

Accédez à l'application dans votre navigateur à https://localhost:5001 ou http://localhost:5000

Configuration
Les paramètres de l'application peuvent être modifiés dans les fichiers :

appsettings.json : Configuration de production
appsettings.Development.json : Configuration de développement

