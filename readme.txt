

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
dotnet new page -n Detalles -na MascotaFeliz.App.Front.Pages -o .\Pages\Test\
dotnet new page -n Eliminar -na MascotaFeliz.App.Front.Pages -o .\Pages\Test\

add reference: MascotaFeliz.App.Front add Persistencia
dotnet add reference ..\MascotaFeliz.App.Persistencia\


<form>
    <div class="form-group">
        <label class="form-label" for="exampleInputText1">Nombres </label>
        <input type="text" class="form-control" id="exampleInputText1" value="Mark Jhon" placeholder="Enter Name">
    </div>
    
    <div class="form-group">
        <label class="form-label" for="exampleInputText1">Apellidos </label>
        <input type="text" class="form-control" id="exampleInputText1" value="Mark Jhon" placeholder="Enter Name">
    </div>

    <div class="form-group">
        <label class="form-label" for="exampleInputText1">Direccion </label>
        <input type="text" class="form-control" id="exampleInputText1" value="Mark Jhon" placeholder="Enter Name">
    </div>

    <div class="form-group">
        <label class="form-label" for="exampleInputEmail3">Correo</label>
        <input type="email" class="form-control" id="exampleInputEmail3" value="markjhon@gmail.com"
            placeholder="Enter Email">
    </div>

    <div class="form-group">
        <label class="form-label" for="exampleInputNumber1">Tarjeta</label>
        <input type="number" class="form-control" id="exampleInputNumber1" value="2356">
    </div>

    <div class="form-group">
        <label class="form-label" for="exampleInputdate">Date Input</label>
        <input type="date" class="form-control" id="exampleInputdate" value="2019-12-18">
    </div>

    <div class="form-group">
        <label class="form-label" for="exampleInputtime">Time Input</label>
        <input type="time" class="form-control" id="exampleInputtime" value="13:45">
    </div>

    <div class="form-group">
        <label class="form-label" for="exampleInputdatetime">Date and Time Input</label>
        <input type="datetime-local" class="form-control" id="exampleInputdatetime" value="2019-12-19T13:45:00">
    </div>
    <div class="form-group">
        <label class="form-label" for="exampleFormControlTextarea1">Recomendaciones </label>
        <textarea class="form-control" id="exampleFormControlTextarea1" rows="5"></textarea>
    </div>
    
    <button type="submit" class="btn btn-primary">Submit</button>
    <button type="submit" class="btn btn-danger">cancel</button>
</form>