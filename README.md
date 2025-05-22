# Commodity Request Form

A web-based form for Community Health Workers (CHWs) to request commodities, with validation rules, data logs, and request tracking. Built using **ASP.NET Core Razor Pages** and **Entity Framework Core**.

## 📌 Features

- Dashboard view of all commodity requests
- Form submission for commodity requests by CHWs
- Automatic assignment of CHA (Community Health Assistant) based on selected CHW
- Commodity dropdown list is dynamically populated from the database
- Request validation:
  - Quantity must be a whole number
  - Quantity must be less than 100 units per request
  - A CHW can request a maximum of 200 units per commodity per month
  - Only one request per CHW per commodity per day
- Logs all submissions for transparency and audit

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (.NET 6 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or LocalDB
- Visual Studio or VS Code

### Setup Instructions

1. **Clone the repository**
   ```bash
   git@github.com:Kinyanjui-gladwell/Commodity-Request-Form.git
   cd commodity-request-form
2. **Set up the database**
   ```bash
     "ConnectionStrings": {
    "DefaultConnection": "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FormBackend;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"}
3. **Apply migrations and seed the database**
   ```bash
   dotnet ef database update
4. **Run the application**
   ```bash
   dotnet run
## 📄 Project Structure

- `Pages/Commodities/Index.cshtml` – Dashboard listing all requests  
- `Pages/Commodities/Create.cshtml` – Form for CHWs to request commodities  
- `Data/DataContext.cs` – EF Core DB context with relationships and constraints  
- `Models/` – Entity classes (Commodity, CHW, CHA)  
- `Enums/` – Enum for status values (e.g., Pending, Approved, Rejected)
## ✅ Data Validation Rules

The system enforces the following rules when submitting a commodity request:

1. **Whole Numbers Only**: Quantity must be a whole number (integers only).
2. **Maximum Quantity per Request**: Quantity must be **less than 100** per individual request.
3. **Monthly Cap**: A CHW can request **no more than 200 units per commodity per month**.
4. **One Request per Day Rule**: Only **one request per CHW per commodity per day** is allowed.
5. **Dynamic Commodity List**: Commodities are dynamically listed and can be added without modifying the form.

Validation is enforced both at the server side and through user feedback in the form.
