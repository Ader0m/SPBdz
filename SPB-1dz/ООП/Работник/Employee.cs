namespace SPB_1dz.ООП.Работник
{
    internal class Employee
    {
        public int Age { get => _age; private set => _age = value; }

        private string _fio;
        private string _function;
        private string _email;
        private string _phone;
        private int _salary;
        private int _age;

        public Employee(string fio, string function, string email, string phone, int salary, int age)
        {
            _fio = fio;
            _function = function;
            _email = email;
            _phone = phone;
            _salary = salary;
            _age = age;
        }

        public override string ToString()
        {
            return $"ФИО {_fio}\nДолжность {_function}\nПочта {_email}\nТелефон {_phone}\nЗарплата {_salary}\nВозраст {_age}";
        }

        public void PrintAllInfo()
        {
            Console.WriteLine(this.ToString());
        }
    }
}