namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // a) Разработать основные методы классов, иллюстрирующие работу с объектами этих классов.
        Ship ship = new Ship("Normandie", 300f, 50f, 10f);
        ship.Move(10f);
        ship.Repair();

        Steamship steamship = new Steamship("MS Queen Mary 2", 200f, 70f, 12f, 10000);
        steamship.StartEngine();
        steamship.StopEngine();

        Sailboat sailboat = new Sailboat("Cutty Sark", 60f, 15f, 3f, 100f);
        sailboat.SetSail();
        sailboat.LowerSail();

        Corvette corvette = new Corvette("USS Lassen", 100f, 30f, 5f, "Missile Launcher");
        corvette.LaunchMissile();

        // b) Переопределить методы, унаследованные из класса Object
        Ship shipClone = (Ship)ship.Clone();
        Console.WriteLine(shipClone.ToString());

        // c) protected Object clone()
        // d) public boolean equals(Object obj)
        // e) public int hashCode()
        // f) public String toString()
        Console.WriteLine(ship.Equals(shipClone));
        Console.WriteLine(ship.GetHashCode());
        Console.WriteLine(ship.ToString());

        Ship[] ships = new Ship[]
{
                new Steamship("MS Queen Mary 2", 200f, 70f, 12f, 10000),
                new Sailboat("Cutty Sark", 60f, 15f, 3f, 100f),
                new Corvette("USS Lassen", 100f, 30f, 5f, "Missile Launcher")
};

        // Использование полиморфизма для вызова методов
        foreach (Ship obj in ships)
        {
            ship.Move(10f);
            ship.Repair();
        }

        Console.ReadLine();
    }
}
    

