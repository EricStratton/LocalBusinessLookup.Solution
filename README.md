## Local Business API & Client -- Repository containing both a .NET Web API and corresponding .NET MVC serving as the Client

### _Webpage to manage local businesses including local shops and local restaurants. API is accessible through Client-side program or alternatively through the SwaggerUI_

### _Created by: Eric Stratton_

## Description

Use this webpage to manage both local shops and local restaurants. Properties include: business name, street address, and their primary business operation.

**_Authentication:_** 

**_At this time, authentication has not been implemented on this program._**

## Setup/Instillation

### Requirements:

- Internet browser
- Code editor if you wish to view/edit the code (recommended)
- .NET Core SDK
- MySQL 

### .NET Core:

- Application is built using the deprecated .NET Core vs 2.2.
- .NET Core is a requirement for running this application, if you need to install it visit <https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer>
- Or if you wish to downloaded the latest editions of .Net Core, select `.NET core` in the file path at the top of the dowloaded page provided in the link above

### MySQL:

- Application utilizes a database created using MySQL
- Download from MySQL Community Server <https://dev.mysql.com/downloads/file/?id=484914>
- Either make an account or select `No thanks, just start my dowload`
- Follow install instructions and configure to your specifications
- Recommend including _MySQL Workbench_ in install
- Check if properly installed by running command `mysql -uroot -p<password>` in terminal

### Download: 

- Download this repository by clicking the green 'Code' icon and selecting download zip
- Use your favorite zip.file opener to extract files to your local device
- Follow install window and select configuration of your choice

### Terminal:

- Open command terminal on local device
- Navigate to desktop in terminal using `$ cd desktop`
- Copy repository link by clicking on green 'Code' icon and clicking the clipboard to the right of the url
- Use command `$ git clone https://github.com/EricStratton/LocalBusinessLookup.Solution`
- From desktop, run command `$ cd LocalBusinessLookup.Solution` to navigate to the installed directory
- Run command `$ code .` to open directory in default code editor
- Run command `dotnet restore LocalBusinessApi` in the console to install necessary .NET Core files for API 
- Run command `dotnet restore LocalBusinessClient` in console to install .NET Core packages for Client program
**_API Program_**
- Run command `$ cd LocalBusinessApi` to navigate into the program directory to run console app
- Run command `$ donet run` 
- If everything has gone correctly, the web application should run in the web browser at `localhost:5000`
**_Client Program_**
- Open second terminal while keeping the API program running
- Run command `$ cd LocalBusinessClient` to navigate into the program directory to run console app
- Run command `$ donet run` 
- If everything has gone correctly, the web application should run in the web browser at `localhost:5004`

**_Important:_**

**_If you want to access the Client user interface you will need to keep both the Client and API programs running simultaneously. Alternatively, you can view and access the API endpoints through Swagger._**

### Client:
- All CRUD operations are available through the Client-side program
- Navigation within the program follows the RESTful protocal
- `View Random` at the top of both the Shops and Restaurants index page will display the details of a shop or restaurant at random from the list of current entries

### Swagger:

- Swagger provides custom documentation on an API's endpoints
- To view documentation on this API, follow the steps above under the heading `Terminal:` until the end of **_API Program_** section
- This will insure that your are running the API program
- In your preferred internet browser, enter the url: http://localhost:5000/swagger/v1/swagger.json to view raw documentation
- Enter http://localhost:5000/swagger/index.html to access the Swagger UI where you will be able to take advantage of full CRUD operations without running the Client-side program

**_Swagger is supported using the Swashbuckle package reference_**

### Import Database using Entity Framework Core

- This program contains seeded data
- Navigate to `LocalBusinessApi` directory in your terminal
- Run command `dotnet ef database update` to generate database based on provided structure
- If you make changes and want to update database run command `dotnet ef migrations add Initial`

### Navigating in Application:

- App opens on landing page at `localhost:5004/` if Client-side program is running
- See Swagger section above if you wish to access API endpoints without running Client-side program
- Click on one of the hyperlinks to navigate to a different section of app

### RESTful Protocol:

- **_Page routes are named using RESTful notation as reflected in the pathway urls_**
- `localhost:5004/`: landing page
- `localhost:5004/Shops`: homepage for shop profiles, displays all existing shop profiles
- `localhost:5004/Shops/Details/{ShopId}`: page for displaying a specific shop profile
- `localhost:5004/Shops/Edit/{ShopId}`: page for editing select shop profile
- `localhost:5004/Restaurants`: homepage for restaurant profiles, displays all existing restaurant profiles
- `localhost:5004/Restaurants/Details/{RestaurantId}`: page for displaying a specific restaurant profile
- `localhost:5004/Restaurants/Edit/{RestaurantId}`: page for editing select restaurant profile

## Known Bugs/Issues

There are no known bugs at this time.

## Support & Contact Details

Do not hesitate to contact me at:

<strattonericj@gmail.com>

## Technologies 

- _VisualStudio Code_
- _C#_
- _.NET Core 2.2_
- _Entity_
- _MySQL_
- _MySQL Workbench_
- _RestSharp_
- _Newtonsoft.Json_
- _Swagger_
- _Swashbuckle_
- _Git_
- _GitHub_

## Licensing

Copyright (c) 2020 **_Eric Stratton_**

This software is licensed under the MIT license