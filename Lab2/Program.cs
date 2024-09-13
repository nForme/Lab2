namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        //Создание экземпляров классов
        Ship ship1 = new Ship("Titanic", 10000, 1000, 500);
        Steamship steamship1 = new Steamship("North Star", 8000, 600, 300, 2000);
        Sailboat sailboat1 = new Sailboat("Mystery", 5000, 300, 150, 100);
        Corvette corvette1 = new Corvette("Defender", 7000, 500, 250, "Guns and torpedoes");

        // Вызов методов классов
        Console.WriteLine("Методы классов:");
        ship1.Sail();
        steamship1.Sail();
        sailboat1.Sail();
        corvette1.Sail();

        ship1.Anchor();
        steamship1.Anchor();
        sailboat1.Anchor();
        corvette1.Anchor();

        Console.WriteLine("Логика для кораблей:");
        // Добавление логики и поведения для каждого типа корабlea
        steamship1.StartEngine();
        sailboat1.HoistSail();
        corvette1.Fire();

        Console.WriteLine("Управление состоянием кораблей:");
        // Реализация обработки событий или логики для управления состоянием корабlea
        ship1.Sail();
        steamship1.StopEngine();
        sailboat1.LowerSail();
        corvette1.Defend();
    }
}
    

