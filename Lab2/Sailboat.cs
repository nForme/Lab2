using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Sailboat : Ship
    {
        private float _sailArea;

        public Sailboat(string name, float length, float width, float draft, float sailArea)
            : base(name, length, width, draft)
        {
            _sailArea = sailArea;
        }

        public float SailArea
        {
            get { return _sailArea; }
            set { _sailArea = value; }
        }

        public void HoistSail()
        {
            Console.WriteLine($"{Name} is hoisting its sails.");
        }

        public void LowerSail()
        {
            Console.WriteLine($"{Name} is lowering its sails.");
        }
    }
}
