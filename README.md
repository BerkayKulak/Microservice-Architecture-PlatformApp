
<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project
<img width="100%" src="https://user-images.githubusercontent.com/61355143/154845749-53d1267b-0931-49de-b68f-03f167a285cf.gif">
<img width="100%" src="https://user-images.githubusercontent.com/61355143/154845785-fddd6482-cfbc-4e93-a07c-29adac9fefd2.gif">


Here's why:
Microservice architecture, a single application when developing a modular structure, each one should be considered as a small service, and each service has their own business and communications work, can make very complex and non-an approach that has the mechanisms of addiction to other services. These services are focused on a single job for which they are responsible and have an automated deployment mechanism that can work independently. It should be quite free from centralized management mechanisms. It can be developed in different programming languages and different database technologies can be used.

- Microservices can work on different machines, and all services should be able to communicate with each other on their own. A new service must be developed and deployable without causing changes to other services. Independent Deployment - Services can be deployed separately on any platform, independently of each other.
- Microservices should be deployed in an automated manner, going through the necessary stages (Unit Tests, Integration Tests, Sonarqube, Automation Tests). This mechanism improves the quality of the project.
<img heigth="80%" width="100%" src="https://user-images.githubusercontent.com/61355143/154846308-1b61a55f-114a-4736-ac72-aef3d7e4ab15.gif">

- Each service should be able to be independently developed, tested, deployed. Thus, the quality and flexibility of the application increases.
- Independent Development - The entire microservice can be easily developed according to its functionality.
- The problem with any service does not affect other services, so users will be able to use other services.
- Error Isolation — A problem that will occur on any service of the project, because it will not affect other services of the project, the system will still work.

<img width="100%" src="https://user-images.githubusercontent.com/61355143/154846116-66091745-8aec-4527-ad6e-a9354ca8ee27.png">

- The problem can be eliminated by multiplexing the service under traffic without requiring the entire system to scale the traffic that will occur on any service.
- Scalable - Each component is scalable to its own needs, there is no need to scale all components.
- Each developer should be able to independently develop a service of their own interest, develop a new service on their own, and these services should be deployable without affecting other services.
- When development is performed for a service, the development on that service should not affect the entire project so that other features should still be operational.
- The latest or most suitable technology can be used to meet the requirements. Each service may use a different language or a different database. Each different feature can be realized by a different team using a different technology, regardless of other features.

<img width="100%" src="https://user-images.githubusercontent.com/61355143/154846165-34e2b5d9-34b2-49e3-920a-7f475d726272.jpeg">

- All services should be divided into different microservices according to their area, tasks and characteristics.Technology Diversity - Different languages and technologies can be used when developing different services of the same project.
- These microservices have their own load balancing and application environments to perform their functions, and must also store data in their own databases.
- All microservices must communicate with each other via REST or Message Bus. Both can be used at the same time.
- All functions performed by Microservices must be passable to clients via the API Gateeway. All internal end-points are connected to the API Gateway. Thus, anyone who connects to the API Gateway should be able to connect to the entire system automatically.


## You will find answers to the following questions

- How to develop microservice architecture
- How to establish synchronous and asynchronous communication between microservices
- How to implement OAuth 2.0 and OpenID Connect protocols in Microservice architecture
- How to implement the Eventual Consistency model to ensure consistency in databases belonging to Microservices
- How do we dockerize our microservices
- How to create Docker Compose file
- How to stand up as a container of various databases


### Built With

This section should list any major frameworks/libraries used to bootstrap your project. Leave any add-ons/plugins for the acknowledgements section. Here are a few examples.

