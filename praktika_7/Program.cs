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
        static bool NextSet(ref int[] arr, int n, int k)
        {
            int j = k - 1;
            while (j >= 0 && arr[j] == n) j--;
            if (j < 0) return false;
            if (arr[j] >= n)
                j--;
            arr[j]++;
            if (j == k - 1) return true;
            for (int i = j + 1; i < k; i++)
                arr[i] = arr[j];
            return true;
        }

        static void Print(int[] arr, int k)
        {
            Console.Write($"{num++}: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = InputNumber("Введите число N: ");
            int k = InputNumber("Введите число K: ");
            int[] arr = new int[k];
            for (int i = 0; i < k; i++)
                arr[i] = 1;
            Print(arr, k);
            while (NextSet(ref arr, n, k))
                Print(arr, k);
            Console.ReadKey();
        }
    }
}
