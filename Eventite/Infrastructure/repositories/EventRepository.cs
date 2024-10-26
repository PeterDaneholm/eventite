namespace ConsoleAppTest.repositories;
using ConsoleAppTest.Infrastructure.Models;
using ConsoleAppTest.Infrastructure.Factories;

public class EventRepository: IRepository<Event>
{
   private EventFactory _eventFactory = new EventFactory();
   private InviteRepository _inviteRepository;
   private List<Event> allEventsList = new List<Event>();

   public EventRepository()
   {
      _inviteRepository = new InviteRepository();
      allEventsList =
      [
         new Event { eventId = Guid.NewGuid(), title = "Paddle Tennis", host = "Peter", attending = [], description = "Come play paddle tomorrow", date = DateTime.Today, invites = []},
         new Event { eventId = Guid.NewGuid(), title = "Dinner Party", host = "Philip", attending = [], description = "Dinner and boardgames tomorrow", date = DateTime.Today.AddDays(6), invites = []},
      ];
   }
   
   public void Add(Event entity, Guid userId)
   {
      try
      {
         Invite newInvite = _inviteRepository.CreateInvite(entity.eventId, userId);
         Event newEvent = _eventFactory.NewEvent(entity.title, entity.description);
         newEvent.invites.Add(newInvite);
         allEventsList.Append(newEvent);
         Console.WriteLine("Event added");
      }
      catch (Exception e)
      {
         Console.WriteLine(e);
         throw;
      }
   }

   public Event GetEvent(Guid eventId)
   {
      Event foundEvent = allEventsList.FirstOrDefault(e => e.eventId == eventId);
      Console.WriteLine($"Found event {foundEvent.title}");
      return foundEvent;
   }

   public List<Event> GetEvents()
   {
      return allEventsList;
   }

   public Event UpdateEvent(Guid eventId)
   {
      Event foundEvent = allEventsList.FirstOrDefault(e => e.eventId == eventId);


      return foundEvent;
   }
}