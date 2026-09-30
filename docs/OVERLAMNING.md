# Överlämningsnot

  ## Översikt

  Ett internt felanmälningssystem för IT-support. Användare skickar in
  felanmälningar och följer sina ärenden. Supporten ser alla ärenden,
  kategoriserar dem och ändrar status (Nytt → Pågående → Löst).

  Byggt i Blazor (.NET 10) med SQLite som databas.

  | Sida | Vem | Vad |
  |---|---|---|
  | `/create-issue` | Användare | Skapa felanmälan |
  | `/my-issues` | Användare | Se sina egna ärenden (uppdateras var 10:e sekund) |
  | `/support` | Support | Se alla ärenden, ändra kategori |
  | `/issue/{id}` | Support | Se ett ärende, ändra status |
  | `/support-overview` | Support | Antal ärenden per kategori |

  ## Nyckelpersoner

  | Namn | Ansvar | Kontakt |
  |---|---|---|
  | Andreas | Kategorisering, mina ärenden, statusändring | <...> |
  | Anna | Skapa felanmälan, användardropdown,databas | <...> |
  | Luka | Projektskelett, databas, Username, kategoriöversikt | <...> |
  | Pierre | CompletedAt, automatisk migrering, startsida och meny | <...> |

  ## Var koden finns

  Repo: https://github.com/C3derholm/IU2-Grupp6
  Gren som gäller: `main`

  ## Hur man kör den

  ```
  dotnet restore
  dotnet run --project src/IU2.Web
  ```

  Appen svarar på http://localhost:5080

  Förutsättningar:

  - .NET SDK 10 (kolla med `dotnet --list-sdks`)
  - Inga konton eller nycklar behövs
  - Databasen (`supportapp.db`) skapas och uppdateras automatiskt när appen
    startar. Den ligger inte i Git – varje utvecklare har sin egen.
  - Det finns ingen inloggning. Användare väljs från en fast lista
    (Anna Andersson, Bob Bergström m.fl.)

  ## Vad som är känt men inte åtgärdat

  | Vad | Hur allvarligt | Var i koden |
  |---|---|---|
  | Ingen inloggning – vem som helst kan välja vilken användare som helst och se dennes ärenden, och nå supportsidorna |Hög | `CreateIssue.razor`, `MyIssues.razor`, `Support.razor` |
  | `CompletedAt` nollställs inte när ett löst ärende öppnas igen | Låg | `IssueService.UpdateStatusAsync` |
  | Användarlistan finns på två ställen | Låg | `CreateIssue.razor`, `MyIssues.razor` |
  

  ## Vad ett mottagande team bör ta först

  1. Uppdatera EF Core-paketen (10.0.0 → senaste 10.0.x) så att säkerhetsvarningen försvinner.
  2. Inför inloggning med roller (användare / support), så att användare bara når sina egna ärenden.

  ## Vad vi skulle göra om vi fick en vecka till

  - Inloggning och roller
  - Filtrering och sortering på kategori och status i supportlistan
  - Push-notiser istället för att listan hämtas var 10:e sekund
  
