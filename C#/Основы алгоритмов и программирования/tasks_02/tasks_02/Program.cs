using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;

void task_1(object[] N)
{
    Array.Reverse(N);
    for (int i = 0; i < N.Length; i++)
    {
        Console.WriteLine($"{i}: {N[i]}");
    }
}

void task_2(double[] N)
{
    Console.WriteLine("[0-0] Элементы с четными:");
    for (int i = 0; i < N.Length; i++)
    {
        if (i % 2 == 0) Console.WriteLine(N[i]);
    }
    Console.WriteLine("[0-1] Элементы с нечетными:");
    for (int i = 0; i < N.Length; i++)
    {
        if (i % 2 != 0) Console.WriteLine(N[i]);
    }
    Console.WriteLine("\n\n");
    Console.WriteLine("[1-0] Элементы с нечетными:");
    for (int i = 0; i < N.Length; i++)
    {
        if (i % 2 != 0) Console.WriteLine(N[i]);
    }
    Console.WriteLine("[1-1] Элементы с четными:");
    for (int i = 0; i < N.Length; i++)
    {
        if (i % 2 == 0) Console.WriteLine(N[i]);
    }
}

void task_3(int[] arr_A)
{
    int last = 0;
    bool is_logged = false;
    for (int i = 0; i < arr_A.Length; i++)
    {
        if (arr_A[1] < arr_A[i] && arr_A[i] < arr_A[^1])
        {
            last = arr_A[i];
            if (is_logged is false) Console.WriteLine($"Первый найденный элемент: {last}"); is_logged = true;
        }
    }
    Console.WriteLine($"Последний найденный элемент: {last}");
}

void task_4(int[] arr)
{
    int[] arr_temp = new int[arr.Length];
    arr.CopyTo(arr_temp, 0);
    Console.WriteLine("[0] Вариант с четными:");
    int to_add = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) arr[i] += to_add;
    }
    Console.WriteLine("[{0}]", string.Join(",", arr));
    Console.WriteLine("\n\n");

    arr_temp.CopyTo(arr, 0);
    to_add = arr[^1];
    Console.WriteLine("[1] Вариант с нечетными:");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) arr[i] += to_add;
    }
    Console.WriteLine("[{0}]}", string.Join(",", arr));
}


void task_5(int[] N)
{
    Console.WriteLine("[0-0] Элементы четные:");
    for (int i = 0; i < N.Length; i++)
    {
        if (N[i] % 2 == 0) Console.WriteLine(N[i]);
    }
    Console.WriteLine("[0-1] Элементы нечетные:");
    for (int i = 0; i < N.Length; i++)
    {
        if (N[i] % 2 != 0) Console.WriteLine(N[i]);
    }
    Console.WriteLine("\n\n");
    Console.WriteLine("[1-0] Элементы нечетные:");
    for (int i = 0; i < N.Length; i++)
    {
        if (N[i] % 2 != 0) Console.WriteLine(N[i]);
    }
    Console.WriteLine("[1-1] Элементы четные:");
    for (int i = 0; i < N.Length; i++)
    {
        if (N[i] % 2 == 0) Console.WriteLine(N[i]);
    }
}

void task_6(int[] N)
{
    Console.WriteLine("Массив до изменения:");
    Console.WriteLine("[{0}]", string.Join(",", N));
    int temp = N[0];
    N[0] = N[^1];
    N[^1] = temp;
    Console.WriteLine("Массив после изменения");
    Console.WriteLine("[{0}]", string.Join(",", N));
}

void task_7(int[] N)
{
    int min = N.Min();
    int max = N.Max();
    int[] arr_temp = new int[N.Length];
    N.CopyTo(arr_temp, 0);
    Console.WriteLine("[0] Массив до изменения:");
    Console.WriteLine("[{0}]", string.Join(",", N));
    for (int i = 0; i < N.Length; i++)
    {
        N[i] = min;
    }
    Console.WriteLine("[0] Массив после изменения");
    Console.WriteLine("[{0}]", string.Join(",", N));
    Console.WriteLine("\n\n");
    arr_temp.CopyTo(N, 0);
    Console.WriteLine("[1] Массив до изменения:");
    Console.WriteLine("[{0}]", string.Join(",", N));
    for (int i = 0; i < N.Length; i++)
    {
        N[i] = max;
    }
    Console.WriteLine("[1] Массив после изменения");
    Console.WriteLine("[{0}]", string.Join(",", N));
}

void task_8(int[] N)
{
    int min = Array.FindLastIndex(N, w => w == N.Min());
    int max = Array.FindLastIndex(N, w => w == N.Max());
    int[] arr_N = new int[N.Length];
    N.CopyTo(arr_N, 0);
    int _;
    int limiter;
    if (min > max)
    {
        _ = max + 1;
        limiter = min;
    }
    else
    {
        _ = min + 1;
        limiter = max;
    }
    Console.WriteLine($"Массив до изменения [{_}|{limiter}]:");
    Console.WriteLine("[{0}]", string.Join(",", N));
    for (int i = _; i < limiter; i++)
    {
        if (min > max) N[i] = arr_N[min - i];
        else N[i] = arr_N[max - i];
    }
    Console.WriteLine("Массив после изменения");
    Console.WriteLine("[{0}]", string.Join(",", N));
}

