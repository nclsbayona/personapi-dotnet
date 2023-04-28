# personapi-dotnet
Person API Made in Dotnet - Laboratorio de Arquitectura de software

## Implementación de aplicación web monolitica usando .NET MVC
### Descripción
El presente laboratorio tenía como objetivo construir un CRUD para:
![image](https://user-images.githubusercontent.com/59931437/235251847-ebd40f41-fcd0-479e-8f26-565ea7c56f87.png)
Es importante mencionar que la aplicación es monolitica en su gran mayoría, pues los diferentes componentes de la aplicación se encuentran en el mismo binario (Salvo la base de datos).

### Tecnologias usadas
- .NET MVC
- MS SQL Server
- SQL Server Management Studio
- REST
- Swagger

### Procedimiento
1. crear el repositorio git publico en github o en cualquier sistema git nombre del repositorio debe ser personapi-dotnet
2. instalar SQL Server 2019 Express modo Basico
3. instalar SQL Server Management Studio 18
4. crear la base de datos llamada persona_db y darle la propiedad al usuario sa
5. crear las tablas segun el modelo
6. instalar Visual Studio Community 2022 con los complementos
  1. Desarrollo ASP.NET y web
  2. Almacenamiento y procesamiento de datos
  3. Plantillas de proyecto y elementos de .Net Framework 
  4. Caracteristicas avanzadas de ASP.NET
7. clonar el repositorio local git a partir del remoto creado previamente
8. en Visual Studio Community 2022
  8.1. crear un proyecto 
  8.2. seleccionar la plantilla Aplicacion web de ASP.NET Core (Modelo-Vista-Controlador)
  8.3. el nombre de la aplicacion debe ser el mismo del repo personapi-dotnet
  8.4. Framework .NET 6.0 sin autenticacion y sin configuracion HTTPS
  8.5. en el menu Ver activar la vista de Explorador de objetos de SQL Server
  8.6. agregar y probar la conexión de tipo local express
  8.7. ir al menu Herramientas>Administrador de paquetes NuGet>Consola del Administrador de paquetes
  8.8. En el explorador de soluciones, hacer clic derecho en dependencias e ir a Administrar paquetes NuGet e instalar
    8.8.1. Microsoft.EntityFrameworkCore
    8.8.2. Microsoft.EntityFrameworkCore.SqlServer
    8.8.3. Microsoft.EntityFrameworkCore.Tools
  8.9. crear entidades, en el explorador de soluciones, en la carpeta Models hacer clic derecho y en agregar agregar una carpeta llamada Entities
  8.10. en la Consola del Administrador de paquetes escribir 
    8.10.1. Scaffold-DbContext "Server=localhost\SQLEXPRESS;Database=persona_db;Trusted_Connection=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/Entities
    8.10.2. se crean las clases entidad a partir de las tablas existentes de la base de datos y el contexto
    8.10.3. agragar la cadena de coneccion en appsettings.jason
  8.11. crear interfaces
  8.12. crear repositorios
  8.13. crear controladores 
  8.14. desplegar 
 9. hacer push al repositorio
10. crear TAG

### Configuración
Para ejecutar el proyecto es importante tener la versión 7 de .NET y usar los scripts [ddl](https://github.com/nclsbayona/personapi-dotnet/blob/master/ddl.sql) y [dml](https://github.com/nclsbayona/personapi-dotnet/blob/master/dml.sql) para agregar datos a la base de datos
