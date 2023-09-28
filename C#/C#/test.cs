void Main()
{
    Console.Write("������� �����: ");
    int v; int _ = 0; DateTime start;
	while (true)
    {
        try { v = int.Parse(Console.ReadLine()); break; }
        catch (Exception e) { Console.WriteLine(e); }
    }
    Console.WriteLine($"����� ��������� �� 0 �� {v}:");
	start = DateTime.Now;
	for (int i = 0; i <= v; i++)
	{
		_ = get_fib(i);
	}
	Console.WriteLine($"����� �� ��������� ������: {DateTime.Now - start} | ���������: {_}");

	start = DateTime.Now;
    for (int i = 0; i <= v; i++)
    {
        _ = get_fib_recursive(i);
    }
    Console.WriteLine($"����� �� ��������� ���������: {DateTime.Now - start} | ���������: {_}");
}


int get_fib_recursive(int _)
{
    if (_ <= 1) return _;
    else return get_fib_recursive(_ - 1) + get_fib_recursive(_ - 2);
}

int get_fib(int v)
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

Main();