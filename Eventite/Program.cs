// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

GeneratorClass generatorClass = new GeneratorClass();

User newUser = generatorClass.GenerateUser();
Console.WriteLine(newUser.username);

Event newEvent = generatorClass.GenerateEvent();

EventService eventService = new EventService();
eventService.RegisterEvent(newEvent, newUser);

CLIManager cliManager = new CLIManager();
cliManager.StartInterface();