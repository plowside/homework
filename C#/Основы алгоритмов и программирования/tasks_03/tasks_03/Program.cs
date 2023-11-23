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

    Console.WriteLine($"Сумма элементов всех четных столбцов: {sum_row_chet}\nСумма элементов всех нечетных столбцов: {sum_row_nechet}\nСумма элементов всех четных столбцов: {sum_col_chet}\nСумма элементов всех нечетных столбцов: {sum_col_nechet}");
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
            if (matrix[i, j] > max) max = matrix[i, j];
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
            if (matrix[i, j] > matrix[i, max_i]) max_i = j;
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
            if (matrix[i, j] > max) max = matrix[i, j];
        }
        els.Add(min);
        els_max.Add(max);
    }
    var _ = string.Join(", ", els.ToArray());
    var __ = string.Join(", ", els_max.ToArray());

    Console.WriteLine($"Все элементы минимальных: [{_}]\nВсе элементы максимальных: [{__}]\nМаксимальное|Минимальное значение из всех минимальных элементов: {els.Max()} | {els.Min()}\nИх индексы: {els.IndexOf(els.Max())} | {els.IndexOf(els.Min())}\nМаксимальное|Минимальное значение из всех максимальных элементов: {els_max.Max()} | {els_max.Min()}\nИх индексы: {els_max.IndexOf(els_max.Max())} | {els_max.IndexOf(els_max.Min())}");
}

void task_8(int[,] matrix)
{
    int result = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        var v_p = 0;
        var v_m = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > 0) v_p++;
            if (matrix[i, j] < 0) v_m++;
        }
        if (v_p == v_m & v_p != 0 & v_m != 0) { result = i; break; }
    }

    Console.WriteLine($"Индекс столбцови с одинаковым кол-вом элементов положительных и отрицательных чисел: {result}");
}

void task_9(int[,] matrix)
{
    int result = 0;
    array_print(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        var p = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 0)
            {
                result = 0;
                break;
            }
            else p++;
        }
        if (p == matrix.GetLength(1))
        {
            result = i;
            break;
        }
    }

    Console.WriteLine($"Индекс столбцови с только положительными элементами: {result}");
}

void task_10(int[,] matrix)
{
    //array_print(matrix);
    var result = 0;
    int[] to_equal = new int[matrix.GetLength(1)];
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) to_equal[j] = matrix[i, j];
    }
    
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        var is_passed = true;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[0, j] != matrix[i, j]) is_passed = false;
        }
        if (is_passed) result++;
    }

    Console.WriteLine("Кол-во столбцов похожих на [{0}]: {1}", String.Join(", ", to_equal), result);
}

void task_11(int[,] matrix)
{
    array_print(matrix);
    var result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        var is_passed = true;
        List<int> temp = new List<int>();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (temp.Contains(matrix[i, j]) == true) is_passed = false;
            temp.Add(matrix[i, j]);
        }
        if (is_passed) result++;
    }

    Console.WriteLine($"Кол-во столбцов элементы в которых не повторяются: {result}");
}

void task_12(int[,] matrix)
{
    var result = 0;
    array_print(matrix);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Dictionary<int, int> repeats = new Dictionary<int, int>();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (repeats.ContainsKey(matrix[i, j])) repeats[matrix[i, j]]++;
            else repeats[matrix[i, j]] = 1;
        }
        if (repeats.Values.Max() > result) result = i;
    }

    Console.WriteLine($"Индекс столбца с максимальным кол-вом повторяющихся элементов: {result}");
}

void task_13(int[,] matrix)
{
    array_print(matrix);
    var m_l0 = matrix.GetLength(0);

    var result_main = 0;
    var result_adt = 0;
    for (int i = 0; i < m_l0; i++)
    {
        result_main += matrix[i, i];
        result_adt += matrix[i, m_l0 - 1 - i];
    }

    Console.WriteLine($"Сумма элементов (главной диагонали: {result_main}) | (побочной диагонали: {result_adt})");
}

void task_14(int[,] matrix)
{
    array_print(matrix);
    var m_l0 = matrix.GetLength(0);
    for (int x = 1 - m_l0; x < m_l0; x++)
    {
        var result = 0;
        var result_adt = 0;

        for (int i = 0; i < m_l0; i++)
        {
            var j = i + x;
            if (j >= 0 && j < m_l0) result += matrix[i, j];
            j = m_l0 - 1 - i + x;
            if (j >= 0 && j < m_l0) result_adt += matrix[i, j];
        }

        Console.WriteLine($"Сумма элементов диагонали [{x}] (параллельной главной: {result}) | (параллельной побочной: {result_adt})");
    }
}

