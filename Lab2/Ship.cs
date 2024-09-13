using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

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

        public void Move(float speed)
        {
            Console.WriteLine($"{Name} is moving at {speed} knots.");
        }

        public void Repair()
        {
            Console.WriteLine($"{Name} is being repaired.");
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Ship ship = (Ship)obj;
            return Name == ship.Name && Length == ship.Length && Width == ship.Width && Draft == ship.Draft;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Length, Width, Draft);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Length: {Length}, Width: {Width}, Draft: {Draft}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}


