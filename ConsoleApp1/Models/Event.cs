using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Selection> Selections { get; set; }

        public override string ToString()
        {
            string result = $"Event Id: {Id}, Name {Name}";

            return result;
        }
    }
}
