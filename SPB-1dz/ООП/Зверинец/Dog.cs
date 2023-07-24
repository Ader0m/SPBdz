namespace SPB_1dz.ООП.Зверинец
{
    internal class Dog : Animal
    {
        public static new int Count = 0;

        public Dog(string name) : base(name)
        {
            if (string.IsNullOrEmpty(Name))
                return;

            Count++;
            _jumpPower = 0;
            _swimPower = 10;
            _runPower = 500;
        }
    }
}
