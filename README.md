
# Restaurant
*This project acts as a universal backend for lab work in this repository.*

Restaurant is a simple web API that was developed as part of a university program which can be used as a foundation for online ordering system. The project was developed using three-layer architecture and REST API principles on ASP.NET Core Web API 7.

## Technologies:
| **Category** |       **Name**        | **Version** |
|--------------|-----------------------|-------------|
| Platform     | .NET                  | 7           | 
| Language     | C#                    | 11          |
| DBMS         | MySQL                 | 8.0.36      |
| ORM          | Entity Framework Core | 7.0.16      |
| API docs     | Swagger               | 7.0.16      |
| Logger       | Serilog               | 8.0.1       |
| Mapper       | AutoMapper            | 13.0.0      |

## Versioning:
URL versioning has been implemented and currently there are 2 versions. First version for [lab2](https://github.com/Tripli33/dotnet_labs/tree/lab2) and [lab 4](https://github.com/Tripli33/dotnet_labs/tree/lab4), second version - [lab3](https://github.com/Tripli33/dotnet_labs/tree/lab3).
Versions can be changed via Swagger page or by providing version number in the URL.

## Authentication:
Authentication has been added for version 2 endpoints.
Non auth endpoints require JWT token to be provided otherwise 401 response will be returned. You can disable authentication for endpoints by removing ```Authorize``` attribute from the particular controller

## Logging:
Currently logs are being added to file and console. You can change or find the settings in *serilog.config.json*.

## Setup:
- Clone this repo: ```git clone https://github.com/Tripli33/dotnet_labs.git```
- Cd into the folder: ```cd dotnet_labs```
- Switch branch to api: ```git checkout api```
- Run docker-compose: ```docker-compose up -d --build```
- Open a web browser: http://localhost:8888/swagger/index.html
