//new Program().Main();

public partial class Program
{
    Random _rand = new Random();
    int _exNum = 2;

    void PrintThreeWords()
    {
        Console.WriteLine("Hello\nDear\nFriend");
    }

    void PrintSignOfSum()
    {
        int a = _rand.Next(int.MinValue, int.MaxValue);
        int b = _rand.Next(int.MinValue, int.MaxValue);


        Console.Write($"{a} + {b} - ");
        if (a + b >= 0)
        {
            Console.WriteLine("Сумма положительная");
        }
        else
        {
            Console.WriteLine("Сумма отрицательная");
        }
    }

    void PrintValueRange()
    {
        int value = _rand.Next(int.MinValue, int.MaxValue);


        Console.Write($"Value: {value} - ");
        if (value < 0)
        {
            Console.WriteLine("Отрицательное число");
        }
        else if (0 <= value && value <= 99)
        {
            Console.WriteLine("Положительное число в диапазоне от 0 до 99");
        }
        else if (value == 100)
        {
            //Console.WriteLine("производится удаление операционной системы 3..2..1..");
        }
        else
        {
            Console.WriteLine("Положительное число, большее 100");
        }
    }

    void CompareTwoNumbers()
    {
        int a = _rand.Next(int.MinValue, int.MaxValue);
        int b = _rand.Next(int.MinValue, int.MaxValue);

        Console.WriteLine($"a - {a}, b - {b}");
        Console.WriteLine(a >= b ? "Число a больше или равно числа b" : "Число a меньше числа b");
    }

    bool ValidateSum0_10(int a, int b)
    {
        return 0 <= a + b && a + b <= 10;
    }

    void PrintSignCheck(int a)
    {
        string b = a.ToString();


        Console.WriteLine(b[0] == '-' ? "Отрицательное" : a == 0 ? "Число является нулем" : "Положительное");
    }

    bool SignCheck(int a)
    {
        return a >= 0;
    }

