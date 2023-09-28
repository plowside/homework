using System;

practice_9 test = new practice_9();
test.task_5();




class practice_1
{
    public void task_1()
    {
        Console.Write("Введите первое число: ");
        int num_1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num_2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Результат [{num_1}+{num_2}] = {num_1+num_2}");
    }

    public void task_2()
    {
        Console.Write("Введите первое число: ");
        double num_1 = double.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num_2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Результат [{num_1}*{num_2}] = {num_1 * num_2}");
    }
    
    public void task_3()
    {
        Console.Write("Введите первое число: ");
        int num_1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num_2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Результат [{num_1}/{num_2}] = {num_1 / num_2}");
    }

    public void task_4()
    {
        int num = 10;
        num++;
        Console.WriteLine(num);
    }

    public void task_5()
    {
        int num = 20;
        num--;
        Console.WriteLine(num);
    }
}

class practice_2
{
    public void task_1()
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Число {num} "+(num == 0 ? "равно нулю" : num >= 0 ? "положительное" : "отрицательное"));
    }

    public void task_2()
    {
        Console.Write("Введите возраст: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine(age >= 18 ? "Добро пожаловать" : "Доступ запрещен");
    }
   
    public void task_3()
    {
        Console.Write("Введите первое число: ");
        int num_1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num_2 = int.Parse(Console.ReadLine());
        Console.WriteLine(num_1 == num_2 ? "Числа равны" : num_1 > num_2 ? "Первое число больше второго" : "Второе число больше первого");
    }

    public void task_4()
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num % 2 == 0 ? "Число четное" : "Число нечетное");
    }

    public void task_5()
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num < 0 ? "Число отрицательное" : num % 5 == 0 ? "Число положительное и кратно 5" : "Число положительное, но не кратно 5");
    }
}

class practice_3
{
    void task_1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void task_2()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void task_3()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        int res = 0;
        for (int i = 1; i <= n; i++)
        {
            res += i;
        }
        Console.WriteLine($"Сумма чисел от 1 до {n}: {res}");
    }

    public void task_4()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n*i);
        }
    }

    public void task_5()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        bool _ = true;
        for (int i = 2;i < n; i++) { if (n % i == 0) {  Console.WriteLine($"Число {n} не простое"); _ = false; break; } }
        if (_) Console.WriteLine($"Число {n} простое");
    }
}

class practice_4
{
    public void fill_array(int[] _)
    {
        Random rand = new Random();
        for (int i = 0; i < _.Length; i++)
        {
            _[i] = rand.Next(100,999);
        }
    }



    public void task_1()
    {
        int[] _ = new int[5];
        fill_array(_);
        Console.WriteLine("[{0}]",String.Join(", ", _));
    }

    public void task_2()
    {
        string[] _ = new string[10];
        for (int i = 0; i < _.Length; i++)
        {
            Console.Write($"Введите значение для элемента [{i}]: ");
            _[i] = Console.ReadLine();
        }
        Console.WriteLine("[{0}]", String.Join(", ", _));
    }

    public void task_3()
    {
        int[] _ = new int[7];
        fill_array(_);
        Console.WriteLine($"Среднее значение элементов массива: {_.Sum()/_.Length}");
    }

    public void task_4()
    {
        int[] _ = new int[6];
        fill_array(_);
        Console.WriteLine($"Наибольшее значение массива: {_.Max()}");
    }

    public void task_5()
    {
        int[] _ = new int[8]; int temp;
        fill_array(_);
        Console.WriteLine("Массив до перестановки: [{0}]", String.Join(", ", _));
        temp = _[0];
        _[0] = _[^1];
        _[^1] = temp;
        Console.WriteLine("Массив после перестановки: [{0}]", String.Join(", ", _));
    }
}

class practice_5
{
    public int sum(int _, int __)
    {
        return _+__;
    }


    public string string_reverse(string _)
    {
        char[] __ = _.ToCharArray();
        Array.Reverse(__);
        return new string(__);
    }


    public void fill_array(int[] _)
    {
        Random rand = new Random();
        for (int i = 0; i < _.Length; i++)
        {
            _[i] = rand.Next(100, 999);
        }
    }

    public void doubling_array(int[] _) {
        for (int i = 0; i < _.Length; i++)
        {
            _[i] *= 2;
        }
    }

    public bool is_simple(int _)
    {
        bool is_s = true;
        for (int i = 2; i < _; i++)
        {
            if (_%i == 0)
            {
                is_s = false;
                break;
            }
        }
        return is_s;
    }


    public int sum_array(params int[] _)
    {
        return _.Sum();
    }