void task_15(int[,] matrix)
{
    array_print(matrix);
    var m_l0 = matrix.GetLength(0);
    
    for (int x = 1 - m_l0; x < m_l0; x++)
    {
        var min_el_main = int.MaxValue;
        var min_el_adt = int.MaxValue;
        var max_el_main = int.MinValue;
        var max_el_adt = int.MinValue;

        for (int i = 0; i < m_l0; i++)
        {
            var j = i + x;
            if (j >= 0 && j < m_l0)
            {
                var el = matrix[i, j];
                if (min_el_main > el) min_el_main = el;
                if (max_el_main < el) max_el_main = el;
            }

            j = m_l0 - 1 - i + x;
            if (j >= 0 && j < m_l0)
            {
                var el = matrix[i, j];
                if (min_el_adt > el) min_el_adt = el;
                if (max_el_adt < el) max_el_adt = el;
            }
        }

        Console.WriteLine($"Минимальный | Максимальный элемент диагонали [{x}] (параллельной главной: {min_el_main} | {max_el_main}) | (параллельной побочной: {min_el_adt} | {max_el_adt})");
    }
}

void task_16(int[,] matrix)
{
    Console.WriteLine("До изменений:");
    array_print(matrix);
    var m_l0 = matrix.GetLength(0);

    // ниже главной
    int[,] temp = (int[,])matrix.Clone();
    for (int i = 0; i < m_l0; i++)
    {
        for (int j = i + 1; j < m_l0; j++) temp[j, i] = 0;
    }
    Console.WriteLine("\n\nНиже главной диагонали:");
    array_print(temp);


    // выше главной
    temp = (int[,])matrix.Clone();
    for (int i = 0; i < m_l0; i++)
    {
        for (int j = 0; j < i; j++) temp[j, i] = 0;
    }
    Console.WriteLine("\nВыше главной диагонали:");
    array_print(temp);


    // ниже побочной
    temp = (int[,])matrix.Clone();
    for (int i = 0; i < m_l0; i++)
    {
        for (int j = 0; j < m_l0; j++)
        {
            if (i > j)
            {
                temp[i, j] = 0;
            }
        }
    }
    // Почему-то не так работает
    //for (int i = 0; i < m_l0; i++)
    //{
    //    for (int j = 0; j < m_l0 - 1 - i; j++)
    //    {
    //        temp[j, m_l0 - 1 - i] = 0;
    //    }
    //}
    Console.WriteLine("\nНиже побочной диагонали:");
    array_print(temp);

    // выше побочной
    temp = (int[,])matrix.Clone();
    for (int i = 0; i < m_l0; i++)
    {
        for (int j = 0; j < m_l0; j++)
        {
            if (i < j)
            {
                temp[i, j] = 0;
            }
        }
    }
    // Почему-то не так работает
    //for (int i = 0; i < m_l0; i++)
    //{
    //    for (int j = m_l0 - i; j < m_l0; j++)
    //    {
    //        temp[j, m_l0 - 1 - i] = 0;
    //    }
    //}
    Console.WriteLine("\nВыше побочной диагонали:");
    array_print(temp);
}

//task_1(2, array_fill(3, 9, 4, 10)); //{{1, 2, 3, 4, 5, 6, 7, 8, 9, 10},{11, 12, 13, 14, 15, 16, 17, 18, 19, 20},{21, 22, 23, 24, 25, 26, 27, 28, 29, 30},{31, 32, 33, 34, 35, 36, 37, 38, 39, 40}}
//task_2(array_fill(4, 16, 5, 9)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_3(array_fill(20, 215, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_4(array_fill(1, 60, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_5(array_fill(1, 60, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_6(array_fill(1, 60, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_7(array_fill(1, 60, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_8(array_fill(-1, 2, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_9(array_fill(-1, 25, 5, 10)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_10(array_fill(1, 3, 50, 3)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_11(array_fill(1, 4, 10, 3)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_12(array_fill(2, 9, 10, 6)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_13(array_fill(2, 9, 5, 5)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
//task_14(array_fill(2, 9, 5, 5)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }
task_16(array_fill(2, 9, 3, 3)); //{ { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 10, 141, 12, 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24, 25, 26, 27 }, { 28, 29, 30, 31, 32, 33, 34, 35, 36 }, { 37, 38, 39, 40, 41, 42, 43, 44, 45 } }