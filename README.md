# _Sillystringz's Factory_

#### By _Jake Maier_

#### _A C# web application using Entity Framework Core to maintain a database for a factory_

## Technologies Used

* _C#_
* _.NET_
* _Entity Framework Core_
* _HTML_
* _GIT_

## Description

_This is site built for the user to manage their machines and engineers licensed properly to service the machines...._

## Setup/Installation Requirements

* Clone this repo.
* Open the terminal and navigate to this project's production directory called "Factory.Solution".
* Within the production directory "Factory", create a new file called `appsettings.json`.
* Within appsettings.json, put in the following code.
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* Within the production directory "Factory", run `dotnet watch run` in the command line to start the project in development mode with a watcher.

* Open the browser to https://localhost:5001.


## Known Bugs

* _Currently adding machine to engineers and engineers to students not working._

## License

_MIT License_

Copyright (c) _2023_ _authored by: Jake Maier_
