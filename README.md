# _Weight List_

#### _Last Updated: 28 May 2020_

#### By _**Zakkrey Short**_

## Description

_Api to store information about weightlifting equipment to be used with applicaiton later on._

## Specifications: 

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
|  | | |
## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository
* ``cd WeightliftingList``

_Confirm that you have navigated to the PierresSweetTreats directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd WeightliftingList``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet ef migrations add Initial``
* ``dotnet ef database update``
* ``dotnet run`` or ``dotnet watch run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Errors & Bugs
* _Currently N/A._

## Technologies Used
* _Git_
* _C#_
* _ASP.NET Core MVC 2.2_
* _dotnet script_
* _MySQL_
* _MySQL Workbench_
* _Entity Framework Core_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Zakkrey Short_**