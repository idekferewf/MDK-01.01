namespace ЛР2
{
    public class Sales
    {
        public struct Sale
        {
            public int date { get; set; }
            public Good good { get; set; }
            public int quantity { get; set; }
        }

        private Dictionary<Groups, List<Sale>> history_ = new Dictionary<Groups, List<Sale>>();

        public void AddSale(int date, Good good, int quantity)
        {
            // Создаём продажу
            Sale sale = new Sale
            {
                date = date,
                good = good,
                quantity = quantity,
            };

            // Проверяем, есть ли запись для этой группы
            Groups group = good.GetGroup();
            if (!history_.ContainsKey(group))
            {
                history_.Add(group, new List<Sale>());
            }

            // Добавляем запись продажи
            history_[group].Add(sale);
        }

        public double GetPriceByGroup(Groups group)
        {
            double price = 0;

            // Проверяем, есть ли записи для этой группы
            if (history_.ContainsKey(group))
            {
                // Перебираем все продажи и определяем стоимость
                foreach (Sale sale in history_[group])
                {
                    price += sale.good.GetPrice() * sale.quantity;
                }
            }

            return price;
        }
    }
}