    public void task_1()
    {
        Random rand = new Random();
        int n1 = rand.Next(100, 999);
        int n2 = rand.Next(100, 999);
        Console.WriteLine($"Результат [{n1}+{n2}] = {sum(n1, n2)}");
    }

    public void task_2()
    {
        string str = "Python Топ!";
        Console.WriteLine($"Исходная строка: {str} | Перевернутая: {string_reverse(str)}");
    }

    public void task_3()
    {
        int[] _ = new int[7];
        fill_array(_);
        Console.WriteLine("Массив до удвоения: [{0}]", String.Join(", ", _));
        doubling_array(_);
        Console.WriteLine("Массив после удвоения: [{0}]", String.Join(", ", _));
    }

    public void task_4()
    {
        Console.Write("Введите число: ");
        int _ = int.Parse(Console.ReadLine());
        Console.WriteLine($"Число {_} "+(is_simple(_) ? "простое": "не простое"));
    }

    public void task_5()
    {
        Console.WriteLine($"Сумма элементов массива: {sum_array(5,6,2,2,8,1)}");
    }
}

class practice_6
{
    public int[,] array_fill() {
        Random rand = new Random();
        int[,] _ = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int x = 0; x < 3; x++)
            {
                _[i, x] = rand.Next(10, 99);
            }
        }

        return _;
    }

    public void array_print(int[,] _) {
        int rows = _.GetLength(0);
        int colms = _.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int x = 0; x < colms; x++)
            {
                Console.Write($"{_[i, x]} ");
            }
            Console.WriteLine();
        }
    }


    public int[,] task_1()
    {
        int[,] _ = array_fill();
        array_print(_);
        Console.WriteLine('\n');
        return _;
    }

    public void task_2()
    {
        int[,] _ = task_1();
        int res = 0;
        for (int i = 0; i < _.GetLength(0); i++)
        {
            for (int x = 0; x < _.GetLength(1); x++)
            {
                res += _[i, x];
            }
        }
        Console.WriteLine($"Сумма всех элементов двумерного массива: {res}");
    }

    public void task_3()
    {
        int[,] _ = task_1(); int min;
        for (int i = 0; i < _.GetLength(0); i++)
        {
            min = _[i, 0];
            for (int x = 1; x < _.GetLength(1); x++)
            {
                if (_[i, x] < min) min = _[i, x];
            }

            Console.WriteLine($"Минимальный элемент в строке [{i}]: {min}");
        }
    }

    public void task_4()
    {
        int[,] _ = task_1(); int temp;
        int rows = _.GetLength(0);

        for (int i = 0; i < _.GetLength(1); i++)
        {
            temp = _[0, i];
            _[0, i] = _[rows - 1, i];
            _[rows - 1, i] = temp;
        }
        array_print(_);
    }

    public void task_5()
    {
        int[,] _ = task_1();
        int rows = _.GetLength(0);
        int colms = _.GetLength(1);

        for (int i = 0; i < colms; i++)
        {
            double sum = 0;
            for (int x = 0; x < rows; x++)
            {
                sum += _[i, x];
            }
            Console.WriteLine($"Среднее значение элементов столбца {i}: {sum / rows}");
        }
    }
}

class practice_7
{
    public int[,] array_fill(int from = 1, int to = 16)
    {
        Random rand = new Random();
        int[,] _ = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {
            for (int x = 0; x < 4; x++)
            {
                _[i, x] = rand.Next(from, to);
            }
        }

        return _;
    }

    public void array_print(int[,] _)
    {
        int rows = _.GetLength(0);
        int colms = _.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int x = 0; x < colms; x++)
            {
                Console.Write($"{_[i, x]} ");
            }
            Console.WriteLine();
        }
    }

    public int[,] task_1()
    {
        int[,] _ = array_fill();
        array_print(_);
        Console.WriteLine('\n');
        return _;
    }

    public void task_2()
    {
        int[,] _ = task_1();
        int res = 0;

        for (int i = 0; i < 4; i++)
        {
            res += _[i, i];
        }
        Console.WriteLine($"Сумма элементов главной диагонали: {res}");
    }

    public void task_3()
    {
        int[,] _ = task_1(); int temp;

        for (int i = 0; i < 4; i++)
        {
            temp = _[i, i];
            _[i, i] = _[i, 3 - i];
            _[i, 3 - i] = temp;
        }

        Console.WriteLine("Массив с измененными диагоналями:");
        array_print(_);
    }

    public void task_4()
    {
        int[,] _ = task_1();
        int rows = _.GetLength(0);
 
        int[,] __ = new int[rows, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int x = 0; x < rows; x++)
            {
                __[i, x] = _[rows - 1 - x, i];
            }
        }

        Console.WriteLine("Массив повернутный на 90°:");
        array_print(__);
    }

    public void task_5()
    {
        int[,] _ = task_1();
        int rows = _.GetLength(0);
        int colms = _.GetLength(0);

        int max = _[0, 1]; // assume the maximum value is the first element above the main diagonal

        for (int i = 0; i < rows; i++)
        {
            for (int x = i + 1; x < colms; x++)
            {
                if (_[i, x] > max)
                {
                    max = _[i, x];
                }
            }
        }


        Console.WriteLine($"Максимальное значение элементов, расположенных выше главной диагонали в двумерном массиве: {max}");
    }
}

