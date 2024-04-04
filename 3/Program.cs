using System;

namespace _3
{
    using System;

    class Program
    {
        static bool rashamonUsedLastTurn = false;
        static int bossHealth = 50000;
        static int playerHealth = 50000;

        static void Main()
        {
            while (bossHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Выберите заклинание для использования:");
                Console.WriteLine("1. Рашамон - призывает теневого духа для нанесения атаки (Отнимает 100 хп игроку) ");
                Console.WriteLine("2. Хуганзакура - (Может быть выполнен только после призыва теневого духа), наносит 100 ед. урона ");
                Console.WriteLine("3. Межпространственный разлом - позволяет скрыться в разломе и восстановить 150 хп. Урон босса по вам не проходит");
                Console.WriteLine("4. Удар бога фартуны(или нет) - с вероятностью 50% вы можете нанести Боссу 250 урона, либо себе. Все зависит от вашей фортуны");
                Console.WriteLine("5. Экстра побэг - с шансом в 30% вы можете попробовать убежать от босса, но если вам не повезет вы сразу же проиграете");

                int spell = int.Parse(Console.ReadLine());
                switch (spell)
                {

                    case 1:
                        Rashamon();
                        rashamonUsedLastTurn = true;
                        break;
                    case 2:
                        if (rashamonUsedLastTurn == true)
                        {
                            Huganzakura();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
                        }
                        else
                        {
                            Console.WriteLine("Вы должны использовать Хуганзакуру после Рашамона!");
                        }
                        break;
                    case 3:
                        InterdimensionalRift();
                        break;
                    case 4:
                        GodOfFartunePunch();
                        break;
                    case 5:
                        ExtraEscape();
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор заклинания!");
                        break;
                }

                BossAttack();
            }

            if (bossHealth <= 0)
            {
                Console.WriteLine("Вы победили Босса! Поздравляем!");
            }
            else
            {
                Console.WriteLine("Вы проиграли! Босс победил вас!");
            }
        }

        static void Rashamon()
        {
            Console.WriteLine("Вы использовали заклинание Рашамон. Вы получили урон от теневого духа.");
            playerHealth -= 100;
            Console.WriteLine($"У вас осталось: {playerHealth}");
        }

        static void Huganzakura()
        {
            Console.WriteLine("Вы использовали заклинание Хуганзакура. Босс получил 100 урона.");
            bossHealth -= 100;
            Console.WriteLine($"У Босса осталось: {bossHealth}");
        }

        static void InterdimensionalRift()
        {
            Console.WriteLine("Вы скрылись в межпространственном разломе и восстановили 150 хп.");
            playerHealth += 150;
            if (playerHealth > 500)
                playerHealth = 500;
            Console.WriteLine($"Теперь у вас: {playerHealth}");
        }

        static void BossAttack()
        {
            Random rnd = new Random();
            int bossDamage = rnd.Next(25, 100); // Предположим, что урон Босса равен 50
            Console.WriteLine("Босс атакует вас и наносит урон!");
            playerHealth -= bossDamage;
            Console.WriteLine($"Вы получили {bossDamage} урона и у вас осталось: {playerHealth}");
        }
        static void GodOfFartunePunch()
        {
            Random rnd = new Random();
            int punch = rnd.Next(1, 3);
            if (punch == 1)
            {
                Console.WriteLine("Вам улыбнулась фортуна! Вы наносите 250 урона Боссу");
                bossHealth -= 250;
                Console.WriteLine($"У Босса осталось: {bossHealth}");
            }
            else
            {
                Console.WriteLine("Фортуна отвернулась от вас! Вы получаете 250 урона");
                playerHealth -= 250;
                Console.WriteLine($"У вас осталось: {playerHealth}");
                
            }
        }
        public static int ExtraEscape()
        {
            Random rnd = new Random();
            int Escape = rnd.Next(1, 4);
            if (Escape == 1)
            {    
            Console.WriteLine("Вы сбежали!");
            return 1;
            }
            else
            { 
            Console.WriteLine($"Вам не удалось сбежать, вы погибли{playerHealth = 0}");

            return 0;
            }

        }
    }
}
