#CustomerAPI: SqlServer

	Microsoft.EntityFrameworkCore.Design
	Microsoft.EntityFrameworkCore.SqlServer
	Microsoft.EntityFrameworkCore.Tools

#ProductAPI: MySQL

	MySql.EntityFrameworkCore

#OrderAPI: MongoDB

	MongoDb.Driver

#GatewayApi: Ocelot

#JwtAuthManager

	Microsoft.IdentityModel.Tokens
	System.IdentityModel.Tokens.Jwt
	Microsoft.AspNetCore.Authentication.JwtBearer

#to add DI

	Microsoft.Extensions.DependencyInjection.Abstractions


#RabbitMQ

#AzureDevops

#Repositories

#UoW

#CQRS

#XUnit

#DDD

#Redis

#GRPC





#𝗧𝗼𝗽 𝟭𝟬 𝗔𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗮𝗹 𝗣𝗮𝘁𝘁𝗲𝗿𝗻𝘀

𝗦𝗼𝗳𝘁𝘄𝗮𝗿𝗲 𝗮𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲 is the process of designing the structure and behavior of a software system,which includes making decisions about components,
modules, interfaces, and the organization of the system.

𝗦𝗼𝗳𝘁𝘄𝗮𝗿𝗲 𝗮𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲 𝗽𝗮𝘁𝘁𝗲𝗿𝗻𝘀 are important because they provide reusable solutions to common problems in software design.
They capture best practices and proven solutions for designing software systems that are reliable, scalable, maintainable, and extensible.

There are many software architecture design patterns to know, but some of the most important ones are:

𝟭. 𝗟𝗮𝘆𝗲𝗿𝗲𝗱 𝗔𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲: This pattern is based on dividing the application into logical layers,
where each layer has a specific responsibility and interacts with the layers above and below it.

𝟮. 𝗠𝗶𝗰𝗿𝗼𝘀𝗲𝗿𝘃𝗶𝗰𝗲𝘀 𝗔𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲: This pattern is based on decomposing the application into small, 
independent services that communicate with each other through well-defined APIs.

𝟯. 𝗘𝘃𝗲𝗻𝘁-𝗗𝗿𝗶𝘃𝗲𝗻 𝗔𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲: This pattern is based on using events to communicate between different
components or services, where events trigger actions or reactions in the system.

𝟰. 𝗦𝗽𝗮𝗰𝗲-𝗯𝗮𝘀𝗲𝗱 𝗮𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲 (𝗦𝗕𝗔): is a method of designing software that centers the system's structure
around the idea of "spaces," which are independent and autonomous units.

𝟱. 𝗠𝗶𝗰𝗿𝗼𝗸𝗲𝗿𝗻𝗲𝗹 𝗮𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲: this is an approach where the kernel provides minimal functionality 
and services are implemented as separate modules outside of the kernel.

𝟲. 𝗣𝗲𝗲𝗿 𝘁𝗼 𝗣𝗲𝗲𝗿 𝗮𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗮𝗹 𝗽𝗮𝘁𝘁𝗲𝗿𝗻: this is a decentralized model where nodes in a network can act as 
both clients and servers, allowing for distributed sharing of resources and information without the need for a central authority.

𝟳. 𝗖𝗹𝗼𝘂𝗱 𝗻𝗮𝘁𝗶𝘃𝗲 𝘀𝗼𝗳𝘁𝘄𝗮𝗿𝗲 𝗮𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲: this is a pattern where applications are developed and deployed to run on cloud platforms,
leveraging cloud services and infrastructure for scalability, reliability, and agility.

𝟴. 𝗖𝗤𝗥𝗦 (𝗖𝗼𝗺𝗺𝗮𝗻𝗱 𝗤𝘂𝗲𝗿𝘆 𝗥𝗲𝘀𝗽𝗼𝗻𝘀𝗶𝗯𝗶𝗹𝗶𝘁𝘆 𝗦𝗲𝗴𝗿𝗲𝗴𝗮𝘁𝗶𝗼𝗻): This pattern separates the command and query responsibilities 
of an application's model, making it easier to scale and optimize the application.

𝟵. 𝗛𝗲𝘅𝗮𝗴𝗼𝗻𝗮𝗹 𝗔𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲: This pattern is based on separating the application into an inner and outer layer,

where the inner layer contains the business logic and the outer layer contains the interfaces with the outside world.

𝟭𝟬. 𝗖𝗹𝗲𝗮𝗻 𝗔𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲: This pattern emphasizes the separation of concerns and decoupling of components, making it easier to maintain and change an application over time.