class practice_8
{
    public int find_spliter(int _, int __)
    {
        while (__ != 0)
        {
            int temp = __;
            __ = _ % __;
            _ = temp;
        }
        return _;
    }

    public long find_factorial(int _)
    {
        if (_ <= 1) return 1;
        long res = 1;

        for (int i = 2; i <= _; i++)
        {
            res *= i;
        }

        return res;

    }


    public void task_1()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine((i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i);
        }
    }

    public void task_2() {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Наибольший общий делитель (НОД) = {find_spliter(num1, num2)}");
    }

    public void task_3()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        bool _ = true;
        for (int i = 2; i < n; i++) { if (n % i == 0) { Console.WriteLine($"Число {n} не простое"); _ = false; break; } }
        if (_) Console.WriteLine($"Число {n} простое");
    }

    public void task_4()
    {
        Console.Write("Введите число: ");
        int _ = int.Parse(Console.ReadLine());
        Console.WriteLine($"Факториал числа {_} = {find_factorial(_)}");
    }
    
    public void task_5()
    {
        Console.Write("Введите длину стороны [A]: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите длину стороны [B]: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите длину стороны [C]: ");
        double c = double.Parse(Console.ReadLine());
        

        Console.WriteLine("Треугольник является {0}", ((a == b && b == c) ? "равносторонний" : (a == b || a == c || b == c) ? "равнобедренный" : "разносторонний"));

    }
}

class practice_9
{
    public long find_factorial(int _)
    {
        if (_ <= 1) return 1;

        return _ * find_factorial(_ - 1);
    }


    public long find_sum(int _)
    {
        if (_ <= 1) return 1;
        
        return _+find_sum(_ - 1);
    }


    public bool is_simple(int _, int spliter = 2)
    {
        if (_ <= 2) return _ == 0;
        else if (_ % spliter == 0) return false;
        else if (spliter * spliter > _) return true;
        
        return is_simple(_, spliter + 1);
    }

    static void find_nums_minus(int _)
    {
        if (_ < 1) return;

        Console.WriteLine(_);
        find_nums_minus(_ - 1);
    }


    static int get_fib_recursive(int _)
    {
        if (_ <= 1) return _;
        else return get_fib_recursive(_ - 1) + get_fib_recursive(_ - 2);
    }

    static int get_fib(int v)
    {
        if (v <= 1) return v;
        int _ = 0; int __ = 1; int res = 0;

        for (int i = 2; i <= v; i++)
        {
            res = _ + __;
            _ = __;
            __ = res;
        }

        return res;
    }




    public void task_1()
    {
        Console.Write("Введите число: ");
        int _ = int.Parse(Console.ReadLine());

        Console.WriteLine($"Факториал числа {_} = {find_factorial(_)}");
    }

    public void task_2()
    {
        Console.Write("Введите число: ");
        int _ = int.Parse(Console.ReadLine());

        Console.WriteLine($"Сумма чисел от 1 до {_} = {find_sum(_)}");
    }

    public void task_3()
    {
        Console.Write("Введите число: ");
        int _ = int.Parse(Console.ReadLine());

        Console.WriteLine("Число {0} {1}", _, (is_simple(_) ? "простое" : "не простое"));
    }

    public void task_4()
    {
        Console.Write("Введите число: ");
        int _ = int.Parse(Console.ReadLine());

        Console.WriteLine($"Все числа от {_} до 1 (в порядке убывания):");
        find_nums_minus(_);
    }

    public void task_5()
    {
        Console.Write("Введите число: ");
        int v; int _;
        v = int.Parse(Console.ReadLine());
        Console.WriteLine($"Числа фибонигер от 0 до {v}:");
        for (int i = 0; i <= v; i++)
        {
            if (v >= 42) _ = get_fib(i);
            else _ = get_fib_recursive(i);
            Console.WriteLine($"{i}: {_}");
        }
    }
}
