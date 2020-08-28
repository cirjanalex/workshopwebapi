PART I

.Net core SDK
https://dotnet.microsoft.com/download/dotnet-core
Version 3.1
https://dotnet.microsoft.com/download/dotnet-core/3.1

General Documentation : https://docs.microsoft.com/en-us/aspnet/core/fundamentals
Routing: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-3.1
Swagger: https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio


Homework :

Entities :
User 
 - Id
 - Nume
 - BirthDate
 - Roles ( List of Role )

Role
 - Id
 - Tip ( Admin, User )



Requirements : 
1. CRUD on User entity ( Create/Read/Update/Delete) functionality
 - I should be able to create an user
 - I should be able to retrieve all the users
 - I should be able to update an user
 - I should be able to delete an user
Filtering
 - Filter by birthdate using interval ( all the people born between dateStart and dateEnd ) ( example: /users?startDate=1980-03-30&endDate=1980-05-30 )
 - Filter by role ( example: /users?role=admin ) 

2. Actions on User Roles ( /users/5/roles )

 - I should be able to add a role to a user
 - I should be able to retrieve all the roles of an user
 - I should be able to delete a role for an user

3. Swagger

4. Unit testing (Nice to have)


Part II

Options
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-3.1
Logging
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/?view=aspnetcore-3.1
Authentication
https://www.c-sharpcorner.com/article/jwt-json-web-token-authentication-in-asp-net-core/

Homework:

=> Implement Authorization
- Create a Profile controller for updating user info -> as user (Birthdate and Name), PATCH /profiles/<userid>, payload is either Name or Birthday, + GET
- Change Users controller to authorize only admins
- Login Controller -> anonymous

Log token generation
Validate input data

