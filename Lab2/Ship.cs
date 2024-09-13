using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Ship
    {
        private string _name;
        private float _length;
        private float _width;
        private float _draft;

        public Ship(string name, float length, float width, float draft)
        {
            _name = name;
            _length = length;
            _width = width;
            _draft = draft;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public float Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public float Draft
        {
            get { return _draft; }
            set { _draft = value; }
        }

        public void Sail()
        {
            Console.WriteLine($"{Name} is sailing.");
        }

        public void Anchor()
        {
            Console.WriteLine($"{Name} is anchoring.");
        }
    }
}
