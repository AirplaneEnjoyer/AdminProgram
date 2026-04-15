# AdminProgram
Hier lever ik mijn admin program opdrachten in

Admin Program Documentatie
Dit programma is gemaakt wegens reden (Schrijf reden), in dit programma kan je de volgende dingen doen (schrijf functionaliteiten)

Programma werking:
In dit programma heb je de volgende functionaliteiten:
1.	Gebruiker aanmaken
2.	Gebruiker verwijderen
3.	etc
4.	etc

1: Gebruiker aanmaken.
Deze functie gebruik je als je een gebruiker wilt aanmaken. Wanneer je deze functie wil gebruiken type je 1 in de main menu en dan vraagt het om jou gegevens.

Bij elke vraag vul je je id, naam, leeftijd en e-mail in
 
De Console.Write vraagt om een id in te voeren en dan checkt de TryParse of het een getal is en als dat niet zo is geeft het een fout melding en de users.
Any controleert of het ID al bestaat in de lijst en als dat zo is geeft het de melding dat het al bestaat.
Bij Console.ReadLine moet de gebruiker de naam invoeren en ook bij de e-mail en leeftijd maar als het niet een getal is bij de leeftijd geeft het een foutmelding, users.Add voegt de nieuwe gebruiker aan bij de lijst en dan bevestigt het of er een nieuwe gebruiker is toegevoegd


2: Gebruiker verwijderen.
Deze functie gebruik je als je een gebruiker witlt verwijderen. Wanneer je deze functie wil gebruiken type je 2 in de main menu en dan vraagt het jou voor een id

Bij elke gebruiker die je wilt verwijderen geef je alleen de id van degene die je wilt verwijderen en dan verwijdert hij de gebruiker
 
De Console.Write vraagt welke ID je wilt verwijderen en dan controleert de TryParse of het een geldig getal is en als dat niet zo is geeft het een foutmelding.
Users.FirstOrDefault zoekt in de lijst naar een gebruiker met dat ID, als er geen match is wordt de user gelijk aan null, en als dat niet null is controleert het of de gebruiker gevonden is.
Users.Revmove verwijdet de gebruiker en console.Writeline laat zien dat de gebruiker uit de list is verwijdert, maar als de gebruiker niet bestaat zegt hij “User not found”


3: Gebruiker editen.
Deze functie gebruik je als je een gebruiker wilt aanpassen. Wanneer je deze functie wil gebruiken type je 3 in de main menu en dan vraagt het om de id

Bij elke gebruiker die wilt editen vraagt hij eerst voor de id, en dan voor de leeftijd en naam, maar als je het wit laat kan je houden wat er al stond in plaats van de leeftijd en naam
 
Console.Write vraagy welke ID je wilt aanpassen en dan checkt TryParse of het ID een geldig getal is, zo niet komt er een foutmelding, dan zoekt users.FirstOrDefault een gebruiker met dat id, en als de user net null is controleert hij of die gebruiker bestaat.
Nu vult de gebruiker een nieuwe naam en dan wordt er gecheckt of er iets is ingevuld, zo niet wordt het niet aangepast, het is hetzelfde met de leeftijd maar dan werkt het alleen met getallen.
Console.WriteLine bevestigd of de gebruiker is aangepast en als hij niet bestaat geeft hij “User not found”


4: Gebruiker leeftijd bekijken.
Deze functie gebruik je als je een gebruiker wilt aanpassen. Wanneer je deze functie wil gebruiken type je 4 in de main menu en dan vraagt het om de id

Bij elke gebruiker die wilt bekijken voor de leeftijd vraagt hij eerst voor de id, en dan kijkt hij of je een minor bent of niet, als je een minor bent wordt je verwijderd
 
Console.Write Vraagt om het ID van de gebruiker dan controleert TryParse of het een geldig getal is, zo niet is er een foutmelding en stopt het.
users.FirstOrDefault zoekt de gebruiker in de lijst en als hij niet null is Controleert het of de gebruiker bestaat en dan checkt user.Age of je 18 bent of niet en als je 18 of hoger bent stopt het maar als je 17 of lager bent verwijdert het de user


5: Gebruikers laten zien.
Deze functie gebruik je als je alle gebruikers in de list wil zien. Wanneer je deze functie wil gebruiken type je 5 in de main menu

 
if (users.Count) Controleert of er geen gebruikers in de lijst zitten en dan laat Console.WriteLine een melding zien als de lijst leeg is en dan stopt return de functie.
Console.WriteLine Print een titel boven de lijst (met een lege regel ervoor). En dan loopt foreach door de gebruikers van de list heen en dan print Console.WriteLine per gebruiker de gegevens: ID, naam, leeftijd en e-mail.


6: afsluiten.
Deze functie gebruik je als je alle gebruikers in de list wil afsluiten. Wanneer je deze functie wil gebruiken type je 6 in de main menu
 
Running breekt de switch af en stop het programma






