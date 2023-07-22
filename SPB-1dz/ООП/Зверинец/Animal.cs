using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPB_1dz.ООП.Зверинец
{
    abstract class Animal
    {
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 2)
                    _name = value;
                else
                    Console.WriteLine("Имя не может быть меньше 3 букв");
            }
        }
        public static int AnimalCount = 0;
        protected string? _name;
        protected int _swimPower;
        protected int _jumpPower;
        protected int _runPower;

        public Animal(string name)
        {
            Name = name;
            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Создание животного завершилось ошибкой");
                return;
            }
            AnimalCount++;
        }

        public void Jump(int length)
        {
            Console.Write($"{Name} ");
            if (_jumpPower >= length)
                Console.Write("смог ");
            else
                Console.Write("не смог ");
            Console.WriteLine($"прыгнуть на заданную высоту");

        }

        public void Run(int length)
        {
            Console.Write($"{Name} ");
            if (_runPower >= length)
                Console.Write("смог ");
            else
                Console.Write("не смог ");
            Console.WriteLine($"прыгнуть на заданную высоту");
        }

        public void Swim(int length)
        {
            Console.Write($"{Name} ");
            if (_swimPower >= length)
                Console.Write("смог ");
            else
                Console.Write("не смог ");
            Console.WriteLine($"прыгнуть на заданную высоту");
        }
    }
}
