using System;
using System.Collections.Generic;
using System.Linq;

public class Event
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<string> Participants { get; set; }
}

class RoliTheCoder
{
    static void Main()
    {
        var result = new List<Event>();
        var eventsById = new Dictionary<int, Event>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "Time for Code")
            {
                break;
            }

            var tokens = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var eventId = 0;

            if (!int.TryParse(tokens[0], out eventId))
            {
                continue;
            }

            string eventName = null;

            if (tokens.Length > 1 && tokens[1].StartsWith("#"))
            {
                eventName = tokens[1].Trim('#');
            }
            else
            {
                continue;
            }

            var participants = new List<string>();

            if (tokens.Length > 2)
            {
                participants = tokens.Skip(2).ToList();

                if (!participants.All(p => p.StartsWith("@")))
                {
                    continue;
                }
            }

            if (eventsById.ContainsKey(eventId))
            {
                if (eventsById[eventId].Name == eventName)
                {
                    var existingEvent = eventsById[eventId];
                    existingEvent.Participants.AddRange(participants);
                }
                else
                {
                    continue;
                }
                
            }
            else
            {
                var newEvent = new Event
                {
                    Id = eventId,
                    Name = eventName,
                    Participants = participants
                };

                result.Add(newEvent);
                eventsById.Add(eventId, newEvent);
            }

            participants.Sort();


            
        }

        var sortedEvents = result
            .OrderByDescending(e => e.Participants.Distinct().Count())
            .ThenBy(e => e.Name);

        foreach (var ev in sortedEvents)
        {
            var distinctParticipants = ev.Participants.Distinct().ToList();
            Console.WriteLine($"{ev.Name} - {distinctParticipants.Count}");
            foreach (var participant in distinctParticipants.OrderBy(p => p))
            {
                Console.WriteLine(participant);
            }
        }
    }
}

