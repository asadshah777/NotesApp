# NotesApp

A simple notes application built with ASP.NET Core MVC and PostgreSQL.

## Features
- Create, Read, Update, and Delete notes.
- Built using ASP.NET Core MVC (.NET 9.0).
- Uses Entity Framework Core with PostgreSQL.

## Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [PostgreSQL](https://www.postgresql.org/)

## Setup Instructions

1. **Clone the repository:**
   ```bash
   git clone <your-repo-url>
   cd NotesApp
   ```

2. **Database Configuration:**
   Create an `appsettings.json` file in the root directory (if it's not already there) and add your PostgreSQL database connection string:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Database=NotesAppDb;Username=postgres;Password=yourpassword"
     }
   }
   ```

3. **Apply Database Migrations:**
   Run the following command to apply the Entity Framework Core migrations and create the database:
   ```bash
   dotnet ef database update
   ```

4. **Run the Application:**
   ```bash
   dotnet run
   ```
   The application will start, and you can access it in your browser.
