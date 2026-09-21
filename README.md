# IU2 - startmall

Startmall för **IU2 Projektleverans**, kursen Agil projektledning och
ämnesövergripande projekt, NET25S.

Mallen bygger grönt som den är. **Er uppgift är inte att få CI att fungera -
den är att förstå och motivera hur ni använder den.**

---

## Kom igång

```bash
git clone <ert repo>
cd <ert repo>
dotnet restore
dotnet build
dotnet test
dotnet run --project src/IU2.Web
```

Appen svarar på <http://localhost:5080>. Ser ni "Startmallen fungerar" är
hela kedjan uppe.

Kräver **.NET SDK 10**. Kolla med `dotnet --list-sdks`.

---

## Vad som finns

```
src/IU2.Core          Domänlogik. Här bor det som är värt att testa.
src/IU2.Web           Blazor Web App (interactive server).
tests/IU2.Core.Tests  xUnit. Två röktester som bevisar att kedjan går ihop.
.github/workflows     CI: restore, build, test - på varje push och PR.
docs/                 Mallar för projektledningsbilagan. Se nedan.
```

`Directory.Build.props` i roten sätter .NET-version och språkinställningar
för alla projekt samtidigt. Ändra på ett ställe, inte tre.

---

## Så här kommer ni igång i sprint 0

1. **Skapa repot från mallen** och bjud in alla i teamet.
2. **Skydda `main`** enligt `docs/BRANCHING.md`. Gör det direkt - efteråt
   kan ni inte råka skriva över varandra.
3. **Kör `dotnet test` lokalt** och se att det är grönt innan ni rör något.
4. **Pusha en tom ändring** och se att CI blir grön i GitHub. Nu vet ni att
   återkopplingsslingan fungerar.
5. **Fyll i `docs/DEFINITION-OF-DONE.md`** tillsammans.
6. **Börja bygga.** Kasta `Clock.cs` och `Home.razor` när ni har något eget.

---

## Tre saker vi lämnat halvfärdiga med flit

**Paketversionerna flyter.** I testprojektet står `Version="2.*"`. Det är
bekvämt och dåligt: ett bygge idag och ett bygge om två veckor kan dra olika
paket. Lås dem till exakta versioner i sprint 0 och skriv en rad om varför.

**Varningar stoppar inte bygget.** Raden finns i `Directory.Build.props`,
utkommenterad. Slår ni på den blir er DoD skarpare och er första dag
jobbigare. Bestäm er, och motivera.

**Det finns ingen databas.** Persistens är ett designbeslut som hör ihop med
er domän, och det beslutet är ert - inte mitt.

---

## Projektledningsbilagan

`docs/` innehåller mallar för det som IU2 avsnitt 4 kräver. Fyll i dem i
repot, så uppdateras de tillsammans med koden i stället för att skrivas
ihop kvällen före deadline.

| Fil | När | Hör till |
|---|---|---|
| `INTRESSENTKARTA.md` | Sprint 0 | 4.1 |
| `RISKREGISTER.md` | Sprint 0, uppdateras löpande | 4.2 |
| `KRAVFORANDRING-SVAR.md` | 29-30 sep, inom 24 timmar | 4.3 |
| `STATUSRAPPORT.md` | 30 sep kl. 08:00 | 4.4 |
| `OVERLAMNING.md` | 30 sep, vid demon | 4.4 |
| `DEFINITION-OF-DONE.md` | Sprint 0 | Bedömningskriterierna |

---

## Frågor

I kursens Discord-kanal, inte i DM. Alla frågor och svar ska vara synliga
för samtliga team.