    void PrintNTimes(string s, int a)
    {
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine(s);
        }
    }

    void PrintIntToByte(int a)
    {
        short b = (short)a;


        Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ О ЛИЦЕНЗИОННОМ СОГЛАШЕНИИ");
        Console.WriteLine($"Используя данную функцию вы автоматически соглашаетесь\n" +
                          $"на возможную потерю данных. Автор данной функции\n" +
                          $"не несет никакой ответсвенности в случае утери данных\n" +
                          $"All Rights Reserved (R)");

        Console.WriteLine(b);
    }

    void PrintByteToInt(byte a)
    {
        int b = a;


        Console.WriteLine(b);
    }

    bool LeapYearCheck(int a)
    {
        if (!(-45 <= a && a <= DateTime.Now.Year))
        {
            Console.WriteLine($"Ошибка ввода. Год -45 <= {a} <= {DateTime.Now.Year}");
            return false;
        }

        return a % 4 == 0 && a % 100 != 0 ||
                a % 400 == 0;
    }

    void PrintInvertMass(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            a[i] = (a[i] + 1) % 2;       
    }

    void InitMass(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            a[i] = i + 1;
    }

    void UpgradeMass(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < 6)
                a[i] *= 2;
        }
    }

    /// <summary>
    /// Входной массив обязан быть квадратным
    /// </summary>
    /// <param name="a"></param>
    void DiagonallyMass(int[,] a)
    {
        int rows = a.GetUpperBound(0) + 1;


        for (int i = 0; i < rows; i++)
        {
            a[i, i] = 1;
        }
    }

    int[] InitMassWithLengthAndValue(int length, int value)
    {
        int[] a = new int[length];


        for (int i = 0; i < length; i++)
            a[i] = value;

        return a;
    }

    void PrintMinMax(int[] a)
    {
        Console.WriteLine($"Min - {a.Min()}. Max - {a.Max()}");
    }

    bool UnityCheck(int[] a)
    {
        int SumUntil(int border)
        {
            int sum = 0;


            for (int i = 0; i < border; i++)
                sum += a[i];

            return sum;
        }
        int SumAfter(int border)
        {
            int sum = 0;


            for (int i = border; i < a.Length; i++)
                sum += a[i];

            return sum;
        }

        for (int border = 1; border < a.Length; border++)
        {
            Console.WriteLine($"Border {border}. " +
                $"SumUntil {SumUntil(border)} : SumAfter {SumAfter(border)}");

            if (SumUntil(border) == SumAfter(border))
            {
                return true;
            }
        }

        return false;
    }

    void OffsetMass(int[] a, int offset)
    {
        int temp, temp1;
        if (offset > 0)
            for (int i = 0; i < offset; i++)
            {
                temp = a[0];
                for (int j = 0; j < a.Length; j++)
                {
                    temp1 = a[(j + 1) % a.Length];
                    a[(j + 1) % a.Length] = temp;
                    temp = temp1;
                }
            }
        else
        {
            for (int i = 0; i < Math.Abs(offset); i++)
            {
                temp = a[0];
                for (int j = a.Length; j > 0; j--)
                {
                    temp1 = a[(j - 1) % a.Length];
                    a[(j - 1) % a.Length] = temp;
                    temp = temp1;
                }
            }
        }
    }

    void Title(string title)
    {
        Console.WriteLine($"\nЗадание {_exNum++} -----{title}-----");
    }

    void PrintMass(int[] a)
    {
        foreach (int i in a)
            Console.Write($"{i} ");
        Console.WriteLine();
    }

    void PrintMass(int[,] a)
    {
        int rows = a.GetUpperBound(0) + 1;
        int columns = a.Length / rows;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(a[i, j]);
            }
            Console.WriteLine();
        }
    }

    public void Main()
    {
        Title("PrintThreeWords");
        PrintThreeWords();

        Title("PrintSignOfSum");
        PrintSignOfSum();

        Title("PrintValueRange");
        PrintValueRange();

        Title("CompareTwoNumbers");
        CompareTwoNumbers();

        Title("ValidateSum0_10");
        Console.WriteLine("Передаю два параметра 0 и 1");
        Console.WriteLine(ValidateSum0_10(0, 1));
        Console.WriteLine("Передаю два параметра 0 и -1");
        Console.WriteLine(ValidateSum0_10(0, -1));

        Title("PrintSignCheck");
        Console.WriteLine("Передаю 0");
        PrintSignCheck(0);
        Console.WriteLine("Передаю 1");
        PrintSignCheck(1);
        Console.WriteLine("Передаю -1");
        PrintSignCheck(-1);

        Title("SignCheck");
        Console.WriteLine("Передаю 0");
        Console.WriteLine(SignCheck(0));
        Console.WriteLine("Передаю 1");
        Console.WriteLine(SignCheck(1));
        Console.WriteLine("Передаю -1");
        Console.WriteLine(SignCheck(-1));

        Title("PrintNTimes");
        Console.WriteLine("Передаю \"А\" и 5");
        PrintNTimes("A", 5);

        Title("PrintIntToShort");
        Console.WriteLine("Передаю 2.147.000.000");
        PrintIntToByte(2147000000);

        Title("PrintByteToInt");
        Console.WriteLine("Передаю 1");
        PrintByteToInt(1);

        Title("LeapYearCheck");
        Console.WriteLine("Передаю -46");
        Console.WriteLine(LeapYearCheck(-46));
        Console.WriteLine("Передаю -20");
        Console.WriteLine(LeapYearCheck(-20));
        Console.WriteLine("Передаю 200");
        Console.WriteLine(LeapYearCheck(200));
        Console.WriteLine("Передаю 400");
        Console.WriteLine(LeapYearCheck(400));

        Title("PrintInvertMass");
        int[] a = { 1, 1, 1, 0, 0, 0, 1, 0 };
        PrintMass(a);
        PrintInvertMass(a);
        PrintMass(a);

        Title("InitMass");
        int[] b = new int[10];
        Console.WriteLine("Передаю массив длинной 10");
        InitMass(b);
        PrintMass(b);

        Title("UpgradeMass");
        Console.WriteLine("Передаю массив из предыдущего задания");
        UpgradeMass(b);
        PrintMass(b);

        Title("DiagonallyMass");
        int[,] c = {{ 0,0,0},
                    { 0,0,0},
                    { 0,0,0}};

        PrintMass(c);
        Console.WriteLine();
        DiagonallyMass(c);
        PrintMass(c);

        Title("InitMassWithLengthAndValue");
        Console.WriteLine("Передаю длинну 5 и значение 1");
        int[] d = InitMassWithLengthAndValue(5, 1);
        PrintMass(d);

        Title("PrintMinMax");
        PrintMass(b);
        PrintMinMax(b);

        Title("UnityCheck");
        PrintMass(a);
        Console.WriteLine(UnityCheck(a));

        int[] e = { 10, 1, 1, 1, 1, 1 };
        PrintMass(e);
        Console.WriteLine(UnityCheck(e));

        Title("OffsetMass");
        int[] a1 = new int[10];
        Console.WriteLine("Передаю смещение 3");
        InitMass(a1);       
        PrintMass(a1);        
        OffsetMass(a1, 3);
        PrintMass(a1);
        Console.WriteLine("Передаю смещение -3");
        InitMass(a1);
        PrintMass(a1);
        OffsetMass(a1, -3);
        PrintMass(a1);

        Title("while");
        int num;
        Console.WriteLine("Добро пожаловать в бесконечный цикл.\n" +
            "Я выполняюсь пока мое условие равно true.\n" +
            "Для выхода нажмите 0.\n");
        while (true || 1 == 1)
        {
            Console.WriteLine("Ожидание ввода");
            string? s1 = Console.ReadLine();
            if (s1 != null && int.TryParse(s1, out num) && num == 0)
            {
                break;
            }
        }

        Title("do - while");
        Console.WriteLine("Добро пожаловать в цикл do-while.\n" +
            "Я выполняюсь один раз даже если условие не равно true.\n");
        Console.WriteLine("Предлагаю пользователю авторизоваться.\n" +
                "Для авторизации нажмите 1. Для входа без авторизации 0\n");
        string? s;
        do
        {
            Console.WriteLine("Ожидание ввода");
            s = Console.ReadLine();
            if (s == null)
            {
                continue;
            }
        } while (!int.TryParse(s, out num) || num != 1);

        Console.WriteLine("Поздравляю с авторизацией");
        Console.WriteLine("Работу выполнил Киселев Владислав");
    }
}