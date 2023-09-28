partial class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int v; int _;
        while (true){
            try { v = int.Parse(Console.ReadLine()); break; }
            catch (Exception e) { Console.WriteLine(e) ; }
        }
        Console.WriteLine($"Числа Фибоначчи от 0 до {v}:");
        for (int i = 0; i <= v; i++)
        {
            if (v >= 45) _ = get_fib(i);
            else _ = get_fib_recursive(i);
            Console.WriteLine($"{i}: {_}");
        }
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

}
