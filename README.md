# Muscat Gates MVC

A .NET 10 ASP.NET Core MVC real estate website styled with Bootstrap and backed by EF Core + SQLite.

## What’s Included

- MVC project structure with `HomeController`
- Bootstrap-based responsive layout
- EF Core database models for advertisements, agents, articles, deals, houses, keywords, materials, static content, and status lookups
- Localized text helpers for `fa`, `en`, and `ar`
- Seeded data so the homepage renders without manual database entry
- Razor homepage that pulls all main text from backend content

## Tech Stack

- ASP.NET Core MVC
- EF Core 10
- SQLite
- Bootstrap 5
- Font Awesome

## Run It

```bash
 dotnet build "c:\Users\Shams\Desktop\New folder\MasqatGate.csproj"
 dotnet run --project "c:\Users\Shams\Desktop\New folder\MasqatGate.csproj"
```

The app uses SQLite and will create `realestate.db` automatically on first launch.

## Database Notes

The project includes these main entities:

- `Advertisement`
- `Agent`
- `Article`
- `Deal`
- `Floor`
- `House`
- `HouseImage`
- `Keyword`
- `Material`
- `StaticData`
- `StaticDataGroup`
- `Status`

Seed data is loaded automatically in `DbInitializer`.

## Localization

The homepage reads content from `StaticData` through the `LocalizedContent` extension and falls back safely when a language value is missing.

## Important Files

- `Program.cs`
- `MasqatGate.csproj`
- `Controllers/HomeController.cs`
- `Data/RealEstateDbContext.cs`
- `Data/DbInitializer.cs`
- `Views/Home/Index.cshtml`
- `Views/Shared/_Layout.cshtml`
- `wwwroot/css/site.css`

## Notes

- Replace placeholder images in `wwwroot` with real assets when you have them.
- If you want, the next step can be adding property listing pages, blog pages, and a proper admin panel.
