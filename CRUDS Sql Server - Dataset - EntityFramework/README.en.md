*[Leer en español](README.md)*

# SQL Server CRUDs: ADO.NET, DataSet, and Entity Framework

A C# (Windows Forms) desktop application for managing person records on SQL
Server: create, edit, delete, and query.

The point of this repository isn't the CRUD itself, but **solving the same data
access problem three different ways** in .NET: raw ADO.NET, typed DataSet, and
Entity Framework (Database-First). All three share the same interface and logic;
only the persistence layer changes.

## Prerequisites

To run these projects in your local environment, you need the following installed:

* .NET 8 SDK
* Visual Studio 2022
* SQL Server (Express or Developer Edition)
* SQL Server Management Studio (SSMS) or a similar tool to run scripts (**OPTIONAL**).

## Database Setup and Execution

Because these projects use ADO.NET and Database-First approaches, the corresponding database and its tables must be created manually before running the application.

**General steps to run it for the first time:**

1. Clone this repository to your local machine.
2. Open SQL Server Management Studio (SSMS) and connect to your local server (`.\SQLEXPRESS`).
3. Run the provided SQL scripts to create the database and the specific tables required by each project (note that each project uses a different table).
4. Open the solution (`.sln`) in Visual Studio.

**Specific configuration depending on the project you want to try:**

* **CRUD Sql Server y ADO.NET:**
    * This project uses raw ADO.NET. If your server is named `.\SQLEXPRESS`, it's already configured. You just need to set it as the **Startup Project**.

* **CRUD Sql Server y Dataset:**
    * If your server is named `.\SQLEXPRESS`, it's already configured.
    * If not, go to the Solution Explorer, open the `DatosDS.xsd` file, go to the properties of **"Personas2TableAdapter"**, and modify the **ConnectionString** under **Connection** to match your local SQL Server instance name.

* **CRUD Sql Server y Entity Framework:**
    * This project uses Entity Framework with the Database-First approach.
    * If your server is named `.\SQLEXPRESS`, it's already configured.
    * If not, open the **`Models`** folder, open the **"CRUDconEntityFramework"** class, and update the `Server` value in the connection string to match your local server.

Once your chosen project is configured, make sure it's set as the startup project, then build and run the solution.

---

## Author

**Leonel Maximiliano Blumberg**
Software Developer | .NET · C# · ASP.NET · SQL | Systems Engineering Student

[LinkedIn](https://www.linkedin.com/in/leonel-blumberg) · [GitHub](https://github.com/Leonel-Blumberg) · [Email](mailto:leonelblumberg.it@gmail.com)
