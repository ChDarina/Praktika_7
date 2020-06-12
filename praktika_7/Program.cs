using System;

namespace praktika_7
{
    class Program
    {
        static public int InputNumber(string ForUser, int left=0, int right=100)
        {
            bool ok = true;
            int number = 0;
            do
            {
                Console.WriteLine(ForUser);
                try
                {
                    string buf = Console.ReadLine();
                    number = Convert.ToInt32(buf);
                    if (number >= left && number <= right) ok = false;
                    else
                    {
                        Console.WriteLine("Введите число от {0} до {1}!", left, right);
                    }
                }
                catch
                {
                    Console.WriteLine("Неверный ввод числа!");
                }
            } while (ok);
            return number;
        }
        static int num = 1;
        static bool NextSet(int[] mas, int n, int m)
        {
            int j = m - 1;
            while (j >= 0 && mas[j] == n) j--;

            if (j < 0) return false;

            if (mas[j] >= n)
            {
                j--;
            }

            mas[j]++;
            if (j == m - 1) return true;

            for (int k = j + 1; k < m; k++)
            {
                mas[k] = mas[j];
            }

            return true;
        }

        static void Print(int[] mas, int n)
        {
            Console.Write($"{num++}: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = InputNumber("Введите число N: ");
            int k = InputNumber("Введите число K: ");
            int h = (n > k) ? n : k;
            int[] arr = new int[h];
            for (int i = 0; i < h; i++)
                arr[i] = 1;
            Print(arr, k);
            while (NextSet(arr, n, k))
                Print(arr, k);
            Console.ReadKey();
        }
    }
}
