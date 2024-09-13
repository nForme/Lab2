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

        public void LaunchMissile()
        {
            Console.WriteLine($"{Name} is launching a missile.");
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            if (!base.Equals(obj))
                return false;

            Corvette corvette = (Corvette)obj;
            return Armament == corvette.Armament;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Armament);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Length: {Length}, Width: {Width}, Draft: {Draft}, Armament: {Armament}";
        }

        public new object Clone()
        {
            Corvette clone = (Corvette)base.Clone();
            clone._armament = this._armament;
            return clone;
        }
    }
}
