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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            if (!base.Equals(obj))
                return false;

            Steamship steamship = (Steamship)obj;
            return EnginePower == steamship.EnginePower;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), EnginePower);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Length: {Length}, Width: {Width}, Draft: {Draft}, Engine Power: {EnginePower}";
        }

        public new object Clone()
        {
            Steamship clone = (Steamship)base.Clone();
            clone._enginePower = this._enginePower;
            return clone;
        }
    }
}
