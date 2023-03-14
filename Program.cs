using System;
using System.Collections.Generic;

namespace OOP_14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Bullet> bullets = new List<Bullet>(); // Створення масиву куль

            // Заповнення масиву куль
            bullets.Add(new Bullet(2.0));
            bullets.Add(new Bullet(1.0));
            bullets.Add(new Bullet(3.0));

            // Виведення інформації про об'єкти масиву
            Console.WriteLine("Before sorting:");
            foreach (Bullet bullet in bullets)
            {
                Console.WriteLine($"Radius: {bullet.Radius:F2}");
                bullet.print_val();
                Console.WriteLine();
            }

            // Сортування масиву за радіусом
            bullets.Sort((s1, s2) => s1.Radius.CompareTo(s2.Radius)); /*Если размер секции меньше или равен 16 элементам, он использует алгоритм сортировки вставки.
                                                                        Если число секций превышает 2 журнала n, где n — это диапазон входного массива, он использует алгоритм Heapsort.
                                                                        В противном случае используется алгоритм Quicksort.*/

            // Виведення відсортованого масиву
            Console.WriteLine("After sorting:");
            foreach (Bullet bullet in bullets)
            {
                Console.WriteLine($"Radius: {bullet.Radius:F2}");
                bullet.print_val();
                Console.WriteLine();
            }
        }
    }
}