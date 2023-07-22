using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPB_1dz.ООП.Зверинец
{
    internal class Dog : Animal
    {
        public static int DogCount = 0;

        public Dog(string name) : base(name)
        {
            if (string.IsNullOrEmpty(Name))
                return;

            DogCount++;
            _jumpPower = 0;
            _swimPower = 10;
            _runPower = 500;
        }
    }
}
