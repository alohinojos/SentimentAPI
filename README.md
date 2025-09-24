■ SentimentAPI

API RESTful desarrollada en ASP.NET Core para análisis de sentimiento de comentarios de usuarios.

Los resultados se almacenan en SQL Server y la aplicación puede ejecutarse directamente 

■ Instalación

git clone https://github.com/alohinojos/SentimentAPI.git

cd SentimentAPI

■■ Configuración

{
 "ConnectionStrings": {
 
 "DefaultConnection": "Server=localhost;Database=SentimentDB;User Id=sa;Password=TuContraseñaSegura123;"
 
 },
 
 "Logging": {
 
 "LogLevel": {
 
 "Default": "Information",
 
 "Microsoft.AspNetCore": "Warning"
 
 }
 },
 "AllowedHosts": "*"
}
■■ Si usas Docker para SQL Server, cambia `Server=localhost` por `Server=sqlserver`.

■■ Uso
Ejecución sin Docker:
dotnet ef database update
dotnet run
La API estará en: http://localhost:5000

■ Endpoints
POST /api/comments
Request:
{ "text": "Me encantó el producto" }
Response:
{
 "id": 1,
 "text": "Me encantó el producto",
 "sentiment": "Positivo"
}


GET /api/comments
Response:
[
 { "id": 1, "text": "Me encantó el producto", "sentiment": "Positivo" },
 { "id": 2, "text": "El servicio fue lento", "sentiment": "Negativo" }
]
■■ Base de Datos
Tabla: Comments
----------------
Id INT (PK) Identificador único
Text NVARCHAR(MAX) Comentario del usuario
Sentiment NVARCHAR(50) Resultado (Positivo, Negativo, Neutro)

<img width="1812" height="622" alt="image" src="https://github.com/user-attachments/assets/8ec248f8-b23f-4b8f-9191-957863c1fefc" />