* [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2019)
* [MongoDB](https://www.mongodb.com/)
* [Redis](https://redis.io/)
* [PostgreSQL](https://www.postgresql.org/)
* [Web API](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio)
* [MVC](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started)
* [Bootstrap](https://getbootstrap.com/)

### Technologies and Methods

- MongoDB (Database)
- One-To-Many/One-To-One Relation
- RedisDB(Database)
- PostgreSQL(Database)
- Sql Server(Database)
- Domain Driven Design
- CQRS (MediatR Libarary)
- API Gateway - Ocelot Library
- RabbitMQ 
- MassTransit Library
- Generate a token/refreshToken
- Protecting our microservices with Access Token
- Building a structure in accordance with the OAuth 2.0/OpenID Connect protocols
- Docker & Docker Compose
- IdentityServer4
- JWT 



<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started


### Prerequisites

* http://localhost:9000/
  ```sh
  docker pull postgres
  docker pull mongo
  docker pull mcr.microsoft.com/mssql/server
  ```

This is an example of how to list things you need to use the software and how to install them.
* dotnet FreeCourse.Web.csproj
  ```sh
  <PackageReference Include="FluentValidation.AspNetCore" Version="10.3.6" />
  <PackageReference Include="IdentityModel.AspNetCore" Version="3.0.0" />
  <PackageReference Include="Microsoft.IdentityModel.Protocols.OpenIdConnect" Version="6.10.0" />
  <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="5.0.2" />
  ```
  
* dotnet FreeCourse.Gateway.csproj
  ```sh
  <PackageReference Include="IdentityModel" Version="5.1.0" />
  <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="5.0.4" />
  <PackageReference Include="Ocelot" Version="17.0.0" />
  ```
  
* dotnet FreeCourse.IdentityServer.csproj
  ```sh
  <PackageReference Include="IdentityServer4.AspNetIdentity" Version="4.0.0" />
  <PackageReference Include="Microsoft.AspNetCore.Authentication.Google" Version="3.1.5" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="3.1.5" />
  <PackageReference Include="Serilog.AspNetCore" Version="3.2.0" />
  <PackageReference Include="Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore" Version="3.1.5" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="3.1.5" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="3.1.5">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
  </PackageReference>
  <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="3.1.5" />
  <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="3.1.5" />
  ```
* dotnet FreeCourse.Services.Basket.csproj
  ```sh
  <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="5.0.4" />
  <PackageReference Include="StackExchange.Redis" Version="2.2.4" />
  <PackageReference Include="Swashbuckle.AspNetCore" Version="5.6.3" />
  ```  
  
* dotnet Blogesque.Services.csproj
  ```sh
  <PackageReference Include="AutoMapper" Version="11.0.1" />
  <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="11.0.0" />
  <PackageReference Include="Microsoft.AspNetCore.Identity" Version="2.2.0" />
  ```  
  
* dotnet FreeCourse.Services.Catalog.csproj
  ```sh
  <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="8.1.1" />
  <PackageReference Include="MassTransit" Version="7.3.1" />
  <PackageReference Include="MassTransit.AspNetCore" Version="7.3.1" />
  <PackageReference Include="MassTransit.RabbitMQ" Version="7.3.1" />
  <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="5.0.4" />
  <PackageReference Include="MongoDB.Driver" Version="2.12.1" />
  <PackageReference Include="Swashbuckle.AspNetCore" Version="5.6.3" />
  ```  
* dotnet FreeCourse.Services.Discount.csproj
  ```sh
  <PackageReference Include="Dapper.Contrib" Version="2.0.78" />
  <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="5.0.4" />
  <PackageReference Include="Npgsql" Version="5.0.4" />
  <PackageReference Include="Swashbuckle.AspNetCore" Version="5.6.3" />
  ```

* dotnet FreeCourse.Services.FakePayment.csproj
  ```sh
  <PackageReference Include="MassTransit" Version="7.3.1" />
  <PackageReference Include="MassTransit.AspNetCore" Version="7.3.1" />
  <PackageReference Include="MassTransit.RabbitMQ" Version="7.3.1" />
  <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="5.0.4" />
  <PackageReference Include="Swashbuckle.AspNetCore" Version="5.6.3" />
  ```
  
* dotnet FreeCourse.Services.Order.API.csproj
  ```sh
  <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="5.0.4" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="5.0.4">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
  </PackageReference>
  <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="5.0.4">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
  </PackageReference>
  <PackageReference Include="Swashbuckle.AspNetCore" Version="5.6.3" />
  ```
  
* dotnet FreeCourse.Services.Order.API.csproj
  ```sh
  <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="5.0.4" />
  <PackageReference Include="Swashbuckle.AspNetCore" Version="5.6.3" />
  ```


### Installation

_Below is an example of how you can instruct your audience on installing and setting up your app. This template doesn't rely on any external dependencies or services._

### Installation Requirements

- https://dbeaver.com/
- https://www.docker.com/products/docker-desktop


1. Clone the repo
   ```sh
   https://github.com/BerkayKulak/Microservice-Architecture-PlatformApp.git
   ```
2. Update Nuget packages
   ```sh
   dotnet tool update <PACKAGE_ID> -g|--global
   ```
3. Install Identity Server
   ```js
   dotnet new -i identityserver4.templates
   ```
4. Directory File 
   ```js
   cd ..\IdentityServer\FreeCourse.IdentityServer
   dotnet new is4aspid --name [NAME]
   ```

<p align="right">(<a href="#top">back to top</a>)</p>


## Ports

To clone and run this application, you'll need [Git](https://git-scm.com) and [Node.js](https://nodejs.org/en/download/) (which comes with [npm](http://npmjs.com)) installed on your computer. From your command line:

```bash
Services
	-calalogAPI => http://localhost:5011 => (http://localhost:5011/swagger/index.html)
	-photostockAPI => http://localhost:5012
	-basket => http://localhost:5013
	-discount => http://localhost:5014
	-order => http://localhost:5015
	-fakeypayment => http://localhost:5016

	
identityServer => http://localhost:5001
gateway => http://localhost:5000
Web => http://localhost:5010

```

<!-- USAGE EXAMPLES -->
## Usage

To clone and run this application, you'll need [Git](https://git-scm.com) and [Node.js](https://nodejs.org/en/download/) (which comes with [npm](http://npmjs.com)) installed on your computer. From your command line:

```bash
# Go into the Solution Explorer
$ cd \Microservice-Architecture-PlatformApp
$ Properties => Multiple Startup Projects and all projects must be selected.

# Run the app
$ dotnet run
$ dotnet run --project ./projects/proj1/proj1.csproj

```

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ROADMAP -->
## Bug / Feature Request

If you find a bug (the website couldn't handle the query and / or gave undesired results), kindly open an issue [here](https://github.com/BerkayKulak/Blogesque/issues/new) by including your search query and the expected result.

If you'd like to request a new function, feel free to do so by opening an issue [here](https://github.com/BerkayKulak/Blogesque/issues/new). Please include sample queries and their corresponding results.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Berkay Kulak - (https://www.linkedin.com/in/berkay-kulak-3442311b1/) - kulakberkay15@gmail.com

Project Link:   (https://github.com/BerkayKulak/Blogesque)

<p align="right">(<a href="#top">back to top</a>)</p>
