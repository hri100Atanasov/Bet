using System;

namespace ConsoleApp1.Core
{
    public class UserInterface
    {
        private DataManager dataManager;
        public UserInterface()
        {
            dataManager = new DataManager();
        }

        public void Run()
        {
            ShowOptions();
            while (true)
            {
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        // Show list of events
                        dataManager.ShowEvents();
                        break;
                    case 2:
                        // Show list of selections
                        Console.WriteLine("Enter event Id.");
                        int eventId = int.Parse(Console.ReadLine());
                        dataManager.ShowSelections(eventId);
                        break;
                    case 3:
                        //Place a bet
                        Console.WriteLine("Enter selection Id:");
                        var selectionId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter stake amount");
                        var stake = decimal.Parse(Console.ReadLine());
                        dataManager.PlaceABet(stake, selectionId);
                        break;
                    case 4:
                        //Display user bets
                        dataManager.DisplayUserBets();
                        break;
                    case 5:
                        //Display evetns by bet id
                        Console.WriteLine("Enter Bed id");
                        int betId = int.Parse(Console.ReadLine());
                        dataManager.DisplayEventByBetId(betId);
                        break;
                }
            }
        }

        static void ShowOptions()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------|");
            Console.WriteLine("Please choose an option:    |");
            Console.WriteLine("                            |");
            Console.WriteLine("1. Show list of events.     |");
            Console.WriteLine("2. Show list of selections. |");
            Console.WriteLine("3. Place a bet.             |");
            Console.WriteLine("4. Display user bets.       |");
            Console.WriteLine("5. Display evetns by bet id.|");
            Console.WriteLine("----------------------------|");
        }
    }
}
