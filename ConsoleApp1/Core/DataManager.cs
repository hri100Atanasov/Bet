using ConsoleApp1.Models;
using System.Collections.Generic;

namespace ConsoleApp1.Core
{
    public class DataManager
    {
        private Dictionary<int, Event> events;
        private Dictionary<int, int> mapSelectionEvent;
        private Dictionary<int, Bet> bets;

        private List<Selection> selections;

        public DataManager()
        {
            bets = new Dictionary<int, Bet>();

            selections = new List<Selection>
            {
                new Selection{Id=1, Name="A", Odds=1.2m},
                new Selection{Id=2, Name="B", Odds=1.3m},
                new Selection{Id=3, Name="C", Odds=1.4m},
                new Selection{Id=4, Name="D", Odds=1.5m}
            };

            mapSelectionEvent = new Dictionary<int, int>
            {
                { 1,1 },
                { 2,1 },
                { 3,2 },
                { 4,2 }
            };

            events = new Dictionary<int, Event>
            {
                { 1, new Event{ Id=1, Name="A vs B", Selections = new List<Selection>{ selections[0], selections[1]}}},
                { 2, new Event{ Id=2, Name="C vs D", Selections = new List<Selection>{ selections[2], selections[3]}}}
            };

        }

        public void ShowEvents()
        {
            foreach (var eventItem in events.Values)
            {
                System.Console.WriteLine(eventItem);
            }
        }

        public void ShowSelections(int eventId)
        {
            var filteredSelections = events[eventId].Selections;
            System.Console.WriteLine(string.Join(", ", filteredSelections));
        }

        public void PlaceABet(decimal stake, int selectionId)
        {
            var betId = bets.Count;
            var bet = new Bet { Id = betId, SelectionId = selectionId, Stake = stake };
            bets.Add(betId, bet);
            System.Console.WriteLine("Bet placed!");
        }

        public void DisplayUserBets()
        {
            System.Console.WriteLine(string.Join(", ", bets.Values));
        }

        public void DisplayEventByBetId(int betId)
        {
            var betName = events[mapSelectionEvent[bets[betId].SelectionId]];
            System.Console.WriteLine(betName);
        }
    }
}