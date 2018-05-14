# ITP
Internet Teknologi Projekt

For at k�re projektet: 
1. �ben projektet i Visual Studio
2. Eventuelt �ndre "DefaultConnection" i appsettings.json filen
3. K�r projektet i debug-mode f�rste gang (F5). For mit vedkommende kunne databasen ikke oprettes hvis jeg k�rte projektet i non-debug mode (Ctrl + F5)
	Efter at have k�rt i debug-mode en enkelt gang virker alting fint i non-debug mode ogs�. 

Filen DbInitializer seeder databasen s� der er en smugle content fra start af. 
Hvis der �ndres i en Model skal databasen instantieres p� ny, med et nyt navn, da den ikke er i stand til at modificere den gamle database.
Dette �ndres ved at erstatte "CHANGEME" nedenfor med et navn for databasen. (appsettings.json)

"DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database="CHANGEME;Trusted_Connection=True;MultipleActiveResultSets=true"

Det mest praktiske ville selvf�lgelig v�re hvis den overskrev den gamle instans af databasen, men det kunne jeg ikke f� den til. 