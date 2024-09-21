# Calc App

> This is my first personal project, I tried to use part of all my learning acquired in my first month programming with C#.
The project consists in a simple calculator application built using C#. The application allows users to perform basic arithmetic operations and displays the result of the expression entered. It also includes a history feature, where users can view their past calculations and clear the history if needed.

The goal of this project is to demonstrate basic concepts of C#, including object-oriented programming, handling user input, enum and using basic data structures like lists.

## 🚀 Technologies

This project was developed using the following technologies:
* C# 12
* .NET 8 SDK
* Visual Studio
* GIT
* GitHub

## 💻 Installing Calc App

1. clone de respository:
   ```
   git clone https://github.com/Bruno-Regis/CalcApp.git
   ```
2. Navigate tho the directory:
  ```
   cd CalcApp
  ```
4. Open the project in your favorite IDE
  
6. Restore dependencies if needed:
   ```
    dotnet restore
7. run the project
   ````
   dotnet run
## ☕ Using Calc App

After running the project you'll be able to interact with a console window, a friendly interface will appear asking to enter simple mathematical expressions such as:

```
10 * (30+5)
```
```
Result: 350
keep calculating? (1) Yes (2) Show History (3) Clear History (4) Quit
```
Show History method will return all previous operations, for example:
```
Showing history
10 * (30 + 5)=350

30/2.5=12

30/7=4,285714285714286
```
## 🗺️ Roadmap
The following improvements are planned for future versions of the calculator:

 * Implement support for more advanced mathematical operations like sin, cosin and even calculation of simple and compund interest
 * Add a graphical user interface in web.
 * Export operation history to a specific file or a database.
