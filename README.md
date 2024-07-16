# SchoolManagementApp

## Overview

This project is a Windows Forms Application designed to manage basic school systems, including controlling students, specialties, and grades. It provides options to create, edit, and delete each entity. The IDE used is Visual Studio with the technology .NET 4.7.2, and the programming language used is C#. For the database context is used SQL language directly in the project. This repository contains the source code and resources required to deploy and run the application.

## Directory Structure

The project is structured as follows:

SchoolManagementApp/
├── .vs/
├── bin/
├── obj/
├── Properties/
│ ├── AssemblyInfo.cs
│ ├── Resources.Designer.cs
│ ├── Resources.resx
│ ├── Settings.Designer.cs
│ └── Settings.settings
├── App.config
├── Configurator.cs
├── DBManipulator.cs
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── FormEditGrade.cs
├── FormEditGrade.Designer.cs
├── FormEditGrade.resx
├── FormEditSpecialty.cs
├── FormEditSpecialty.Designer.cs
├── FormEditSpecialty.resx
├── FormEditStudent.cs
├── FormEditStudent.Designer.cs
├── FormEditStudent.resx
├── FormEditSubject.cs
├── FormEditSubject.Designer.cs
├── FormEditSubject.resx
├── FormGrade.cs
├── FormGrade.Designer.cs
├── FormGrade.resx
├── FormSpecialty.cs
├── FormSpecialty.Designer.cs
├── FormSpecialty.resx
├── FormStudent.cs
├── FormStudent.Designer.cs
├── FormStudent.resx
├── FormSubject.cs
├── FormSubject.Designer.cs
├── FormSubject.resx
├── FormViewGrades.cs
├── FormViewGrades.Designer.cs
├── FormViewGrades.resx
├── FormViewSpecialties.cs
├── FormViewSpecialties.Designer.cs
├── FormViewSpecialties.resx
├── FormViewStudents.cs
├── FormViewStudents.Designer.cs
├── FormViewStudents.resx
├── FormViewSubjects.cs
├── FormViewSubjects.Designer.cs
├── FormViewSubjects.resx
├── ProjectWFA.sln
└── README.md


## Key Directories and Files

- **Properties**: Contains project properties and settings.
- **Form1.cs**: Main form of the application.
- **FormEditGrade.cs**: Form for editing grades.
- **FormEditSpecialty.cs**: Form for editing specialties.
- **FormEditStudent.cs**: Form for editing students.
- **FormEditSubject.cs**: Form for editing subjects.
- **FormGrade.cs**: Form for managing grades.
- **FormSpecialty.cs**: Form for managing specialties.
- **FormStudent.cs**: Form for managing students.
- **FormSubject.cs**: Form for managing subjects.
- **FormViewGrades.cs**: Form for viewing grades.
- **FormViewSpecialties.cs**: Form for viewing specialties.
- **FormViewStudents.cs**: Form for viewing students.
- **FormViewSubjects.cs**: Form for viewing subjects.

## Prerequisites

## Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (version 4.7.2 or later)
- [Visual Studio](https://visualstudio.microsoft.com/) (with [Windows Forms components](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-winforms?view=vs-2022) installed)


## Setup and Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/siyana-m/SchoolManagementApp.git
    cd SchoolManagementApp
    ```

2. Open the solution in Visual Studio:
    - Open `ProjectWFA.sln` in Visual Studio.

3. Build the project:
    - Go to `Build` > `Build Solution` or press `Ctrl+Shift+B`.

4. Run the application:
    - Press `F5` or go to `Debug` > `Start Debugging`.


## Database Setup

1. **Create a new database in SQL Server Management Studio (SSMS):**
    - Open SSMS and connect to your SQL Server instance.
    - Right-click on the `Databases` folder and select `New Database`.
    - Name the database `SchoolManagementDB` and click `OK`.

2. **Run the provided SQL script:**
    - Open a new query window in SSMS.
    - Copy the contents of the `Solution Items/schoolmanagement_db.txt` file into the query window.
    - Execute the script to create the necessary tables, triggers, and seed data.

3. **Update the connection string:**
    - Open the `appsettings.json` file in the `RepairPlatform.Web` project.
    - Update the `ConnectionStrings` section with your SQL Server connection details:

    If you log into SSMS with a username and password:
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=SchoolManagementDB;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;"
    }
    ```

    If you log into SSMS directly with the server (Windows Authentication):
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=SchoolManagementDB;Trusted_Connection=True;"
    }
    ```


## Running Tests

To run any tests for the application (if applicable), use Visual Studio's built-in testing tools.

## Contributing

Contributions are welcome! Please create an issue or submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Contact

For any questions or feedback, please contact siskataam32@gmail.com.

## Notes

The project is still under development. There may be issues. In case of finding one, please contact siskataam32@gmail.com.
