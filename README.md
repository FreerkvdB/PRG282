# PRG282 Project  
### Superhero Management System

## Overview  
This project was developed for the **PRG282** module as a Windows Forms application using **C#** and **ADO.NET**.  
It demonstrates practical implementation of **three-tier architecture** — Data Layer, Business Logic Layer, and Presentation Layer — to manage superhero trainee records for the fictional **One Kick Heroes Academy**.

The system allows users to add, update, delete, and view superhero trainee data, generate summary reports, and handle file-based data persistence.

---

## Features  
- **Add New Superhero Trainees** — Capture and store hero details such as name, abilities, and power level.  
- **View Records** — Display all stored heroes in a grid view.  
- **Update and Delete** — Modify or remove existing records.  
- **Summary Report Generation** — Create automated performance or ranking summaries.  
- **File-Based Storage** — Data stored locally using text files for simplicity.  
- **Layered Architecture** — Promotes maintainability, scalability, and clear separation of responsibilities.

---

## Architecture  
The application follows a **three-layer architecture**:

1. **Data Layer**  
   - Handles all file and database operations.  
   - Responsible for reading and writing superhero data.

2. **Business Logic Layer (BLL)**  
   - Contains business rules, validation, and calculations such as ranking and performance summaries.


---

## Technologies Used  
- **Language:** C# (.NET Framework / .NET 6+)  
- **IDE:** Visual Studio  
- **Frameworks:** Windows Forms, ADO.NET  
- **Data Handling:** Text File / StreamReader & StreamWriter  
- **Version Control:** Git & GitHub  

---


---

## Future Enhancements  
- Transition from file storage to a **SQL Server** database.  
- Implement **user authentication** and role-based access.  
- Add **search and filtering** functionality.  
- Introduce **export options** (PDF, CSV).  
- Enhance **UI design** using modern frameworks like WPF or .NET MAUI.

---

## Author  
**Freerk van den Bos - 602074**  
PRG282 Module – Belgium Campus ITversity  
2025  

---
## Contributors
**Stephen van der Merwe - 601789** 

**Zander De Groot - 602789**

---
## License  
This project is for **educational purposes only**.  
Feel free to fork and adapt it with proper attribution.

