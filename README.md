# _Sillystringz's Factory_

#### By _Jake Maier_

#### _A C# web application using Entity Framework Core to maintain a database for a factory._

## Technologies Used

* _C#_
* _.NET_
* _Entity Framework Core_
* _MySql_

## Description

_This is site built for the user to manage their machines and employees who are able to maintain those machines while storing all information from the user in a database._

## Setup/Installation Requirements

* _Clone this repo._
* _Open the terminal and navigate to this project's production directory called "Factory.Solution"._
* _Within the production directory "Factory", create a new file called `appsettings.json`._
* _Within appsettings.json, put in the following code._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* _Within the production directory "Factory", run `dotnet watch run` in the command line to start the project in development mode with a watcher._

* _Open the browser to https://localhost:5001._


## Known Bugs

* _N/A_

## License

_MIT License_

Copyright (c) _2023_ _authored by: Jake Maier_
