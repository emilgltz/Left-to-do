**kodens funktioner och struktur**

## Meny ##
`Menu-klassen är spindeln i nätet, via  den sker output med instruktioner och olika val som användaren kan göra. även den första inputen som matas in sker via Menu-klassen `

## Task ##
`Task-klassen är en abstrakt "superklass" som samtliga klasser ärver egenskaper från, underklasserna har sedan egna "properties" som är unika för varje klass, deadline har exempelvis en metod för att räkna ut dagar. Checklisttask innehåller en egen "tasklista" i form av SubTask som är dess deluppgifter samt en metod för att lägga till subtasks i checklisttask. `

## TaskManager ##
`TaskManager-klassen står för nästan alla funktioner i programmet, exempelvis för att arkivera,markera och ta bort olika uppgifter från deras listor. mycket av input/output sker också i  denna klass i olika swtich-cases`


## Principer ##
`Mycket av koden  var skrivet i ett tidigare skede, skulle gärna reformerat en hel del då jag inte riktigt har fått med deb polyforismen och inkapsulationen som jag har "kunskap" om nu. Vidare så har jag uppnåt någon form av inkapsulation i min Deadline-klass där metoden "EstimateDeadline" är privat och kan bara ses av Deadline-klassen. Likaså i CheckList-klassen där metoden SubTaskList är privat och därav också uppnår inkapsulation. `

`Annars finns det mycket jag hade gjort annorlunda, som exempelvis skulle jag vilja korta ner hela TaskManager-klassen och skriva om en del metoder där jag upplever att kod upprepas och att strukturen är väldigt rörig. `


**Tester**

## TaskToListTest ##
`Första testet kontrollerar att två tasks går att lägga till i sina respektive listor`

## ArchiveTasksTest ##
`Andra testet säkerställer att en "simpleTask" som är markerad som färdig går att lägga till i listan över arkiverade uppgifter, jag skapade två "SimpleTasks" där ena fick "Completed=true" och den andra "Completed=false". Vilket bevisar att endast uppgifter som är markerade som färdiga går att akrivera`



`Även i denna uppgift märkte jag hur svårt det är att skapa enhetstester för metoder som är allt för invecklade. exempelvis kunde jag inte få till ett enhetstest som för krav:10 pågrund av att dess metod var invecklad och förlitade sig på inputs från använder, därför förstår jag nu på ett annat sätt hur viktigt det är att skriva testdriven kod`