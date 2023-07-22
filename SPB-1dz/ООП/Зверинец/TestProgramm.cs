using SPB_1dz.ООП.Зверинец;

namespace SPB_1dz.ООП.Зверинец
{
    internal static class TestProgramm
    {
        public static void Main()
        {
            Console.WriteLine("Создал живность. 1 кот с ошибкой т.к. маленькое имя, 1 кот, 1 собака.");

            Cat cat1 = new Cat(":о");
            cat1 = new Cat("Джо");
            Dog dog1 = new("Боб");

            cat1.Jump(2);
            dog1.Jump(2);

            CountZoo();

            Console.WriteLine("По итогу должно быть 2 животных: 1 кот, 1 собака");
        }

        public static void CountZoo()
        {
            Console.WriteLine($"Животных - {Animal.AnimalCount}");
            Console.WriteLine($"Котов - {Cat.CatCount}");
            Console.WriteLine($"Собак - {Dog.DogCount}");
        }
    }
}
