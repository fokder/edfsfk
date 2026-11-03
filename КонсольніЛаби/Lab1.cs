using System;

namespace Lab1
{
    class Program
    {
        // Ліва частина — перші n / 2 стовпців квадратної матриці.
        // Для непарного n центральний стовпець не враховується.

        static bool ReadElement(int[,] matrix, int row, int column, out int value)
        {
            value = 0;
            int n = matrix.GetLength(0);
            if (row < 0 || row >= n || column < 0 || column >= n) return false;
            value = matrix[row, column];
            return true;
        }

        static bool WriteElement(int[,] matrix, int row, int column, int value)
        {
            int n = matrix.GetLength(0);
            if (row < 0 || row >= n || column < 0 || column >= n) return false;
            matrix[row, column] = value;
            return true;
        }

        static int[,] FindZeros(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int count = 0;
            // Спочатку рахуємо нулі в лівій половині.
            for (int row = 0; row < n; row++)
                for (int column = 0; column < n / 2; column++)
                    if (matrix[row, column] == 0) count++;

            // Зберігаємо лише координати нулів, а не їхні однакові значення.
            // У кожному рядку: номер рядка та номер стовпця знайденого нуля.
            int[,] zeros = new int[count, 2];
            int k = 0;
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n / 2; column++)
                {
                    if (matrix[row, column] == 0)
                    {
                        zeros[k, 0] = row;
                        zeros[k, 1] = column;
                        k++;
                    }
                }
            }
            return zeros;
        }

        static void ShowMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    int value;
                    ReadElement(matrix, row, column, out value);
                    Console.Write(value + "\t");
                }
                Console.WriteLine();
            }
        }

        static void ShowZeros(int[,] matrix)
        {
            int[,] zeros = FindZeros(matrix);
            Console.WriteLine("Кількість нулів у лівій половині: " + zeros.GetLength(0));
            for (int i = 0; i < zeros.GetLength(0); i++)
                Console.WriteLine("[" + (zeros[i, 0] + 1) + ", " +
                    (zeros[i, 1] + 1) + "] = 0");
        }

        static void Main()
        {
            Console.WriteLine("Лабораторна №1. Нульові елементи лівої половини матриці.");
            Console.Write("Розмір квадратної матриці (1–20): ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 20)
            {
                Console.WriteLine("Помилка: уведіть ціле число від 1 до 20.");
                return;
            }

            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write("Елемент [" + (row + 1) + ", " + (column + 1) + "]: ");
                    int value;
                    if (!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Помилка: елемент має бути цілим числом.");
                        return;
                    }
                    WriteElement(matrix, row, column, value);
                }
            }

            ShowMatrix(matrix);
            ShowZeros(matrix);

            // Перевіряємо читання та запис елемента за довільними координатами.
            Console.Write("Номер рядка для зміни (від 1): ");
            int r;
            bool rowIsNumber = int.TryParse(Console.ReadLine(), out r);
            Console.Write("Номер стовпця для зміни (від 1): ");
            int c;
            bool columnIsNumber = int.TryParse(Console.ReadLine(), out c);
            if (!rowIsNumber || !columnIsNumber)
            {
                Console.WriteLine("Помилка: координати мають бути цілими числами.");
                return;
            }
            r--;
            c--;
            int oldValue;
            if (!ReadElement(matrix, r, c, out oldValue))
            {
                Console.WriteLine("Помилка: вихід за межі матриці.");
                return;
            }
            Console.WriteLine("Поточне значення: " + oldValue);
            Console.Write("Нове ціле значення: ");
            int newValue;
            if (!int.TryParse(Console.ReadLine(), out newValue))
            {
                Console.WriteLine("Помилка: потрібне ціле число.");
                return;
            }
            WriteElement(matrix, r, c, newValue);
            Console.WriteLine("Після зміни:");
            ShowMatrix(matrix);
            ShowZeros(matrix);
        }
    }
}