void task_9(int[] N)
{
    int[] arr_N = new int[N.Length];
    N.CopyTo(arr_N, 0);
    Console.WriteLine($"[0] Массив до изменения:");
    Console.WriteLine("[{0}]", string.Join(",", N));

    for (int i = 0; i < N.Length; i++)
    {
        try { N[i + 1] = arr_N[i]; }
        catch { N[0] = arr_N[i]; }
    }
    Console.WriteLine("[0] Массив после изменения");
    Console.WriteLine("[{0}]", string.Join(",", N));

    arr_N.CopyTo(N, 0);
    Console.WriteLine($"[1] Массив до изменения:");
    Console.WriteLine("[{0}]", string.Join(",", N));

    for (int i = 0; i < N.Length; i++)
    {
        try { N[i - 1] = arr_N[i]; }
        catch { N[^1] = arr_N[i]; }
    }
    Console.WriteLine("[1] Массив после изменения");
    Console.WriteLine("[{0}]", string.Join(",", N));
}

void task_10(int[] N, int k)
{
    int[] arr_N = new int[N.Length];
    N.CopyTo(arr_N, 0);
    Console.WriteLine($"[0] Массив до изменения:");
    Console.WriteLine("[{0}]", string.Join(",", N));

    int n = arr_N.Length;
    int[] temp = new int[k];
    for (int i = 0; i < k; i++)
    {
        temp[i] = arr_N[i];
    }

    for (int i = k; i < n; i++)
    {
        arr_N[i - k] = arr_N[i];
    }

    for (int i = 0; i < k; i++)
    {
        arr_N[n - k + i] = temp[i];
    }
    Console.WriteLine("[0] Массив после изменения");
    Console.WriteLine("[{0}]", string.Join(",", arr_N));

    N.CopyTo(arr_N, 0);
    Console.WriteLine($"\n\n[1] Массив до изменения:");
    Console.WriteLine("[{0}]", string.Join(",", arr_N));

    int n2 = arr_N.Length;
    int[] temp2 = new int[k];

    for (int i = 0; i < k; i++)
    {
        temp2[i] = arr_N[n2 - k + i];
    }

    for (int i = n2 - 1; i >= k; i--)
    {
        arr_N[i] = arr_N[i - k];
    }

    for (int i = 0; i < k; i++)
    {
        arr_N[i] = temp2[i];
    }


    Console.WriteLine("[1] Массив после изменения");
    Console.WriteLine("[{0}]", string.Join(",", arr_N));
}


void task_11(int[] N, double R)
{
    int result = 0;

    double min = Math.Abs(N[0] - R);
    double max = Math.Abs(N[0] - R);
    int min_i = 0;
    int max_i = 0;

    for (int i = 0; i < N.Length; i++)
    {
        double diff = Math.Abs(N[i] - R);

        if (diff < Math.Abs(min - R))
        {
            min = N[i];
            min_i = i;
        }

        if (diff > Math.Abs(max - R))
        {
            max = N[i];
            max_i = i;
        }
    }

    Console.WriteLine($"Цель: {R}\nНаиболее близкое число: {min} | {min_i}\nНаименее близкое число: {max} | {max_i}");
}




void task_12(int[] N, double R)
{
    int result = 0;

    double min = Math.Abs(N[0] + N[1] - R);
    double max = Math.Abs(N[0] + N[1] - R);
    int min_i1 = 0;
    int min_i2 = 0;
    int max_i1 = 0;
    int max_i2 = 0;

    for (int i = 0; i < N.Length - 1; i++)
    {
        double diff = Math.Abs((N[i] + N[i + 1]) - R);
        if (diff < Math.Abs(min - R))
        {

            min = N[i] + N[i + 1];
            min_i1 = i;
            min_i2 = i + 1;
        }
        else if (diff > Math.Abs(max - R))
        {
            max = N[i] + N[i + 1];
            max_i1 = i;
            max_i2 = i + 1;
        }
    }

    Console.WriteLine($"Цель: {R}\nНаиболее близкое число: {N[min_i1]} + {N[min_i2]} = {min}\nНаименее близкое число: {N[max_i1]} + {N[max_i2]} = {max}");
}


void task_13(int[] N)
{
    double result = Math.Abs(N[0] - N[1]);
    int i1 = 0;
    int i2 = 0;

    for (int i = 0; i < N.Length - 1; i++)
    {
        double diff = Math.Abs(N[i] - N[i + 1]);
        if (diff < result)
        {
            result = Math.Abs(N[i] - N[i + 1]);
            i1 = i;
            i2 = i + 1;
        }
    }

    Console.WriteLine($"Разница чисел: {result}\nИндексы: {i1} | {i2}\nЧисла: {N[i1]} | {N[i2]}");

}

void task_14(int[] N)
{
    int result = 0;
    var repeated = new List<int>();

    foreach (int num in N)
    {

        if (repeated.Contains(num))
        {
            result++;
            repeated.Add(num);
        }
        else
        {
            repeated.Add(num);
        }
    }

    Console.WriteLine($"Кол-во повторяющихся элементов: {result}");
}

