namespace ЛР2
{
    public class Program
    {
        static void Main()
        {
            // Добавляем товары
            List<Good> goods = new List<Good>();
            goods.Add(new Good("Дрель", 1500, Groups.ForFurniture));
            goods.Add(new Good("Унитаз", 8000, Groups.ForPlumbing));
            goods.Add(new Good("Холодильник", 35000, Groups.ForAppliances));
            goods.Add(new Good("Телевизор", 25000, Groups.ForElectronics));
            goods.Add(new Good("Ноутбук", 60000, Groups.ForComputers));
            goods.Add(new Good("Шкаф", 12000, Groups.ForFurniture));
            goods.Add(new Good("Смеситель", 3000, Groups.ForPlumbing));
            goods.Add(new Good("Пылесос", 7000, Groups.ForAppliances));
            goods.Add(new Good("Смартфон", 40000, Groups.ForElectronics));
            goods.Add(new Good("Клавиатура", 2500, Groups.ForComputers));
            goods.Add(new Good("Стол", 7000, Groups.ForFurniture));
            goods.Add(new Good("Раковина", 4500, Groups.ForPlumbing));
            goods.Add(new Good("Микроволновка", 6000, Groups.ForAppliances));
            goods.Add(new Good("Наушники", 3500, Groups.ForElectronics));
            goods.Add(new Good("Мышь", 1500, Groups.ForComputers));

            // Добавляем товары в продажи
            Sales sales = new Sales();
            sales.AddSale(20230115, goods[0], 2);
            sales.AddSale(20230220, goods[1], 1);
            sales.AddSale(20230310, goods[2], 3);
            sales.AddSale(20230405, goods[3], 1);
            sales.AddSale(20230525, goods[4], 2);
            sales.AddSale(20230612, goods[5], 1);
            sales.AddSale(20230701, goods[6], 4);
            sales.AddSale(20230818, goods[7], 2);
            sales.AddSale(20230903, goods[8], 1);
            sales.AddSale(20231029, goods[9], 3);
            sales.AddSale(20231111, goods[10], 2);
            sales.AddSale(20231205, goods[11], 1);

            // Получаем стоимость по товарной группе
            Groups group = Groups.ForFurniture;
            double result = sales.GetPriceByGroup(group);

            // Выводим результат
            Console.WriteLine($"Товарная группа: {group}");
            Console.WriteLine($"Стоимость всех товаров: {result} руб.");
        }
    }
}
