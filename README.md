#### By _**Zhibin Liang**_  

#### A solution for Pierre's Sweet & Savory Treats to manage treats and flavors

---
## Technologies Used

* C#
* HTML/CSS
* MySQL
* ASP.NET CORE

---
## Description

Pierre's Sweet & Savory Treats has full CRUD behavior for authorized users(anyone signed in), and read only capabilities for anonymous users.

---
## Setup/Installation Requirements

<details>
<summary><strong>To Setup</strong></summary>

* Requires _MySQL_ for the database
* Install _Microsoft .NET SDK_
* Clone the repo
    ```
    $ git clone https://github.com/zbl14/PierreTreats.Solution.git
    ```
</details>

<details>
<summary><strong>To Run</strong></summary>

* Navigate to  
   <pre>PierreTreats.Solution
   ├── <strong>PierreTreats</strong>
   └── PierreTreats.Tests</pre>
* Create ```appsettings.json``` in the directory of _PierreTreats_, and add following to the file with your MySQL username and password
    ```
    {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=zhibin_liang;uid=[username];pwd=[password];"
    }
    }
    ```
* Run follwing commands
    ```
    $ dotnet restore
    ```
    ```
    $ dotnet ef database update
    ```
    ```
    $ dotnet run
    ```
</details>

<details>
<summary><strong>For Testing</strong></summary>

* Navigate to  
    <pre>PierreTreats.Solution
    ├── PierreTreats
    └── <strong>PierreTreats.Tests</strong></pre>

    ```
    $ dotnet restore
    ```
    ```
    $ dotnet test
    ```
</details>
<br/>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* No known bugs, feel free to contact me here if any are found.

## License
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Contact Information
Zhibin Liang <ifthereisoneday@gmail.com>

Copyright &copy; 2022 Zhibin Liang