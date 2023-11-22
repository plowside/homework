int[,] array_fill(int from = 1, int to = 16, int s_1 = 5, int s_2 = 10)
{
    Random rand = new Random();
    int[,] _ = new int[s_1, s_2];

    for (int i = 0; i < s_1; i++)
    {
        for (int x = 0; x < s_2; x++)
        {
            _[i, x] = rand.Next(from, to);
        }
    }

    return _;
}

void array_print(int[,] _)
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



void task_1(int k, int[,] matrix)
{
    int sum = 0;
    int pr = 1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, k - 1];
        pr *= matrix[i, k - 1];
    }

    Console.WriteLine($"Сумма элементов {k}-го столбца: {sum}\nПроизведение элементов {k}-го столбца: {pr}");

}

void task_2(int[,] matrix)
{
    int sum_row_chet = 0;
    int sum_row_nechet = 0;
    int sum_col_chet = 0;
    int sum_col_nechet = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0)
            {
                sum_row_chet += matrix[i, j];
            }
            else
            {
                sum_row_nechet += matrix[i, j];
            }

            if (j % 2 == 0)
            {
                sum_col_chet += matrix[i, j];
            }
            else
            {
                sum_col_nechet += matrix[i, j];
            }
        }
    }

    Console.WriteLine($"Сумма элементов всех четных строк: {sum_row_chet}\nСумма элементов всех нечетных строк: {sum_row_nechet}\nСумма элементов всех четных столбцов: {sum_col_chet}\nСумма элементов всех нечетных столбцов: {sum_col_nechet}");
}

void task_3(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        var min = matrix[i, 0];
        var max = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) min = matrix[i, j];
            else if (matrix[i, j] > max) max = matrix[i, j];
        }
        Console.WriteLine($"Минимальное значение [{i}]: {min}\nМаксимальное значение [{i}]: {max}");
    }

}

void task_4(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        List<int> result = new List<int>();
        var avg = 0;

        for (int j = 0; j < matrix.GetLength(1); j++) avg += matrix[i, j];
        avg /= matrix.GetLength(1);

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > avg) result.Add(matrix[i, j]);
        }

        var _ = string.Join(", ", result.ToArray());
        Console.WriteLine($"[{i}] | Кол-во элементов > {avg} = {result.Count}  ---->   [{_}]");
    }

}

void task_5(int[,] matrix)
{
    Console.WriteLine("Массив до изменения:");
    array_print(matrix);
    Console.WriteLine("\n");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        var min_i = 0;
        var max_i = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[i, min_i]) min_i = j;
            else if (matrix[i, j] > matrix[i, max_i]) max_i = j;
        }
        var _ = matrix[i, min_i];
        Console.WriteLine($"[{i}] | Перемещенные элементы [{min_i}|{max_i}]: {_} => {matrix[i, max_i]} | {matrix[i, max_i]} => {_}");
        
        matrix[i, min_i] = matrix[i, max_i];
        matrix[i, max_i] = _;
    }
    Console.WriteLine("\n\nМассив после изменения:");
    array_print(matrix);
}

void task_6(int[,] matrix)
{
    List<int> sums = new List<int>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        var sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
        sums.Add(sum);
    }
    var _ = string.Join(", ", sums.ToArray());
    Console.WriteLine($"Все суммы элементов: [{_}]\nМаксимальное|Минимальное значение из всех сумм: {sums.Max()} | {sums.Min()}\nИх индексы: {sums.IndexOf(sums.Max())} | {sums.IndexOf(sums.Min())}");
}

void task_7(int[,] matrix)
{
    List<int> els = new List<int>();
    List<int> els_max = new List<int>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        var min = matrix[i, 0];
        var max = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) min = matrix[i, j];
            else if (matrix[i, j] > max) max = matrix[i, j];
        }
        els.Add(min);
        els_max.Add(max);
    }
    var _ = string.Join(", ", els.ToArray());
    var __ = string.Join(", ", els_max.ToArray());

    Console.WriteLine($"Все элементы минимальных: [{_}]\nВсе элементы максимальных: [{__}]\nМаксимальное|Минимальное значение из всех минимальных элементов: {els.Max()} | {els.Min()}\nИх индексы: {els.IndexOf(els.Max())} | {els.IndexOf(els.Min())}\nМаксимальное|Минимальное значение из всех максимальных элементов: {els_max.Max()} | {els_max.Min()}\nИх индексы: {els_max.IndexOf(els_max.Max())} | {els_max.IndexOf(els_max.Min())}");
}

//task_1(2, array_fill(3, 9, 4, 10)); //{{1, 2, 3, 4, 5, 6, 7, 8, 9, 10},{11, 12, 13, 14, 15, 16, 17, 18, 19, 20},{21, 22, 23, 24, 25, 26, 27, 28, 29, 30},{31, 32, 33, 34, 35, 36, 37, 38, 39, 40}}
//task_2(array_fill(4, 16, 5, 9)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_3(array_fill(20, 215, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_4(array_fill(1, 60, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_5(array_fill(1, 60, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_6(array_fill(1, 60, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
task_7(array_fill(1, 60, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }