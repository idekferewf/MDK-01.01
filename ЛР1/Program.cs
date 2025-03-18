using System;
using System.Collections.Generic;
using System.Linq;

namespace ЛР1
{
    public class Program
    {
        public static Dictionary<string, List<Good>> Goods = new Dictionary<string, List<Good>>
        {
            {
                "Крупы", new List<Good>
                {
                    new Good { Name = "Гречка", Prices = new List<double> { 80, 85, 90, 92 } },
                    new Good { Name = "Рис", Prices = new List<double> { 60, 65, 71, 75 } },
                    new Good { Name = "Овсянка", Prices = new List<double> { 40, 42, 45 } },
                    new Good { Name = "Пшено", Prices = new List<double> { 55, 58, 60 } }
                }
            },
            {
                "Овощи", new List<Good>
                {
                    new Good { Name = "Помидоры", Prices = new List<double> { 150, 140, 435, 25, 53, 123, 160 } },
                    new Good { Name = "Огурцы", Prices = new List<double> { 120, 130, 438, 123, 543, 140 } },
                    new Good { Name = "Картофель", Prices = new List<double> { 30, 32, 35, 38 } },
                    new Good { Name = "Морковь", Prices = new List<double> { 45, 48, 50, 52 } },
                    new Good { Name = "Лук", Prices = new List<double> { 25, 27, 29, 30 } },
                    new Good { Name = "Капуста", Prices = new List<double> { 40, 43, 45, 47 } }
                }
            },
            {
                "Фрукты", new List<Good>
                {
                    new Good { Name = "Яблоки", Prices = new List<double> { 100, 110, 90, 123, 64, 115 } },
                    new Good { Name = "Бананы", Prices = new List<double> { 90, 95, 100, 120, 110, 105 } },
                    new Good { Name = "Апельсины", Prices = new List<double> { 130, 135, 140, 145 } },
                    new Good { Name = "Груши", Prices = new List<double> { 120, 125, 130, 135 } },
                    new Good { Name = "Виноград", Prices = new List<double> { 180, 190, 200, 210 } }
                }
            }
        };

        public static void Main(string[] args)
        {
            // получаем категорию
            Console.Write("Введите категорию товара: ");
            string category = Console.ReadLine();

            // получаем товары по категории
            List<Good> goods = GetGoodsByCategory(category);

            if (goods != null)
            {
                // получаем сортированные товары
                List<Good> sortedGoods = SortGoodsByPrice(goods);

                // выводим результат
                Console.WriteLine($"Товары в категории «{category}» (от дорогих к дешевым):");
                foreach (Good good in sortedGoods)
                {
                    Console.WriteLine($"  {good.Name}. Средняя стоимость - {Math.Round(good.Prices.Average(), 2)}");
                }
            }
            else
            {
                Console.WriteLine($"Товары в категории «{category}» не найдены.");
            }
        }

        public static List<Good> GetGoodsByCategory(string category)
        {
            if (Goods.ContainsKey(category))
            {
                return Goods[category];
            }
            return null;
        }

        public static List<Good> SortGoodsByPrice(List<Good> goods)
        {
            return goods.OrderByDescending(g => g.Prices.Average()).ToList();
        }
    }
}
