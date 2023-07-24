namespace SPB_1dz.ООП.Зверинец
{
    internal class Cat : Animal
    {
        public static new int Count = 0;

        public Cat(string name) : base(name)
        {
            if (string.IsNullOrEmpty(Name))
                return;

            Count++;
            _jumpPower = 2;
            _swimPower = 0;
            _runPower = 200;
        }
    }
}
