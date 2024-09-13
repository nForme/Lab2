using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Corvette : Ship
    {
        private string _armament;

        public Corvette(string name, float length, float width, float draft, string armament)
            : base(name, length, width, draft)
        {
            _armament = armament;
        }

        public string Armament
        {
            get { return _armament; }
            set { _armament = value; }
        }

        public void Fire()
        {
            Console.WriteLine($"{Name} is firing its armament.");
        }

        public void Defend()
        {
            Console.WriteLine($"{Name} is defending itself.");
        }
    }
}
