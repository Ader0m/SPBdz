using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPB_1dz.ООП.Зверинец
{
    internal class Cat : Animal
    {
        public static int CatCount = 0;

        public Cat(string name) : base(name)
        {
            if (string.IsNullOrEmpty(Name))
                return;

            CatCount++;
            _jumpPower = 2;
            _swimPower = 0;
            _runPower = 200;
        }
    }
}
