# Candy Store 

####  _August 4th, 2017_

#### By _**Olena Kuchko**_

## Description
This application uses Asp.NET to demonstrate a basic, relational database using Microsoft SQL Server Management Studio.  
This application allows user/admin to creat, edit, and delete producers and products.

## Specifications
 |Behavior| Input (User Action/Selection)| Output (Program Action)|
 |---|---|---|
 | User is able to view all producers | No Input Required | App displays all "Producers" |
 | User is able to add new producer | "Nestle", "USA", "New partner", "2017" | App adds to databse new producer based on entered information |
 | User is able to edit existing producer | "Nestle Inc" | App adds changes to chosen producer's name ("Nestle Inc") |
 | User is able to view details of producer | Select details section | App displays information about chosen producer |
 | User is able to delete producer | Select delete section and prees delete button | App deletes chosen producer from database |
 | User is able to view all products | No Input Required | App displays all "Products" |
 | User is able to add new product | "Gummy Bears", "small", "Nestle", "10", "http://s3.amazonaws.com/kidzworld_photo/images/2016323/5b89be7a-ff3c-45c6-a065-aec7839c9e97/gummybears-inarow.jpg" | App adds to databse new product based on entered information |
 | User is able to edit existing product | "large" | App adds changes to chosen product's size ("large") |
 | User is able to view details of product | Select details section | App displays information about chosen product |
 | User is able to delete product | Select delete section and prees delete button | App deletes chosen product from database |


## Setup/Installation Requirements

#### _**Replicating/Editing this Project**_

* Clone this repository https://github.com/LenaKuchko/.NetFistWeek.git.
* Using PowerShell navigate to the folder, where you clone project.
* Open project with Microsoft Visual Studio 2015.
* Using terminal, navigate to this folder C:\PATH_WHERE_YOU_CLONE_PROJECT\CandyStore\src\CandyStore>    
* Then run this command: dotnet ef database update Initial  

## Known bugs

  * No Known Bugs

## Technologies Used

 ASP.NET Core, Microsoft Visual Studio 2015, C#, _HTML, CSS,

### License

 MIT

 Copyright (c) 2017 ** Olena Kuchko **
