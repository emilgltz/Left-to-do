# Left to do
## Instruktioner
### Konsolapplikationen kräver att din dator har .NET SDK installerat
1. Klona ner repot från den nuvarande git-sidan
2. Öppna mappen "Left-to-do/src" via en terminal
3. Starta applikltionen genom att skriva in kommandot `dotnet run` i terminalen
4.Följ sedan applikationens instruktioner

## Bakgrundsbeskrivning till uppgiften "Left to do" 
Du ska i denna uppgift skapa en konsolapplikation för att hålla koll på, och ordna arbetsuppgifter; det vill säga en digital att-göra lista. Applikationen ska ha namnet Left To Do. En användare ska vid användning av programmet kunna se vad som är kvar att göra i listan, markera uppgifter som avklarade, lägga till nya uppgifter i listan samt arkivera avklarade uppgifter.


## Teknologier
* Ramverk: .NET6 Core
* Applikationstyp: Konsolapplikation (Command line arguments)
* Designmönster: Objektorienterad programmering (OOP)
* Programmeringsspråk: C#
* Testing: xUnit


## Kravspecifikation
 |Krav|Uppfyllt|Kravbeskrivning|
 |---|---|---|
|**1**  |**Ja**| *Lösningen ska bestå av en konsolapplikation skriven i C# som är körbar med .NET Core*|
|**2**  |**Ja**| *När man startar programmet ska man mötas av en startmeny som förklarar hur programmet används och låter användaren genomföra resterande krav.*|
|**3**  |**Ja**| *Man ska som användare kunna lista alla dagens uppgifter, alla uppgifter ska då listas om dom inte är "arkiverade".*|
|**4**  |**Ja**| *När dagens uppgifter är listade ska de kunna markeras som utförda, eller som kvar att göra beroende på sin nuvarande status. Detta kan förslagsvis köra med en symbol som X eller en emoji som ✔️ eller ✅*|
|**5**  |**Ja**| *Från programmets menyer ska man även kunna lägga till en ny uppgift.*|
|**6**  |**Ja**| *Från programmets menyer ska man även kunna arkivera alla uppgifter som för närvarande är utförda.*|
|**7**  |**Ja**| *Man ska kunna lista alla arkiverade uppgifter, det behöver inte gå att göra något med uppgifterna när de listas på detta vis.*|
|**8**  |**Ja**| *Den inlämnade lösningen ska bestå av en "Program.cs" fil, en ".csproj" fil samt en fil för varje extra klass du skapar.*|
|**9**  |**Ja**| *Ett enhetstest finns i lösningen för att testa att uppgifter går att lägga till i listan.*|
|**10**  |**Ja**| *Ett enhetstest finns i lösningen för att markera en uppgift som avklarad.*|
|**11**  |**Ja**| *Ett enhetstest finns i lösningen för att arkivera alla avklarade uppgifter i listan.*|
|**12**  |**Ja**| *Man ska kunna lägga till en särskild typ av uppgift med en "deadline", deadline ska sparas i systemet som antalet dagar kvar att slutföra uppgiften. Denna typ av uppgift ska vara en egen klass.*|
|**13**  |**Ja**| *Man ska kunna lägga till en typ av uppgift som har en inbyggd checklista med ytterligare detaljer - för att markeras som avklarad så måste alla punkterna i checklistan också markeras som avklarade. Denna typ av uppgift ska vara en egen klass.*|
|**14**  |**Ja**| *Lösningen ska innehålla ytterligare 1 eller 2 enhetestester som är lämpliga för de nya typerna av uppgifterna.15 (vg)*|
|**15**  |**Ja**| *Lösningen ska förutom kod innehålla en fil med namnet "reflections" i formatet md, txt eller pdf16 (vg)*|
|**16**  |**Ja**| *reflections-filen ska en ska innehålla en kort beskrivning av kodens funktioner och struktur så som du förstår den. Ungefär 2-3 paragrafer.17 (vg)*|
|**17**  |**Ja**| *Filen reflections ska innehålla rubriken "använda principerer" där du förklarat hur lösningen använder de objektorienterade principerna arv, enkapsulation och polymorfism för de ytterligare uppgifterna i krav 12 och 1318 (vg)*|
|**18**  |**Ja**| *Filen reflections ska innehålla rubriken "tester för klasser" där du förklarat hur de nya testerna som du skapat för kravet 14 fungerar och varför de är väl valda enhetestester.*|