namespace HomeWorkCollections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> purchases = new Queue<int>(6);
            string userInput = null;
            int cash = 0;

            FillQueue(purchases);
            ShowPurchases(purchases, cash);

            while (purchases.Count > 0)
            {
                Console.Write("\nВведите сумму покупки: ");
                userInput = Console.ReadLine();

                FillPurchases(purchases, userInput, ref cash);

                Console.ReadKey();
                Console.Clear();

                if (purchases.Count == 0)
                {
                    Console.WriteLine("Касса заполнена");
                }
                else ShowPurchases(purchases, cash);

            }
        }

        static void FillQueue(Queue<int> purchases)
        {
            purchases.Enqueue(100);
            purchases.Enqueue(250);
            purchases.Enqueue(500);
            purchases.Enqueue(1000);
            purchases.Enqueue(2000);
            purchases.Enqueue(4000);
        }

        static void FillPurchases(Queue<int> purchases, string userInput, ref int cash)
        {
            int input = System.Convert.ToInt32(userInput);
            
            if (purchases.Contains(input))
            {
                purchases.Dequeue();
                Console.WriteLine("Покупка на " + userInput + " подтверждена");
                cash += Convert.ToInt32(userInput);
            }
            else
            {
                Console.WriteLine("Такой суммы нет");
            }
        }

        static void ShowPurchases(Queue<int> purchases, int cash)
        {
            Console.Write("Касса: " + cash);

            foreach (var purchase in purchases)
            {
                Console.WriteLine("\nДоступные суммы покупок: " + purchase + ',');
            }
        }
    }
}