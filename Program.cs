using System;

namespace Store
{
    class Program
    {
        static void Main()
        {
            Store onlineStore = new Store();

            Console.WriteLine("Здравствуйте. Выберите действие:");
            Console.WriteLine("1. Показать каталог продуктов");
            Console.WriteLine("2. Добавить продукт в корзину");
            Console.WriteLine("3. Показать корзину");
            Console.WriteLine("4. Оформить заказ");
            Console.WriteLine("Выберите номер действия, которое хотите совершить.");
            int numberAction = Convert.ToInt32(Console.ReadLine());

            switch (numberAction)
            {
                case 1: onlineStore.ShowCatalog(); break;
                case 2: onlineStore.AddToBasket(1); break;
                case 3: onlineStore.ShowBasket(); break;
                case 4: onlineStore.PutOrder(); break;
                default: Console.WriteLine("Выберите номер действия из списка"); break;
            }

            bool yes;
            do
            {
                Console.WriteLine("Хотите добавить продукт в корзину? Y/N");
                yes = IsYes(Console.ReadLine());
                if (yes)
                {
                    onlineStore.ShowCatalog();
                    Console.WriteLine("Напишите номер продукта, который нужно добавить в корзину");
                    int productNumber = Convert.ToInt32(Console.ReadLine());
                    onlineStore.AddToBasket(productNumber);
                }
            } while (yes);

            Console.WriteLine("Хотите посмотреть корзину? Y/N");
            yes = IsYes(Console.ReadLine());
            if (yes)
            {
                onlineStore.ShowBasket();
            }

            Console.WriteLine("Хотите оформить заказ? Y/N");
            yes = IsYes(Console.ReadLine());
            if (yes)
            {
                onlineStore.PutOrder();
            }
        }

        static bool IsYes(string answer)
        {
            var result = answer.ToLower() == "Y";
            return result;
        }
    }
}
