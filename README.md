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

* You will need Microsoft Visual Studio 2015 in order to replicate or edit this project using these instructions.
* Click the "download or clone" button in this repository https://github.com/LenaKuchko/.NetFistWeek.git.
* In your computers terminal, navigate to the desktop and enter "git clone" followed by pasting the link on your clipboard.
* Open up Microsoft Visual Studio 2015 and select File> Open> Project/Solution.
* Navigate to your desktop and double click on your project folder.
* Then double click on the "Microsoft Visual Studio Solution" type item (it will share the same name as the project as well as a VS icon).
* One the file has been opened by Visual Studio, bring back your command prompt and navigate to the root path of this project.
* If using PowerShell, your path to navigate will look something like this: 

         C:\Users\epicodus\documents\Visual Studio 2015\projects\CandyStore\src\CandyStore>
      
* Once you're in the project, run this command:

         dotnet ef database update Initial
      
* The command above will create the database required for this project using the class information in the "Models" folder.
* Viewing and editing all CRUD (create, read, update, delete) functionality can be done in the "Controllers" folder.
* Viewing and editing all styling and images can be found in the "CSS" and "IMG" folders located within the "wwwroot" folder.
* Classes for objects and the one to many relationship used in this project can be found in the "Models" folder.
* All HTML is located in the Views folder and each separate subfolder in it.

## Known bugs

  * No Known Bugs

## Support and contact details

 Contact kuchkoel@gmail.com with any comments, concerns, or questions.

## Technologies Used

 ASP.NET Core, Microsoft Visual Studio 2015, C#_, _HTML, CSS,

### License

 MIT

 Copyright (c) 2017 ** Olena Kuchko **