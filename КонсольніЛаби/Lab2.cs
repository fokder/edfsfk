using System;

namespace Lab2
{
    class Program
    {
        // s — початковий рядок, s1 — результат, n — кількість повторень.
        // out дозволяє передати отриманий рядок назад у Main.
        static void Copies(string s, out string s1, int n)
        {
            s1 = "";
            if (s == "") return;

            for (int i = 0; i < n; i++)
                s1 = s1 + s;
        }

        static void Main()
        {
            Console.WriteLine("Лабораторна №2. Варіант №1. Копіювання рядка.");
            Console.Write("Уведіть рядок: ");
            string s = Console.ReadLine() ?? "";

            Console.Write("Скільки разів повторити рядок? ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Помилка: кількість повторень має бути цілим невід’ємним числом.");
                return;
            }

            // Обмежуємо довжину, щоб не створювати величезний рядок у пам’яті.
            if ((long)s.Length * n > 10000)
            {
                Console.WriteLine("Результат надто довгий. Дозволено до 10000 символів.");
                return;
            }

            string s1;
            Copies(s, out s1, n);
            Console.WriteLine("Результат: [" + s1 + "]");
            Console.WriteLine("Довжина результату: " + s1.Length);
            // Порожній рядок або n = 0 дають порожній результат [].
        }
    }
}
