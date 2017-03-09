using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Event
{
    public string Name { get; set; }
    public List<string> Participant { get; set; }
}

class RoliTheCoder
{
    static void Main()
    {
        var eventsList = new Dictionary<int, Event>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "Time for Code")
            {
                break;
            }

            var eventPattern = @"(?<id>\d+)\s+#(?<eventName>[\w\d]+)(\s+(?:@\w+\s*)+)?";

            var eventDetails = Regex.Match(input, eventPattern);

            if (eventDetails.Success)
            {
                var id = int.Parse(eventDetails.Groups["id"].Value);
                var eventName = eventDetails.Groups["eventName"].Value;

                var participants = new string[0];
                var eventHasParticipants = input.Contains("@");

                if (eventHasParticipants)
                {
                    participants = input.Substring(input.IndexOf('@'))
                        .Split()
                        .Where(a => a != "")
                        .ToArray();
                }               

                if (!eventsList.ContainsKey(id))
                {
                    eventsList[id] = new Event()
                    {
                        Name = eventName,
                        Participant = new List<string>()
                    };
                }

                if (eventsList[id].Name == eventName)
                {
                    eventsList[id].Participant.AddRange(participants);

                    eventsList[id].Participant = eventsList[id]
                        .Participant
                        .Distinct()
                        .ToList();
                }
            }

        }

        var sortedEvents = eventsList
            .OrderByDescending(a => a.Value.Participant.Count)
            .ThenBy(a => a.Value.Name)
            .ToArray();

        foreach (var @event in sortedEvents)
        {
            var eventName = @event.Value.Name;
            var participantsCount = @event.Value.Participant.Count();
            Console.WriteLine($"{eventName} - {participantsCount}");

            var sortedParticipants = @event.Value.Participant.OrderBy(a => a);
            foreach (var participant in sortedParticipants)
            {
                Console.WriteLine(participant);
            }
        }
    }
}

