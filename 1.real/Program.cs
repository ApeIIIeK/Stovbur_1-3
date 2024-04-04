using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальое кол-во золота: ");
            int Gold = int.Parse(Console.ReadLine());

            int CrytalPrice = 12;
            Console.WriteLine($"Кристалл стоит: {CrytalPrice}");

            Console.WriteLine("Сколько кристаллов вы хотите купить?");
            int CrytalToBuy = int.Parse(Console.ReadLine());

            int cost = CrytalToBuy * CrytalPrice;


            int remainingGold = Gold - cost;

            CrytalToBuy *= Math.Sign(remainingGold);
            remainingGold *= Math.Max(0, Math.Sign(remainingGold));
            if (Gold < cost)
            {
                Console.WriteLine("Сделка не может быть совершена");
                Console.WriteLine($"Кол-во кристаллов у вас: 0");
                Console.WriteLine($"У вас осталось денег: {Gold}");
            }
            else
            {
                Console.WriteLine($"Кол-во кристаллов у вас: {CrytalToBuy}");
                Console.WriteLine($"У вас осталось денег: {remainingGold}");
            };
            Console.ReadKey();
        }
    }
}
