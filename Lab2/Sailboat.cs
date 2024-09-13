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

        public void SetSail()
        {
            Console.WriteLine($"{Name} is setting its sail.");
        }

        public void LowerSail()
        {
            Console.WriteLine($"{Name} is lowering its sail.");
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            if (!base.Equals(obj))
                return false;

            Sailboat sailboat = (Sailboat)obj;
            return SailArea == sailboat.SailArea;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), SailArea);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Length: {Length}, Width: {Width}, Draft: {Draft}, Sail Area: {SailArea} square meters";
        }

        public new object Clone()
        {
            Sailboat clone = (Sailboat)base.Clone();
            clone._sailArea = this._sailArea;
            return clone;
        }
    }
}
