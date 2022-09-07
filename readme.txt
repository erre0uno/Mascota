

primeros comandos:
    dotnet new sln -o MascotaFeliz.App 
dentro de MascotaFeliz.App
    dotnet new classlib -o MascotaFeliz.App.Persistencia
    dotnet new classlib -o MascotaFeliz.App.Dominio    
    dotnet new webapi -o MascotaFeliz.App.Servicios
    dotnet new console -o MascotaFeliz.App.Consola
    dotnet new webapp -o MascotaFeliz.App.Front

dentro de MascotaFeliz.App.Persistencia
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer

Persistencia:
    dotnet build
    dotnet add reference ..\MascotaFeliz.App.Dominio\

MascotaFeliz.App.Consola
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add reference ..\MascotaFeliz.App.Persistencia\
    dotnet build
Persistencia:
    dotnet ef migrations add Inicial --startup-project ../
migrations:    
    dotnet ef migrations add Inicial --startup-project ..\MascotaFeliz.App.Consola\
Aplicar migracion:    
    dotnet ef database update --startup-proyect    

addMigrations:
    dotnet ef migrations add AddEntidades --startup-project ..\MascotaFeliz.App.Consola\ 
aplicarNuevaMigracion:
    dotnet ef database update --startup-project ..\MascotaFeliz.App.Consola\       

add-migration MaxLengthOnNames
update-database  



RAZOR:

add page: dentro  MascotaFeliz.App.Front
dotnet new page -n List -na MascotaFeliz.App.Front.Pages -o .\Pages\Test\


add reference: MascotaFeliz.App.Front add Persistencia
dotnet add reference ..\MascotaFeliz.App.Persistencia\