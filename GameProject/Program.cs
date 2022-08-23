
using GameProject;
using PersonRegistrationSimulation;

GamerManager gamerManager = new GamerManager(new UserValidationManager());
gamerManager.Add(new Gamer { Id=1, BirthYear=1983, FirstName="Celil", IdentityNumber=12345, LastName="Tat"});