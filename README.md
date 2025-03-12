# Windows Forms CRUD Application

## Description
This is a Windows Forms application built using **Visual Studio 2022** that demonstrates **CRUD (Create, Read, Update, Delete)** operations. The application allows users to enter a **ID, Name, and Age** and perform database operations seamlessly.

## Features
- Insert new records
- Update existing records
- Delete records
- Search by ID
- User-friendly Windows Forms interface

## Technologies Used
- **C# (.NET Framework/.NET Core)**
- **Windows Forms (WinForms)**
- **SQL Server (for database operations)**
- **Visual Studio 2022**

## Installation

1. Clone this repository:
   ```bash
   git clone https://github.com/prensisahu/WindowsForms.git
   ```
2. Open the project in **Visual Studio 2022**.
3. Restore NuGet packages (if required).
4. Update the database connection string in `App.config` or in the database-related code.
5. Build and run the application.

## Usage
1. Launch the application.
2. Enter ** ID, Name, and Age** in the input fields.
3. Click **Insert** to add a new record.
4. Click **Update** to modify an existing record.
5. Click **Delete** to remove a user.
6. Click **Search** to find a ID.

## Database Schema
```sql
CREATE TABLE ut (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    age INT
);
```

## Screenshots
![Screenshot 2025-03-12 210614](https://github.com/user-attachments/assets/f777625d-6848-47a7-85f1-7809b4b7132b)



## Contributing
If you want to contribute to this project, feel free to fork the repository and submit a pull request.

## License
This project is licensed under the **MIT License**.
