using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPB_1dz.ООП.Работник
{
    internal class TestProgramm
    {
        private static List<Employee> _employees = new();
        public static void Main()
        {
            Console.WriteLine("Создал работников 15, 39, 52, 21 возраста");

            _employees.Add(new("fio1", "f1", "em1", "8977", 10000, 15));
            _employees.Add(new("fio2", "f2", "em2", "+7977", 11000, 39));
            _employees.Add(new("fio3", "f3", "em3", "8926", 100000, 52));
            _employees.Add(new("fio4", "f4", "em4", "0123", 20000, 21));

            foreach(Employee emp in _employees)
            {
                if (emp.Age > 30)
                {
                    emp.PrintAllInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
