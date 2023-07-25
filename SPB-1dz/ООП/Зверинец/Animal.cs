using System.Text;

namespace SPB_1dz.ООП.Зверинец
{
    abstract class Animal
    {
        protected delegate void OnAction(bool successful, string action);
        protected OnAction onActionEvent;

        public string? Name
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
        public static int Count { get; private set; } = 0;
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
            Count++;
            onActionEvent += PrintActionResult;
        }

        ~Animal()
        {
            onActionEvent -= PrintActionResult;
        }

        public virtual bool Jump(int length)
        {
            bool result;
            if (_jumpPower >= length)
                result = true;
            else
                result = false;
            onActionEvent.Invoke(result, "Прыгнуть");

            return result;
        }

        public virtual bool Run(int length)
        {
            bool result;
            if (_runPower >= length)
                result = true;
            else
                result = false;
            onActionEvent.Invoke(result, "Пробежать");

            return result;
        }

        public virtual bool Swim(int length)
        {
            bool result;
            if (_swimPower >= length)
                result = true;
            else
                result = false;
            onActionEvent.Invoke(result, "Проплыть");

            return result;
        }

        protected virtual void PrintActionResult(bool successful, string action)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} ");
            if (successful)
                sb.Append("смог ");           
            else
                sb.Append("не смог ");
            sb.AppendLine($"{action} заданное расстояние");

            Console.WriteLine(sb.ToString());
        }       
    }
}
