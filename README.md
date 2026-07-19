# Reto técnico — Ziur Software

Solución al reto técnico solicitado por Ziur Software: una aplicación Blazor que consume una API REST y despliega los datos en una grilla (QuickGrid).

## Estructura del proyecto

- `RetoZiur.Api` — API REST (ASP.NET Core Minimal API) que expone el endpoint `GET /api/items`.
- `RetoZiur.Web` — Aplicación Blazor WebAssembly que consume la API y muestra los datos en una grilla.

## Cómo ejecutarlo en local

Requisitos: [.NET SDK 8.0+](https://dotnet.microsoft.com/download)

1. Clona el repositorio.
2. En una terminal, dentro de `RetoZiur.Api`, ejecuta:
```bash
   dotnet run
```
3. En otra terminal, dentro de `RetoZiur.Web`, ejecuta:
```bash
   dotnet run
```
4. Abre en el navegador la URL que indique la terminal de `RetoZiur.Web`.

## Demo en vivo

- Frontend: (pendiente — se agrega tras el despliegue)
- API: (pendiente — se agrega tras el despliegue)

## Tecnologías usadas

- ASP.NET Core Minimal API
- Blazor WebAssembly (.NET)
- QuickGrid
- HttpClient con inyección de dependencias

## Autor

Cesar Barrios Miranda — Full Stack Developer