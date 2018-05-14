# ITP
Internet Teknologi Projekt

For at køre projektet: 
1. Åben projektet i Visual Studio
2. Eventuelt ændre "DefaultConnection" i appsettings.json filen
3. Kør projektet i debug-mode første gang (F5). For mit vedkommende kunne databasen ikke oprettes hvis jeg kørte projektet i non-debug mode (Ctrl + F5)
	Efter at have kørt i debug-mode en enkelt gang virker alting fint i non-debug mode også. 

Filen DbInitializer seeder databasen så der er en smugle content fra start af. 
Hvis der ændres i en Model skal databasen instantieres på ny, med et nyt navn, da den ikke er i stand til at modificere den gamle database.
Dette ændres ved at erstatte "CHANGEME" nedenfor med et navn for databasen. (appsettings.json)

"DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database="CHANGEME;Trusted_Connection=True;MultipleActiveResultSets=true"

Det mest praktiske ville selvfølgelig være hvis den overskrev den gamle instans af databasen, men det kunne jeg ikke få den til. 