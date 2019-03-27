using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public decimal Stake { get; set; }
        public int SelectionId { get; set; }

        public override string ToString()
        {
            string result = $"Bet id: {Id}, Stake {Stake}, SelectionId {SelectionId}";

            return result;
        }
    }
}
