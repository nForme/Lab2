using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Steamship : Ship
    {
        private int _enginePower;

        public Steamship(string name, float length, float width, float draft, int enginePower)
            : base(name, length, width, draft)
        {
            _enginePower = enginePower;
        }

        public int EnginePower
        {
            get { return _enginePower; }
            set { _enginePower = value; }
        }

        public void StartEngine()
        {
            Console.WriteLine($"{Name} is starting its engine.");
        }

        public void StopEngine()
        {
            Console.WriteLine($"{Name} is stopping its engine.");
        }
    }
}