void task_15(int[] arr)
{
    var repeated = new Dictionary<int, int>();

    foreach (int num in arr)
    {
        if (repeated.ContainsKey(num)) repeated[num]++;
        else repeated[num] = 1;
    }

    if (true)
    {
        var result = new List<int>();
        foreach (int num in arr)
        {
            if (repeated[num] < 2)
            {
                result.Add(num);
            }
        }

        Console.WriteLine("[0] До изменений: {0}", string.Join(", ", arr));
        Console.WriteLine("[0] После удаления [num<2]: {0}", string.Join(", ", result));
    }
    if (true)
    {
        var result = new List<int>();
        foreach (int num in arr)
        {
            if (repeated[num] > 2)
            {
                result.Add(num);
            }
        }

        Console.WriteLine("\n[1] До изменений: {0}", string.Join(", ", arr));
        Console.WriteLine("[1] После удаления [num>2]: {0}", string.Join(", ", result));
    }
    if (true)
    {
        var result = new List<int>();
        foreach (int num in arr)
        {
            if (repeated[num] == 2)
            {
                result.Add(num);
            }
        }

        Console.WriteLine("\n[2] До изменений: {0}", string.Join(", ", arr));
        Console.WriteLine("[2] После удаления [num==2]: {0}", string.Join(", ", result));
    }
    if (true)
    {
        var result = new List<int>();
        foreach (int num in arr)
        {
            if (repeated[num] == 3)
            {
                result.Add(num);
            }
        }

        Console.WriteLine("\n[3] До изменений: {0}", string.Join(", ", arr));
        Console.WriteLine("[3] После удаления [num==3]: {0}", string.Join(", ", result));
    }
}



void task_16(int[] arrMain)
{
    Console.WriteLine("До изменения: {0}", string.Join(", ", arrMain));

    int[] result_1 = new int[arrMain.Length * 2];
    int[] result_2 = new int[arrMain.Length * 2];
    int[] result_3 = new int[arrMain.Length * 2];
    int[] result_4 = new int[arrMain.Length * 2];

    for (int i = 0, j = 0; i < arrMain.Length; i++, j += 2)
    {
        if (arrMain[i] > 0)
        {
            result_1[j] = arrMain[0];
            result_1[j + 1] = arrMain[i];
            result_2[j] = arrMain[i];
            result_2[j + 1] = arrMain[0];
        }
        else if (arrMain[i] < 0)
        {
            result_3[j] = arrMain[i];
            result_3[j + 1] = arrMain[0];
            result_4[j] = arrMain[i];
            result_4[j + 1] = arrMain[0];
        }
    }

    Console.WriteLine("\n\nПосле изменения[1]: {0}", string.Join(", ", result_1));
    Console.WriteLine("\n\nПосле изменения[2]: {0}", string.Join(", ", result_2));
    Console.WriteLine("\n\nПосле изменения[3]: {0}", string.Join(", ", result_3));
    Console.WriteLine("\n\nПосле изменения[4]: {0}", string.Join(", ", result_4));
}

void task_17(int[] arr_1, int[] arr_2)
{
    int[] result = new int[arr_1.Length + arr_2.Length];

    for (int i = 0; i < arr_1.Length; i++)
    {
        result[i] = arr_1[i];
    }

    for (int i = arr_1.Length; i - arr_1.Length < arr_2.Length; i++)
    {
        result[i] = arr_2[i - arr_1.Length];
    }



    Console.WriteLine("Массив: {0}", string.Join(", ", result));
    Array.Sort(result);
    Console.WriteLine("\n\nСортировка по возрастанию[0]: {0}", string.Join(", ", result));
    Array.Reverse(result);
    Console.WriteLine("\nСортировка по убыванию[1]: {0}", string.Join(", ", result));
}

void task_18(int[] arr)
{
    Console.WriteLine("Массив: {0}", string.Join(", ", arr));
    Array.Sort(arr);
    Console.WriteLine("\n\nСортировка по возрастанию[0]: {0}", string.Join(", ", arr));
    Array.Reverse(arr);
    Console.WriteLine("\nСортировка по убыванию[1]: {0}", string.Join(", ", arr));
}

void task_19(int[] N, double R)
{
    int result = 0;

    double min = Math.Abs(N[0] - R);
    double max = Math.Abs(N[0] - R);
    int min_i = 0;
    int max_i = 0;

    for (int i = 0; i < N.Length; i++)
    {
        double diff = Math.Abs(N[i] - R);

        if (diff < Math.Abs(min - R))
        {
            min = N[i];
            min_i = i;
        }

        if (diff > Math.Abs(max - R))
        {
            max = N[i];
            max_i = i;
        }
    }

    Console.WriteLine($"Цель: {R}\nНаиболее близкое число: {min} | Индекс: {min_i}\nНаименее близкое число: {max} | Индекс: {max_i}");
}



task_19(new int[] { 6, 43, 8945, 82, 5, 2, 934 }, 60);