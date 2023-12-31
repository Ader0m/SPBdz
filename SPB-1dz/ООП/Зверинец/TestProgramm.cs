﻿namespace SPB_1dz.ООП.Зверинец
{
    internal static class TestProgramm
    {
        private static List<Animal> _animals = new();

        public static void Main()
        {
            Console.WriteLine("Создал живность. 1 кот с ошибкой т.к. маленькое имя, 1 кот, 1 собака.");

            Cat cat1 = new Cat(":о");
            cat1 = new Cat("Джо");
            Dog dog1 = new("Боб");
            _animals.Add(cat1);
            _animals.Add(dog1);

            foreach (Animal animal in _animals)
            {
                animal.Jump(2);
                animal.Run(500);
                animal.Swim(10);
            }

            CountZoo();

            Console.WriteLine("По итогу должно быть 2 животных: 1 кот, 1 собака");
        }

        public static void CountZoo()
        {
            Console.WriteLine($"Животных - {Animal.Count}");
            Console.WriteLine($"Котов - {Cat.Count}");
            Console.WriteLine($"Собак - {Dog.Count}");
        }
    }
}
