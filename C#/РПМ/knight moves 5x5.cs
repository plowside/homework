using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using System.Runtime.Serialization;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            find_result();
            Console.ReadKey();
        }
    }

    static void find_result()
    {
        int start = 0;
        while (true)
        {
            start++;
            int size = 25;
            int[,] board = new int[size, size];

            Random random = new Random();
            int start_g = random.Next(size);
            int start_v = random.Next(size);

            int moves_count = move_(board, start_g, start_v);
            if (moves_count == size*size)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int x = 0; x < size; x++) Console.Write(board[i, x] + "\t");
                    Console.WriteLine();
                }
                Console.WriteLine($"Решение найдено на попытке №{start} | Ходы: {moves_count}");
                break;
            }
        }
    }

    static int move_(int[,] board, int g, int v)
    {
        int size = board.GetLength(0);
        int moves_count = 1;
        int cur_g = g;
        int cur_v = v;

        int[] g_ = { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] v_ = { 1, 2, 2, 1, -1, -2, -2, -1 };

        board[cur_g, cur_v] = moves_count;
        Random rand = new Random();
        while (moves_count < size * size)
        {
            List<Tuple<int, int>> can_move_l = gen_move(board, cur_g, cur_v, size, g_, v_);

            if (can_move_l.Count == 0) break;
            
            Tuple<int, int> next_move = next_move_get(can_move_l, board, size);
            cur_g = next_move.Item1;
            cur_v = next_move.Item2;
            moves_count++;
            board[cur_g, cur_v] = moves_count;
        }
        return moves_count;
    }

    static List<Tuple<int, int>> gen_move(int[,] board, int g, int v, int size, int[] move_g, int[] move_v)
    {
        List<Tuple<int, int>> moves = new List<Tuple<int, int>>();

        for (int i = 0; i < move_g.Length; i++)
        {
            int g_ = g + move_g[i];
            int v_ = v + move_v[i];

            if (is_move(board, g_, v_, size))
            {
                moves.Add(new Tuple<int, int>(g_, v_));
            }
        }

        return moves;
    }

    static bool is_move(int[,] board, int g, int v, int size)
    {
        return g >= 0 && g < size && v >= 0 && v < size && board[g, v] == 0;
    }

    static Tuple<int, int> next_move_get(List<Tuple<int, int>> moves, int[,] board, int size)
    {
        moves.Sort((_, __) =>
        {
            int res_1 = gen_move(board, _.Item1, _.Item2, size, new[] { 2, 1, -1, -2, -2, -1, 1, 2 }, new[] { 1, 2, 2, 1, -1, -2, -2, -1 }).Count;
            int res_2 = gen_move(board, __.Item1, __.Item2, size, new[] { 2, 1, -1, -2, -2, -1, 1, 2 }, new[] { 1, 2, 2, 1, -1, -2, -2, -1 }).Count;
            return res_1.CompareTo(res_2);    
        });

        return moves[0];
    }

}
