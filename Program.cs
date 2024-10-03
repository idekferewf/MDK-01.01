using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        public struct Good
        {
            public string name;
            public List<int> prices;

            public double AveragePrice()
            {
                int sum = 0;
                foreach (int price in prices)
                {
                    sum += price;
                };
                return sum / prices.Count;
            }
        }

        public static Dictionary<string, List<Good>> Goods = new Dictionary<string, List<Good>>()
        {
            { "Крупы", new List<Good>() {
                new Good() { name = "Гречка", prices = new List<int>() { 107, 105, 106, 108, 106, 102, 99, 100 } },
                new Good() { name = "Киноа", prices = new List<int>() { 191, 185, 180, 183, 190, 189, 187, 200 } },
                new Good() { name = "Кускус", prices = new List<int>() { 181, 175, 177, 178, 180, 190, 185, 169 } },
                new Good() { name = "Чечевица", prices = new List<int>() { 154, 150, 151, 160, 153, 159, 161 } },
                new Good() { name = "Рис", prices = new List<int>() { 114, 119, 120, 139, 109, 110, 101 } },
                new Good() { name = "Ячневая крупа", prices = new List<int>() { 70, 74, 75, 79, 78, 90, 85, 65 } },
                new Good() { name = "Горох", prices = new List<int>() { 78, 70, 73, 76, 85, 83, 81 } }
            }},
            { "Овощи", new List<Good>() {
                new Good() { name = "Морковь (1 кг.)", prices = new List<int>() { 55, 58, 60, 63, 59, 57, 61, 56, 62, 64 } },
                new Good() { name = "Свекла (1 кг.)", prices = new List<int>() { 115, 118, 120, 121, 119, 116, 122, 117, 123, 125 } },
                new Good() { name = "Огурцы (1 кг.)", prices = new List<int>() { 85, 88, 90, 92, 89, 86, 91, 87, 93, 95 } },
                new Good() { name = "Помидоры (1 кг.)", prices = new List<int>() { 215, 218, 220, 223, 219, 216, 221, 217, 224, 226 } },
                new Good() { name = "Лук (1 кг.)", prices = new List<int>() { 25, 28, 30, 33, 29, 27, 31, 26, 32, 34 } },
                new Good() { name = "Картофель (1 кг.)", prices = new List<int>() { 35, 38, 40, 41, 39, 36, 42, 37, 43, 45 } }
            }},
            { "Фрукты", new List<Good>() {
                new Good() { name = "Яблоки (1 кг.)", prices = new List<int>() { 71, 73, 76, 78, 75, 72, 77, 74, 79, 81 } },
                new Good() { name = "Апельсины (1 кг.)", prices = new List<int>() { 125, 128, 130, 132, 129, 126, 131, 127, 133, 135 } },
                new Good() { name = "Мандарины (1 кг.)", prices = new List<int>() { 99, 102, 105, 108, 110, 115, 98, 103, 106, 112 } },
                new Good() { name = "Груши (1 кг.)", prices = new List<int>() { 85, 88, 90, 92, 89, 86, 91, 87, 93, 95 } },
                new Good() { name = "Бананы (1 кг.)", prices = new List<int>() { 55, 58, 60, 62, 59, 56, 61, 57, 63, 65 } },
                new Good() { name = "Виноград (1 кг.)", prices = new List<int>() { 150, 155, 160, 165, 158, 152, 147, 153, 157, 162 } }
            }}
        };
        
        public static List<Good> GetGoodsByCategory(string category)
        {
            if (Goods.ContainsKey(category))
                return Goods[category];
            return null;
        }

        public static List<Good> SortGoodsByPrice(List<Good> goods)
        {
            goods.Sort((good1, good2) => good2.AveragePrice().CompareTo(good1.AveragePrice()));
            return goods;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите категорию: ");
            string category = Console.ReadLine();

            List<Good> goods = GetGoodsByCategory(category);

            if (goods != null)
            {   
                goods = SortGoodsByPrice(goods);

                Console.WriteLine($"\nСписок товаров категории '{category}', сортированных по убыванию цены:");
                foreach (Good good in goods)
                {
                    Console.WriteLine($"Название: {good.name}; Цена: {good.AveragePrice()}.");
                }
            } else
            {
                Console.WriteLine("Такой категории не существует.");
            }

            Console.ReadKey();
        }
    }
}
