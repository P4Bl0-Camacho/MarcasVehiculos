# Relaciones entre entidades: Marca - Vehículo

## Tema asignado
Grupo 6: Marca (entidad principal) y Vehículo (entidad dependiente), con
una relación uno a muchos: una marca tiene muchos vehículos y cada
vehículo pertenece a una sola marca.

## Integrante y aportes
| Integrante | Aporte |
|---|---|
| [Pablo Guber Camacho Bravo] | Desarrollo completo: entidades, validaciones, migraciones, relación, componente autónomo, documentación y video |

Actividad realizada de forma individual.

## Tecnologías
- ASP.NET Core MVC (.NET 10)
- Entity Framework Core
- SQL Server Express

## Pasos para ejecutar el proyecto
1. Clonar el repositorio.
2. Abrir la solución en Visual Studio.
3. Verificar la cadena de conexión `DefaultConnection` en `appsettings.json`
   (por defecto apunta a `localhost\SQLEXPRESS`).
4. En la Consola del Administrador de paquetes, ejecutar `Update-Database`.
5. Ejecutar el proyecto con F5.
6. Crear primero marcas en el menú *Marca* y luego vehículos en *Vehículo*.

## Migraciones
1. `InitialCreate`: creación inicial de la tabla Vehiculos.
2. `ValidacionesVehiculo`: DataAnnotations en Vehiculo.
3. `AgregarMarca`: tabla Marcas y clave foránea MarcaId.

## Componente autónomo
Se reemplazó el campo numérico de la clave foránea por una lista
desplegable que muestra el nombre de la marca, se eliminó el campo
duplicado de la propiedad de navegación y se muestra el nombre de la
marca en Index y Details de Vehiculos.